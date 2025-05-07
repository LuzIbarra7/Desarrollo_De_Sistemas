using System.Runtime.InteropServices.ObjectiveC;
using System.Security.Cryptography.X509Certificates;

/*Console.WriteLine("Ingrese un número: ");
int numero1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la operacion (+  - * /)");
string operacion = Console.ReadLine();

Console.WriteLine("Ingrese otro número: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

double Resultado = Calcular(numero1, operacion, numero2);
Console.WriteLine("Resultado:" + Resultado);*/

int numero1;
int numero2;
double Resultado;
string operacion;

string otronumero = "si";
do
{
    Console.WriteLine("Ingrese un número: ");
    numero1 = Int32.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la operacion (+  - * /)");
    operacion = Console.ReadLine();

    Console.WriteLine("Ingrese otro número: ");
    numero2 = Convert.ToInt32(Console.ReadLine());

    Resultado = Calcular(numero1, operacion, numero2);
    Console.WriteLine("Resultado:" + Resultado);

    Console.WriteLine("Quieres ingresar otro numero (si o no).");
    otronumero = Console.ReadLine();
}
while (otronumero == "si");



double Calcular(int num1, string operador, int num2)
{
    if (operador == "+")
        return Sumar(num1, num2);
    else if (operador == "-")
        return Restar(num1, num2);
    else if (operador == "*")
        return Multiplicar(num1, num2);
    else if (operador == "/")
        return Dividir(num1, num2);
     else
    {
        Console.WriteLine("El operador no esta activo");
        return 0;
    }
}

int Sumar(int num1,int num2)
{
    if (num1 < 0 || num2 < 0)
    {
        Console.WriteLine("Ingrese un numero mayor a 0");
        return 0;
    }
    else
        return num1 + num2;
}

int Restar(int num1, int num2)
{
    if (num1 < 0 || num2 < 0)
    {
        Console.WriteLine("Ingrese un numero mayor a 0");
        return 0;
    }
    else
        return num1 - num2;
}

int Multiplicar (int num1, int num2)
{
    if (num1 < 0 || num2 < 0)
    {
        Console.WriteLine("Ingrese un numero mayor a 0");
        return 0;
    }
    else
        return num1 * num2;
}

double Dividir(double num1, double num2)
{
    if (num1 < 0 || num2 < 0)
    {
        Console.WriteLine("Ingrese un numero mayor a 0");
        return 0;
    }
    else
        return num1 / num2;
}