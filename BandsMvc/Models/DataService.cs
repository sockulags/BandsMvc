namespace BandsMvc.Models
{
    public class DataService
    {
        List<Band> bands = new List<Band>
        {
            new Band {Name = "Kreator", Id=1, Description="Det tyska trashmetalbandet", ImagePath="/Assets/kreator-2022.jpg"},
            new Band {Name = "Metallica", Id=23, Description="Metalbandet", ImagePath="/Assets/metallica.jpg"},
            new Band {Name = "Offspring", Id=34, Description="Punk", ImagePath = "/Assets/offspring.jpg"}
        };

        public Band? GetBandById(int id)
        {
            return bands.FirstOrDefault(x=>x.Id == id);
        }

        public Band[] GetAllBands()
        {
            return bands.ToArray();
        }
    }
}
