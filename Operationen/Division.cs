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