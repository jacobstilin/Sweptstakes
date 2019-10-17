using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public Dictionary<int, Contestant> dictionary;
        public Random random;
        public Contestant sweepstakesWinner;

        public Sweepstakes(string name, Random random)
        {
            dictionary = new Dictionary<int, Contestant>();
            this.random = random;
            MakeContestants();
            PickWinner();
        }

        

        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = (dictionary.Count + 1);
            dictionary.Add(contestant.registrationNumber, contestant);
        }

        public void MakeContestants()
        {
            // This method creates contestants for each sweepstakes when the sweepstakes is instantiated. To keep it simple, 20 contestants with random names are created. 

            for (int i = 0; i < 20; i++)
            {
                Contestant contestant = new Contestant(random);
                contestant.registrationNumber = (i + 1);
                RegisterContestant(contestant);

            }
        }

        public void NotifyContestants()
        {
            Console.Clear();
            foreach (var item in dictionary.Keys)
            {
                if (item == sweepstakesWinner.registrationNumber)
                {
                    Console.WriteLine("Congratulations, " + sweepstakesWinner.name + ", you have won!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Hey " + dictionary[item].name + " you didn't win, lol, " + sweepstakesWinner.name + " did.");
                    Console.WriteLine();
                }
            }
        }
        public Contestant PickWinner()
        {
            Contestant winner = dictionary[random.Next(dictionary.Count)];
            sweepstakesWinner = winner;
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.name);
        }
    }
}
