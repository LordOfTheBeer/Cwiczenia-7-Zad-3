namespace Cwiczenia_7_Zad_3
{
   static class Funkcje
   {
        public static int Suma_do_n(int n)
        {
            int i, s = 0;
            for (i = 1; i <= n; i++)
                s += i;
            return s;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)

                Console.WriteLine(i + " " + Funkcje.Suma_do_n(i));
        }
    }
}