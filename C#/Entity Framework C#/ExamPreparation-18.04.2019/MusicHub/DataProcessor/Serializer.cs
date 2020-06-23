﻿namespace MusicHub.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using Data;
    using MusicHub.Data.Models;
    using MusicHub.DataProcessor.ExportDtos;
    using Newtonsoft.Json;

    public class Serializer
    {
        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var albums = context
                .Albums
                .Where(a => a.ProducerId == producerId)
                .Select(a => new
                {
                    AlbumName = a.Name,
                    ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
                    ProducerName = a.Producer.Name,
                    Songs = a.Songs.Select(s => new
                        {
                            SongName = s.Name,
                            Price = s.Price.ToString("F2"),
                            Writer = s.Writer.Name
                        })
                        .OrderByDescending(s => s.SongName)
                        .ThenBy(s => s.Writer)
                        .ToArray(),
                    AlbumPrice = a.Price.ToString("F2")
                })
                .OrderByDescending(a => decimal.Parse(a.AlbumPrice))
                .ToArray();

            return JsonConvert.SerializeObject(albums, Newtonsoft.Json.Formatting.Indented); 
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var songs = context.Songs
                .Where(d => d.Duration.TotalSeconds > duration)
                .Select(x => new ExportSongDto
                {
                    SongName = x.Name,
                    Writer = x.Writer.Name,
                    Performer = x.SongPerformers.Select(p => p.Performer.FirstName + " " + p.Performer.LastName).FirstOrDefault(),
                    AlbumProducer = x.Album.Producer.Name,
                    Duration = x.Duration.ToString("c")
                })
                .OrderBy(x => x.SongName)
                .ThenBy(w => w.Writer)
                .ToArray();

            var xmlSerializer = new XmlSerializer(typeof(ExportSongDto[]), new XmlRootAttribute("Songs"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces(new[]
            {
                XmlQualifiedName.Empty
            });
            xmlSerializer.Serialize(new StringWriter(sb), songs, namespaces);

            return sb.ToString().TrimEnd();
        }
    }
}