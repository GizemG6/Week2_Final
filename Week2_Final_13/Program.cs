static void SwapNames(string name1, string name2) // girilen 2 ismin yerini degistiren metot
{
    Console.WriteLine($"girilen ilk isim: {name2}, girilen ikinci isim: {name1}");
}

Console.WriteLine("ilk ismi giriniz:");
string fisrtName = Console.ReadLine();

Console.WriteLine("ikinci ismi giriniz:");
string secondName = Console.ReadLine();

SwapNames(fisrtName, secondName);