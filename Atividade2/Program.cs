class Program
{
    public static void Main()
    {
        Console.WriteLine("digite um número");
        int num = Convert.ToInt32(Console.ReadLine());

        bool resultado = num % 2 == 0;

        if (resultado)
        {
            Console.WriteLine("O número é par");
        }
    }
}