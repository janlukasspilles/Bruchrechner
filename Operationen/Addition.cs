//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        Addition.cs
//Datum:        08.07.2020
//Beschreibung: Addiert zwei Brüche
//Aenderungen:  08.07.2020 Erstellung

namespace Bruchrechner
{
    partial class main
    {
        static void Addition(ref Bruch summandA, ref Bruch summandB, ref Bruch ergebnis)
        {
            AufGleichenNenner(ref summandA, ref summandB);
            ergebnis.zaehler = summandA.zaehler + summandB.zaehler;
            ergebnis.nenner = summandA.nenner;
        }
    }
}