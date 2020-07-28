namespace Bruchrechner
{
    partial class main
    {
        static void Kuerzen(ref Bruch bruch)
        {
            if (bruch.zaehler != 0)
            {
                int ggt = BerechneGgt(bruch.nenner, bruch.zaehler);
                bruch.zaehler /= ggt;
                bruch.nenner /= ggt;
            }
            else
            {
                //Nichts
            }
        }
    }
}