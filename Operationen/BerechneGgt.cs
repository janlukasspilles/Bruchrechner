//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        BerechneGgt.cs
//Datum:        08.07.2020
//Beschreibung: Berechnet den größten gemeinsamen Teiler von zwei Zahlen.
//Aenderungen:  08.07.2020 Erstellung

namespace Bruchrechner
{
    partial class main
    {
        static int BerechneGgt(int zahl1, int zahl2)
        {
            //Diese Variable wird bei Wertzuweisungen zwischen den Zahlen benutzt
            int temp = 0;
            while (zahl1 % zahl2 != 0)
            {
                temp = zahl1 % zahl2;
                zahl1 = zahl2;
                zahl2 = temp;
            }
            return zahl2;
        }
    }
}