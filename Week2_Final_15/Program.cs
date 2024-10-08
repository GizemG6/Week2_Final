static double Distance(double speed, double time) // hizi(km/saat) ve zamani(saat) alip yolu(km) donduren metot
{
    return speed * time;
}

Console.WriteLine("Hizi (km/saat cinsinden) giriniz:");
double speed = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Zamani (saat cinsinden) giriniz:");
double time = Convert.ToDouble(Console.ReadLine());

double distance = Distance(speed, time);
Console.WriteLine($"Gidilen yol : {distance} kilometre");