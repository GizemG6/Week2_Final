// 3 yastan en yasli olanı bulan metot
static int Eldest(int age1, int age2, int age3)
{
    int eldest = Math.Max(age1, Math.Max(age2, age3));
    return eldest;
}

Console.WriteLine("Birinci kisinin yasini giriniz:");
int age1 = int.Parse(Console.ReadLine());

Console.WriteLine("İkinci kisinin yasini giriniz:");
int age2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ucuncu kisinin yasini giriniz:");
int age3 = int.Parse(Console.ReadLine());

int eldest = Eldest(age1, age2, age3);
Console.WriteLine($"En yasli kisinin yasi: {eldest}");