# Atividade_teste
 1-------------------------------------------------------------------------------------------------------------------------------------------------------------
 class Program
{
    public static void Main()
    {
        Console.WriteLine("digite um n�mero");
        int num = Convert.ToInt32(Console.ReadLine());

        bool resultado = num >= 0;

        if (resultado)
        {
            Console.WriteLine("O n�mero � positivo");
        }
    }
}

2---------------------------------------------------------------------------------------------------------------------------
class Program
{
    public static void Main()
    {
        Console.WriteLine("digite um n�mero");
        int num = Convert.ToInt32(Console.ReadLine());

        bool resultado = num % 2 == 0;

        if (resultado)
        {
            Console.WriteLine("O n�mero � par");
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
            Console.WriteLine("voc� pode votar");
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

        if (letra == 'a') { Console.WriteLine("� uma vogal"); }
        else if (letra == 'e') { Console.WriteLine("� uma vogal"); }
        else if (letra == 'i') { Console.WriteLine("� uma vogal"); }
        else if (letra == 'o') { Console.WriteLine("� uma vogal"); }
        else if (letra == 'u') { Console.WriteLine("� uma vogal"); }
    }
}

5---------------------------------------------------------------------------------------------------------------------------
class Program
{
    public static void Main()
    {
        Console.WriteLine("digite um n�mero");
        int num = Convert.ToInt32 (Console.ReadLine());

        bool resultado = num % 3 == 0;

        if (resultado)
        {
            Console.WriteLine("O n�mero � multiplo de 3");
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
            Console.WriteLine("o aluno est� aprovado");
        }
    }
}

7---------------------------------------------------------------------------------------------------------------------------
class Program
{
    public static void Main()
    {
        Console.WriteLine("digite um n�mero");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("digite outro n�mero");
        int num2 = Convert.ToInt32(Console.ReadLine());

        bool resultado = num1 == num2;

        if (resultado)
        {
            Console.WriteLine("os n�meros s�o iguais");
        }

    }
}

8---------------------------------------------------------------------------------------------------------------------------
class Program
{
    public static void Main()
    {
        Console.WriteLine("digite um n�mero");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("digite outro n�mero");
        int num2 = Convert.ToInt32(Console.ReadLine());

        bool resultado = num1 != num2;

        if (resultado)
        {
            Console.WriteLine("os n�meros s�o diferentes");
        }

    }
}

9---------------------------------------------------------------------------------------------------------------------------
class Program
{
    public static void Main()
    {
        Console.WriteLine("digite um n�mero");
        int num = Convert.ToInt32(Console.ReadLine());

        bool resultado = num >= 18;

        if (resultado)
        {
            Console.WriteLine("� maior de idade");
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