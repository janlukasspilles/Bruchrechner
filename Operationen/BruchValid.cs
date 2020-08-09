//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        BruchValid.cs
//Datum:        08.07.2020
//Beschreibung: Überprüft, ob ein Bruch valide ist, also ob der Nenner ungleich 0 ist.
//Aenderungen:  08.07.2020 Erstellung

namespace Bruchrechner
{
    partial class main
    {
        static bool BruchValid(Bruch b)
        {
            if(b.nenner != 0)
            {
                return true;
            }
            return false;
        }
    }
}