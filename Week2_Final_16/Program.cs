static double CalculateCircleArea(double radius) // yaricapi girilen dairenin alanini bulan metot
{
    return Math.PI * Math.Pow(radius, 2);
}

Console.WriteLine("Dairenin yaricapini giriniz:");
double radius = Convert.ToDouble(Console.ReadLine());

double area = CalculateCircleArea(radius);
Console.WriteLine($"Yaricapini girdiginiz dairenin alanı: {area} birim kare");