//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        Kuerzen.cs
//Datum:        08.07.2020
//Beschreibung: Kürzt einen Bruch.
//Aenderungen:  08.07.2020 Erstellung

namespace Bruchrechner
{
    partial class main
    {
        static void Kuerzen(ref Bruch bruch)
        {
            if (bruch.zaehler != 0)
            {
                int ggt = BerechneGgt(bruch.nenner, bruch.zaehler);
                bruch.zaehler /= ggt;
                bruch.nenner /= ggt;
            }
            else
            {
                //Nichts
            }
        }
    }
}