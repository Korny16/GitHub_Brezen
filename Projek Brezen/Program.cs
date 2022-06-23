Console.WriteLine("Zadej první číslo: ");
int cislo1 = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.Write("Zadej druhé číslo: ");
int cislo2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (cislo1 > cislo2)
{
    Console.WriteLine($"Číslo {cislo1} je větší než číslo {cislo2}");
}
if (cislo1 == cislo2)
{
    Console.WriteLine($"Čísla jsou stejně velká");
}
else
{
    Console.WriteLine($"Číslo {cislo2} je větší než číslo {cislo1}");
}