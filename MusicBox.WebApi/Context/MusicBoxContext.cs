using Microsoft.EntityFrameworkCore;

namespace MusicBox.WebApi.Context
{
    public class MusicBoxContext : DbContext
    {
        public MusicBoxContext(DbContextOptions<MusicBoxContext> options) 
            : base(options)
        { }
    }
}
