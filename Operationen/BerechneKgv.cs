//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        BerechneKgv.cs
//Datum:        08.07.2020
//Beschreibung: Berechnet das kleinste gemeinsame Vielfache von zwei Zahlen.
//Aenderungen:  08.07.2020 Erstellung

namespace Bruchrechner
{
    partial class main
    {
        static int BerechneKgv(int zahl1, int zahl2)
        {
            return zahl1 * zahl2 / BerechneGgt(zahl1, zahl2);
        }
    }
}