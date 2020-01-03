using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tågtenta
{
    class Wagon //var public men tog bort det för det tjorvade
    {

        List<Seat> ListSeats { get; set; } = new List<Seat>(); //gör först properties // gjort den public och tog bort sen men det funkade ändå

        public Wagon(int numberOfSeats)
        {
            
            for (int i = 1; i <= numberOfSeats; i++) //den börjar på 1 och slutar först när den är mindre eller lika med 32
            {
                Seat seat = new Seat(i); // varje nytt säte  ska tilldelas indexnummer (i seat klassen har jag tilldelat porpertie i en konstruktor)
                ListSeats.Add(seat); //(lägger till säte i listan
                if (i % 2 == 0)
                {
                    seat.Type = "Gång";
                }
                else if (i % 1 == 0)
                {
                    seat.Type = "Fönster";
                }

            }
            FillSeats();
        }



        public List<Seat> GetSeats()
        {
            return ListSeats;
        }

        Random slumpUpptagen = new Random();
        public void FillSeats()
        {
            foreach (Seat currentseat in ListSeats) // Loopa igenom ALLA säten
            {
                int randomValue = slumpUpptagen.Next(0, 2);

                if (randomValue == 0)
                {
                    currentseat.IsTaken = false;

                }

                else if (randomValue == 1)
                {
                    currentseat.IsTaken = true;
                }
            }

        }

        public List<Seat> GetFreeSeats(int numberoftravelers)
        {
            int counter = 0;
            List<Seat> FreeSeats = new List<Seat>();
            foreach (Seat currentseat in ListSeats)
            {

                if (!currentseat.IsTaken)
                {
                    counter++;
                    FreeSeats.Add(currentseat);
                }
                if (counter == numberoftravelers)
                {
                    return FreeSeats;
                }
            }
            return null;



        }
    }
}
