namespace Uzduotis13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intervalas110 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int lyginiai = 0;
        }
    }
    public class LyginiaiSkaiciai
    {
        public static int Intervalas_1_10(int[] intervalas110, int lyginiai)
        {
            foreach (int i in intervalas110)
            {
                if (i % 2 == 0)
                {
                    lyginiai++;
                }
            }
            return lyginiai;
        }
    }
}
