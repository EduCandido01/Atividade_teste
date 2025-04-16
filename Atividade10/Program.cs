class Program
{
    public static void Main()
    {
        Console.WriteLine("digite sua senha");
        int senha = Convert.ToInt32(Console.ReadLine());

        bool resultado = senha == 12345;

        if (resultado)
        {
            Console.WriteLine("senha correta");
        }
    }
}