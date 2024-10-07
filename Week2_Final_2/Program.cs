string data; // girilmesi beklenen metinsel veri
bool isText = false; // girilen verinin metinsel veri olup olmadığını tespit edeceğimiz kontrol değişkeni
int value; // girilmesi beklenen tam sayı
bool isInteger = false; // girilen value değerinin int olup olmadığı kontrol edecek değişken

// metinsel veriyi doğru girine kadar
do
{
    Console.WriteLine("Bir adet metinsel veri giriniz:");
    data = Console.ReadLine();

    // Metin olup olmadığını kontrol et
    isText = !string.IsNullOrEmpty(data) && data.All(char.IsLetter);

    if (!isText)
    {
        Console.WriteLine("Girilen veri metinsel değil. Lütfen tekrar deneyin.");
    }
}
while (!isText);

// metinsel veriyi doğru girdikten sonra tam sayı girişi
do
{
    Console.WriteLine("Bir adet tam sayı giriniz:");
    string inputValue = Console.ReadLine();

    // Tam sayı olup olmadığını kontrol et
    isInteger = int.TryParse(inputValue, out value);

    if (!isInteger)
    {
        Console.WriteLine("Girilen veri tam sayı değil. Lütfen tekrar deneyin.");
    }
}
while (!isInteger);

// metinsel veri ve tam sayı doğru girildiğinde ekrana çıktı olarak yazdırma
Console.WriteLine($"Metinsel veri: {data}, Tam sayı: {value}");

