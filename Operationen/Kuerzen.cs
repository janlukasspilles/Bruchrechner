namespace Bruchrechner
{
    partial class main
    {
        static void Kuerzen(ref Bruch bruch)
        {
            int ggt = BerechneGgt(bruch.nenner, bruch.zaehler);
            bruch.zaehler /= ggt;
            bruch.nenner /= ggt;
        }
    }
}