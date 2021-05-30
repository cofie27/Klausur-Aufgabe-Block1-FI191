using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausur_Aufgabe_Block1_FI191
{
    class Punkt
    {
        //Setzt x und y als private Attribute mit dem Datentyp int
        private int x;
        private int y;

        //Standardkonstruktor
        //hier wird der Punkt mit den Ursprungskoordinaten (0|0) initialisiert
        public Punkt()
        {
          x = 0; 
          y = 0;
        }

       /*Objektorientierter
        * 
        * public string Ausgabe() 
        {
            string ausgabe = " ";
            ausgabe = "(" + x + "|" + y + ")";
            return ausgabe;
        }*/

        //gibt die Koordinaten eines Punktes in der der Form (x|y) auf der Konsole auf
        public void Ausgabe()
        {
            Console.WriteLine("Koordinaten: (" + x + "|" + y + ")");
        }

        //Methode zur Eingabe (von X), die eine Koordinate mit entsprechender Benutzeraufforderung über die Tastatur liest
        public void EingabeX()
        {
            Console.WriteLine("Bitte einen x-Wert eingeben: ");
            x = Convert.ToInt32(Console.ReadLine());
        }

        //Methode zur Eingabe (von Y), die eine Koordinate mit entsprechender Benutzeraufforderung über die Tastatur liest
        public void EingabeY()
        {
            Console.WriteLine("Bitte einen y-Wert eingeben: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        
        //Methode, die den Abstand des Punktes zum Koordinatenursprung auf der Konsole  auf 2 Nachkommastellen gerundet ausgibt
        public void DruckeAbstand()
        {
            float d = ((Convert.ToSingle(((Math.Sqrt((x * x) + (y * y)))))));
            Console.WriteLine("Abstand: " + Math.Round(d, 2));
        }
    }
}
