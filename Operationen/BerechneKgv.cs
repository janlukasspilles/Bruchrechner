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