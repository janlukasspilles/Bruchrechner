//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        Division.cs
//Datum:        08.07.2020
//Beschreibung: Berechnet den Quotienten aus zwei Brüchen.
//Aenderungen:  08.07.2020 Erstellung

namespace Bruchrechner
{
    partial class main
    {
        static void Division(ref Bruch divident, ref Bruch divisor, ref Bruch ergebnis)
        {
            ergebnis.zaehler = divident.zaehler * divisor.nenner;
            ergebnis.nenner = divident.nenner * divisor.zaehler;
        }
    }
}