class Program
{
    public static void Main()
    {
        Console.WriteLine("digite sua idade");
        int idade = Convert.ToInt32(Console.ReadLine());

        bool resultado = idade >= 16;

        if (resultado)
        {
            Console.WriteLine("você pode votar");
        }
    }
}