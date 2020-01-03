using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tågtenta
{
    class Seat //uppgift 2 skapa klasser
    {

        public int SeatNumber { get; set; } //gör först properties (uppgift 2) 
        public string Type { get; set; }
        public bool IsTaken { get; set; }

      
        public Seat() //gör en tom konstruktor
        {
            
        }

        public Seat(int seatNumber) //tilldela properties variabler så att jag kan använda det när jag tilldelar nummer
        {
            SeatNumber = seatNumber;

        }

        

        public string TranslateIsTaken() //för att översätta bool till bra sträng.
        {
            if (IsTaken == true)
            {
                return "Upptagen";
            }
            return "Ledig";

        }

        public override string ToString() //ändrat strängens utseende med en basmetod 
        {
            return $"Plats: {SeatNumber} ({Type}) är {TranslateIsTaken()}";
        }
    }
}
