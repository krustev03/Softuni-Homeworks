using MusicHub.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace MusicHub.DataProcessor.ImportDtos
{
    [XmlType("Song")]
    public class ImportSongDto
    {
        [XmlElement("Name")]
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        [XmlElement("Duration")]
        public string Duration { get; set; }

        [XmlElement("CreatedOn")]
        public string CreatedOn { get; set; }

        [XmlElement("Genre")]
        public string Genre { get; set; }

        [XmlElement("AlbumId")]
        public int? AlbumId { get; set; }

        [XmlElement("WriterId")]
        public int WriterId { get; set; }

        [XmlElement("Price")]
        [Range(typeof(decimal), "0", "100000000000000000000")]
        public decimal Price { get; set; }
    }
}
