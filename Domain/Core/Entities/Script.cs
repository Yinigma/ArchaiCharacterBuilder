
namespace Domain.Core.Entities
{
    public class Script
    {
        public long Id { get; }
        public string Source { get; set; }

        public Script(long id)
        {
            Id = id;
            Source = "";
        }
    }
}
