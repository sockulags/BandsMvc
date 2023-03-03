namespace BandsMvc.Models
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string ImagePath { get; set; }

        public List<string> Albums { get; set; } = new List<string>();

        public string YouTube { get; set; }
    }
}
