using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Kolmion_pinta_ala__yhdessa_27._3._
{
    class Program
    {
        static void Main(string[] args)
        // 6 C# Perus: Kolmion pinta-ala(yhdessä 27.3.)
        // https://moodle.sakky.fi/mod/assign/view.php?id=1159590

        //// Ilmoitetaan käyttäjälle, mitä tietoa pyydetään
        //Console.Write("Anna kolmion kanta: ");
        //// Luetaan käyttäjältä arvo string muodossa
        //// Ja muokataan string -> double muotoon
        //double triangleBase = double.Parse(Console.ReadLine());

        //Console.Write("Anna kolmion korkeus: ");
        //double triangleHeigth = double.Parse(Console.ReadLine());

        //// Voidaan näyttää laskutoimituksen lopputulos suoraan osana tekstiä. Huomioi "Magic Number" -2-
        //Console.WriteLine($"Kolmion pinta-ala on: {triangleBase* triangleHeigth / 2}");

        //// Pysäytetään sovellus
        //Console.WriteLine();
        //Console.WriteLine("Press any key to exit");
        //Console.ReadKey();
        {
            Console.Write("Anna kolmion kanta: ");
            double triangleBase = double.Parse(Console.ReadLine());
            Console.Write("Anna kolmion korkeus: ");
            double triangleHeigth = double.Parse(Console.ReadLine());
            Console.WriteLine($"Kolmion pinta-ala on: {triangleBase * triangleHeigth / 2}");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
