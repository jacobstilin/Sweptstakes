using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string name;
        public string emailAddress;
        public int registrationNumber;
        public List<string> firstNames;
        public List<string> lastNames;
        private Random random;

        public Contestant(Random random)
        {
            firstNames = new List<string>() { "Juan", "Jason", "Ash", "Zofia", "Mustachio", "Pistachio", "Dirk", "Chimmy",
                "Cotter", "Mona", "Moe", "Eggy", "Shorty", "Dennis", "Blake", "Ichobad", "Sonny", "Revolver", "Mugsy",
                "Seymore", "Chimcham", "Johnny", "Jim", "Baba", "Sasha", "Lance", "Buster", "Hugh", "Sarah", "Josh",
                "Tron", "Clayton", "Arthur", "Phrank", "Lionel", "Barbara", "Ahya", "Jimbo", "Stannis", "Sword", "Hugo",
                "Ylgo", "Moe", "Pate", "Gerry", "Susie", "Spittoon", "Tammy", "Don", "Chimchim", "Comishna",
                "Kevin", "Vinny", "Alny", "Balmy", "Aria", "Lexus", "Howland", "Kenya", "Cletus", "Kuvern", "Levernius",
                "Frankie", "Artie", "Gerry", "Chippy", "Joe", "Mauy", "Cam", "Mitch", "Shapiro"

                };
            lastNames = new List<string>()
            {
                "Rombaldi", "JavirSchmidt", "Jager", "Montagne", "Joans", "Pete", "Sweeps", "Putin", "Simpson", "Anna", "Mule", "Boyd", "Cutty", "Donny", "Crane", "Day", "Ocelot",
                "Boags", "Banks", "Bamma", "Flan", "Jamb", "Yaga", "Shaem", "Doozey", "Cripps", "Jnuthin", "Micks", "Odoner",
                "Tron", "Clayton", "Arthur", "Phrank", "Sims", "Waters", "Stahk", "Janus", "Mannis", "Becher", "Thattaway",
                "Dissweh", "Shemp", "PigBwah", "Bimmer", "Spencer", "Bobammy", "Plour", "Chimmaram", "Gordin",
                "Boston", "Deleo", "Palmy", "Wetha", "Sirius", "Texas", "Reed", "Bananas", "Macaque", "Tucker",
                "Carbone", "Schwartz", "McCreary", "McGuire", "Mauma", "Jim", "Rodgers", "Rontalius"
            };
            this.random = random;
            CreateContestant();
            
        }

        private void CreateContestant()
        {
            firstName = firstNames[random.Next(firstNames.Count - 1)];
            lastName = lastNames[random.Next(lastNames.Count - 1)];
            emailAddress = (firstName + lastName + "@yahoo.com");
            name = (firstName + " " + lastName);
        }

        
    }
}
