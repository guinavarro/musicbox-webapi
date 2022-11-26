namespace MusicBox.WebApi.Models.Entities
{
    public class Song : Base
    {
        public string Title { get; set; }
        public Artist Author { get; set; }
        public int AuthorId { get; set; }
        public Album Album { get; set; }
        public int AlbumId { get; set; }
    }
}
