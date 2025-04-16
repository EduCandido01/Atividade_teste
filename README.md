# Atividade_teste
 1-------------------------------------------------------------------------------------------------------------------------------------------------------------
 class Program
{
    public static void Main()
    {
        Console.WriteLine("digite um número");
        int num = Convert.ToInt32(Console.ReadLine());

        bool resultado = num >= 0;

        if (resultado)
        {
            Console.WriteLine("O número é positivo");
        }
    }
}

2---------------------------------------------------------------------------------------------------------------------------
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

3---------------------------------------------------------------------------------------------------------------------------
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

4---------------------------------------------------------------------------------------------------------------------------
class Program
{
    public static void Main()
    {
        Console.WriteLine("digite uma letra");
        char letra = Convert.ToChar(Console.ReadLine());

        if (letra == 'a') { Console.WriteLine("é uma vogal"); }
        else if (letra == 'e') { Console.WriteLine("é uma vogal"); }
        else if (letra == 'i') { Console.WriteLine("é uma vogal"); }
        else if (letra == 'o') { Console.WriteLine("é uma vogal"); }
        else if (letra == 'u') { Console.WriteLine("é uma vogal"); }
    }
}

5---------------------------------------------------------------------------------------------------------------------------
class Program
{
    public static void Main()
    {
        Console.WriteLine("digite um número");
        int num = Convert.ToInt32 (Console.ReadLine());

        bool resultado = num % 3 == 0;

        if (resultado)
        {
            Console.WriteLine("O número é multiplo de 3");
        }
    }
}

6---------------------------------------------------------------------------------------------------------------------------
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

7---------------------------------------------------------------------------------------------------------------------------
class Program
{
    public static void Main()
    {
        Console.WriteLine("digite um número");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("digite outro número");
        int num2 = Convert.ToInt32(Console.ReadLine());

        bool resultado = num1 == num2;

        if (resultado)
        {
            Console.WriteLine("os números são iguais");
        }

    }
}

8---------------------------------------------------------------------------------------------------------------------------
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

9---------------------------------------------------------------------------------------------------------------------------
class Program
{
    public static void Main()
    {
        Console.WriteLine("digite um número");
        int num = Convert.ToInt32(Console.ReadLine());

        bool resultado = num >= 18;

        if (resultado)
        {
            Console.WriteLine("é maior de idade");
        }
    }
}

10---------------------------------------------------------------------------------------------------------------------------
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