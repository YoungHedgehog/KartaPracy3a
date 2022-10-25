ZADANIE 1
for (int i = 1; i < 31; i++)
{
    Console.WriteLine(i);
}

ZADANIE 2
for (int i = 1; i <= 100; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i*i);
    }
}

ZADANIE 3
for (int i = 1000; i <= 9999; i++)
{
    if (i % 379 == 0)
    {
        Console.WriteLine(i);
    }
}

ZADANIE 4
for (int i = 100; i < 999; i++)
{
    if (i % 5 == 0 && i % 6 == 0 || i % 11 == 0)
    {
        Console.WriteLine(i);
    }
}

ZADANIE 5
int n_liczb = int.Parse(Console.ReadLine());
int c=0;
for (int i = 0; i < n_liczb; i++)
{
    int a = int.Parse(Console.ReadLine());
    c += a;
}
Console.WriteLine(c);

ZADANIE 6
int k = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 0; i <= k; i++)
{
    if (i % 2 == 0)
    {
        suma += i;
    }
}
Console.WriteLine(suma);

ZADANIE 7
Console.WriteLine("Podaj do jakiej liczby dwucyfrowej ma policzyc sume nie parzytstych");
int m = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 10; i < m; i++)
{
    if (i % 2 != 0)
    {
        suma += i;
    }
}
Console.WriteLine(suma);

ZADANIE 8
Console.WriteLine("Podaj kwotę");
int w = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj okres inwestycji w latach");
double kwota = double.Parse(Console.ReadLine());
double wynik = 0;
double miesiace = w * 12;
for (int i = 0; i <= w; i++)
{
    wynik += kwota * 6.00 / 100;
}
kwota += wynik;
Console.WriteLine(kwota);

ZADANIE 9
Console.WriteLine("Prosze podac liczbe");
int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 21; i <= (n - 1)*100 + 21; i += 100)
{
    suma += i;
}
Console.WriteLine(suma);
