using System;
using System.Collections.Generic;

namespace MusicBox.WebApi.Models.Entities
{
    public class Album : Base
    {
        public string Title { get; set; }
        public Artist Author { get; set; }
        public int AuthorId { get; set; }
        public DateTime Released { get; set; }
        public Genre Genre { get; set; }
        public List<Song> Tracklist { get; set; }

    }
}
