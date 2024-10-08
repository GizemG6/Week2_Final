static bool OddOrEvenNumber(int number) // girilen sayi tekse true, ciftse false donduren metot
{
    if (number % 2 != 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Bir sayi giriniz:");
int input = int.Parse(Console.ReadLine());
bool result = OddOrEvenNumber(input);
Console.WriteLine(result);