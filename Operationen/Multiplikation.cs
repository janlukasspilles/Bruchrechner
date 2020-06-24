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