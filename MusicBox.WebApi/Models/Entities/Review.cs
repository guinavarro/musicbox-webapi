using MusicBox.WebApi.Models.Enumerators;

namespace MusicBox.WebApi.Models.Entities
{
    public class Review : Base
    {
        public RatingScale Rating { get; set; }
        public string? Comment { get; set; }
        public int? SongId { get; set; }
        public int? AlbumId { get; set; }
        public int? ArtistId { get; set; }
    }
}
