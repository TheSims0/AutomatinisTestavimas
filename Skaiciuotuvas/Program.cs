namespace Skaiciuotuvas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int skaicius1 = 1;
            int skaicius2 = 3;
        }
        
    }
    public class Skaiciuotuvas
    {
        public static double Dalyba(int skaicius1, int skaicius2)
        {
            return (double)skaicius1 / skaicius2;
        }
        public static double SandaugaDu(double skaicius1, double skaicius2)
        {
            return skaicius1 * skaicius2;
        }
        public static double SudetisDu(double skaicius1, double skaicius2)
        {
            return skaicius1 + skaicius2;
        }
        public static decimal SandaugaDecimal(decimal skaicius1, decimal skaicius2)
        {
            return skaicius1 * skaicius2;
        }
        public static decimal SudetisDecimal(decimal skaicius1, decimal skaicius2)
        {
            return skaicius1 + skaicius2;
        }
    }
}
