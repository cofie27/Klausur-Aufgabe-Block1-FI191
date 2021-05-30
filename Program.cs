using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausur_Aufgabe_Block1_FI191
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zwei Objekte punkt 1 und punkt 2 werdeb erzeugt
            Punkt punkt1 = new Punkt();
            Punkt punkt2 = new Punkt();

            //Eingabeaufforderung von Punkt 2 (x|<)
            punkt2.EingabeX();
            punkt2.EingabeY();

            //Ausgabe von Punkt 1 und Punkt 2
            punkt1.Ausgabe();
            punkt2.Ausgabe();

            //Ausgabe des Abstands d eines Punktes P2 vom Koordinatenursprung
            punkt2.DruckeAbstand();

            //schließt die Konsole erst nach Drücken einer beliebigen Taste
            Console.ReadKey();
        }
    }
}
