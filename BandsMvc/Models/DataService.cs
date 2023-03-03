using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Diagnostics.Metrics;
using System.IO;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Reflection;

namespace BandsMvc.Models
{
    public class DataService
    {
        List<Band> bands = new List<Band>
        {
            new Band {Name = "Kreator", Id=1, Description="Det tyska trashmetalbandet", ImagePath="/Assets/kreator-2022.jpg",
                Albums=new List<string>{
                    "Endless Pain (1985)",
                    "Pleasure to Kill (1986)",
                    "Terrible Certainty (1987)",
                    "Extreme Aggression (1989)",
                    "Coma of Souls (1990)",
                    "Renewal (1992)",
                    "Cause for Conflict (1995)",
                    "Outcast (1997)",
                    "Endorama (1999)",
                    "Violent Revolution (2001)",
                    "Enemy of God (2005)",
                    "Hordes of Chaos (2009)",
                    "Phantom Antichrist (2012)",
                    "Gods of Violence (2017)",
                    "Hate Über Alles (2022)}"}, YouTube="https://www.youtube.com/embed/mUv8GxrqXPk"  },
            new Band {Name = "Metallica", Id=23, Description="Metalbandet", ImagePath="/Assets/metallica.jpg",
                Albums=new List<string>{
                "Kill 'Em All (1983)",
                "Ride the Lightning (1984)",
                "Master of Puppets (1986)",
                "...And Justice for All (1988)",
                "Metallica (1991)",
                "Load (1996)",
                "Reload (1997)",
                "St. Anger (2003)",
                "Death Magnetic (2008)",
                "Hardwired... to Self-Destruct (2016)",
                "72 Seasons (2023)"
                }, YouTube="https://www.youtube.com/embed/CD-E-LDc384" },
            new Band {Name = "The Offspring", Id=34, Description="Punk", ImagePath = "/Assets/offspring.jpg",
                Albums=new List<string>{
                "1989 – The Offspring",
                "1992 – Ignition",
                "1994 – Smash",
                "1997 – Ixnay on the Hombre",
                "1998 – Americana",
                "2000 – Conspiracy of One",
                "2003 – Splinter",
                "2008 – Rise and Fall, Rage and Grace",
                "2012 – Days Go By",
                "2021 – Let the Bad Times Roll"
                
                }, YouTube="https://www.youtube.com/embed/7iNbnineUCI" }
        };




        public Band? GetBandById(int id)
        {
            return bands.FirstOrDefault(x => x.Id == id);
        }

        public Band[] GetAllBands()
        {
            return bands.ToArray();
        }
    }
}
