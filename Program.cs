namespace aula25._2
{
    internal class Program
    {
        static void Main()
        {
            int num = 30;

            dobrar(ref num);

            Console.WriteLine(num);
        }

        static void dobrar(ref int valor)
        {
            valor *= 3;
        }
    }
}