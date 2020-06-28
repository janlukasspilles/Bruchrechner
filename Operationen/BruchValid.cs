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