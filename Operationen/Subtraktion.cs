namespace Bruchrechner
{
    partial class main
    {
        static void Subtraktion(ref Bruch summandA, ref Bruch summandB, ref Bruch ergebnis)
        {
            AufGleichenNenner(ref summandA, ref summandB);
            ergebnis.zaehler = summandA.zaehler - summandB.zaehler;
            ergebnis.nenner = summandA.nenner;
        }
    }
}