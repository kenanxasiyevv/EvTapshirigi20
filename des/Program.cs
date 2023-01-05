namespace des
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Massivin uzunlugunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            double d =(double)arr[1] - arr[0];
            double d1;
            bool ededisilsiledir = true;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                d1 = arr[i + 1] - arr[i];

                if (d != d1)
                {
                    Console.WriteLine("Ededi silsile deyil");
                    ededisilsiledir = false;
                    break;
                }
            }
                if (ededisilsiledir)
                    Console.WriteLine("Ededi silsiledir");
        }
    }
}
