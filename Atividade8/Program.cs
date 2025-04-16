class Program
{
    public static void Main()
    {
        Console.WriteLine("digite um número");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("digite outro número");
        int num2 = Convert.ToInt32(Console.ReadLine());

        bool resultado = num1 != num2;

        if (resultado)
        {
            Console.WriteLine("os números são diferentes");
        }

    }
}