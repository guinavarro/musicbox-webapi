using System.Collections.Generic;

namespace MusicBox.WebApi.Models.Entities
{
    public class Artist : Base
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
        public List<Song> Songs { get; set; }
    }
}
