using MusicHub.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicHub.DataProcessor.ExportDtos
{
    using System.Xml.Serialization;

    [XmlType("Song")]
    public class ExportSongDto
    {
        [XmlElement("SongName")]
        public string SongName { get; set; }

        [XmlElement("Writer")]
        public string Writer { get; set; }

        [XmlElement("Performer")]
        public string Performer { get; set; }

        [XmlElement("AlbumProducer")]
        public string AlbumProducer { get; set; }

        [XmlElement("Duration")]
        public string Duration { get; set; }
    }
}
