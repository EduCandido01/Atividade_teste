class Program
{
    public static void Main()
    {
        Console.WriteLine("digite a nota");
        int nota = Convert.ToInt32(Console.ReadLine());

        bool resultado = nota >= 7;
        if (resultado)
        {
            Console.WriteLine("o aluno está aprovado");
        }
    }
}