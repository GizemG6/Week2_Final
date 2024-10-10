Console.WriteLine("Lütfen yaşınızı giriniz:");
int age = int.Parse(Console.ReadLine());

// 18'den büyükse "+" küçükse "-" yazdırma
if (age > 18)
{
    Console.WriteLine("+");
}
else if (age < 18)
{
    Console.WriteLine("-");
}
else
{
    Console.WriteLine(":)");
}

//Console.WriteLine(age >= 18 ? "+" : "-");