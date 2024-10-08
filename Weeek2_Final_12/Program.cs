static int FindMaxNumber() // sinirsiz girilen sayilarin en buyugunu bulan metot
{
    int maxNumber = int.MinValue;
    bool isFirstInput = true;

    while (true)
    {
        Console.WriteLine("Bir sayi giriniz (çıkmak için 'q' basın):");
        string input = Console.ReadLine();

        // Kullanici cikmak istediginde
        if (input.ToLower() == "q")
        {
            break; // donguden cikar
        }

        // girdiyi sayiya cevirme ve kontrol etme
        if (int.TryParse(input, out int number))
        {
            // ilk girisse veya yeni girilen sayi daha buyukse guncelle
            if (isFirstInput || number > maxNumber)
            {
                maxNumber = number;
                isFirstInput = false; // ilk sayi girildi
            }
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen bir tam sayı girin.");
        }
    }

    return maxNumber;
}

int maxNumber = FindMaxNumber();
Console.WriteLine($"Girdiğiniz sayıların en büyüğü: {maxNumber}");