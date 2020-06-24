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