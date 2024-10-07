Random random = new Random(); // random sınıfından instance alma

int randomValue = random.Next(); // random sayı oluşturma

// random sayı ve random sayının 3'e bölümünden kalanı ekrana yazdırma
Console.WriteLine($"Uretilen rastgele sayı: {randomValue}, uretilen rastgele sayının 3'e bölümünden kalan: {randomValue % 3}");
