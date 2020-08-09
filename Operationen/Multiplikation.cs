//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        Multiplikation.cs
//Datum:        08.07.2020
//Beschreibung: Berechnet das Produkt aus zwei Brüchen.
//Aenderungen:  08.07.2020 Erstellung

namespace Bruchrechner
{
    partial class main
    {
        static void Multiplikation(ref Bruch multiplikant, ref Bruch multiplikator, ref Bruch ergebnis)
        {
            ergebnis.zaehler = multiplikant.zaehler * multiplikator.zaehler;
            ergebnis.nenner = multiplikant.nenner * multiplikator.nenner;
        }
    }
}