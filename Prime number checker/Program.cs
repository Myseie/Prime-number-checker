Console.Write("Skriv in ett tal: ");
int number;

while(!int.TryParse(Console.ReadLine(), out number) || number < 2)
{
    Console.WriteLine("Vänligen mata in ett heltal större än 1");
}
if (isPrime(number))
{
    Console.WriteLine($"{number} är ett primtal");
}
else
{
    Console.WriteLine($"{number} är inte ett primtal");
}

static bool isPrime(int numb)
{
    if (numb == 2)
    {
        return true;
    }
    if (numb % 2 == 0)
    {
        return false;
    }

    for (int i = 3; i <= Math.Sqrt(numb); i+= 2)
    {
       if (numb % i == 0)
        {
            return false;
        }
    }
    return true;
}