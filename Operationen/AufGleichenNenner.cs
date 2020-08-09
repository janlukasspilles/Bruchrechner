//Autor:        Jan-Lukas Spilles
//Klasse:       IA119
//Datei:        AufGleichenNenner.cs
//Datum:        08.07.2020
//Beschreibung: Bringt zwei Brüche auf den gleichen Nenner
//Aenderungen:  08.07.2020 Erstellung

namespace Bruchrechner
{
    partial class main
    {
        static void AufGleichenNenner(ref Bruch bruchA, ref Bruch bruchB)
        {
            int nennerKgv = BerechneKgv(bruchA.nenner, bruchB.nenner);

            bruchA.zaehler *= nennerKgv / bruchA.nenner;
            bruchB.zaehler *= nennerKgv / bruchB.nenner;
            bruchA.nenner = nennerKgv;
            bruchB.nenner = nennerKgv;
        }
    }
}