namespace Hazir_Method_Datetime_Math.Hazir_Method_Datetime_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);  // O anki günün tarih ay yıl saat olarak ekrana getiriyor
            Console.WriteLine(DateTime.Now.Date); // O anki günün sadece tarihi getiriyor saati getirmiyor.
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);  // O anki günün adını ekrana getiriyor string bir ifadeyle
            Console.WriteLine(DateTime.Now.DayOfYear);  // İçinde bulunduğumuz yılın kaçıncı gününde olduğumuzu
            Console.WriteLine(DateTime.Now.ToLongDateString());  // O anki gün ay ve yıl olarak string bir ifadeyle yazdırır

            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());   // saati verir saniye ile beraber
            Console.WriteLine(DateTime.Now.ToShortTimeString());  // saati verir fakat saniye bilgisini yazdırmaz.

            Console.WriteLine(DateTime.Now.AddDays(2));  // o anki günün üstüne 2 gün ekler ve yazdırır.
            Console.WriteLine(DateTime.Now.AddHours(3)); // o anki saatin üstüne 3 saat ekler ve yazdırır.
            Console.WriteLine(DateTime.Now.AddSeconds(30)); // o anki saniyenin üstüne 30 saniye ekler ve yazdırır
            Console.WriteLine(DateTime.Now.AddMonths(5)); // O anki ay bilgisinin üstüne 5 ay ekler ve yazdırır
            Console.WriteLine(DateTime.Now.AddYears(2));  // o anki yıl bilgisinin üstüne 2 yıl ekler ve yazdırır


            // Datetime format

            Console.WriteLine(DateTime.Now.ToString("dd")); // Ayın kaçıncı günün de olduğunun bilgisini verir.(24)
            Console.WriteLine(DateTime.Now.ToString("ddd")); // o anki günü kısaltmasıyla birlikte getirir.(cmt)
            Console.WriteLine(DateTime.Now.ToString("dddd")); // o anki günü tamamı ismiyle getirir.(Cumartesi)

            Console.WriteLine(DateTime.Now.ToString("MM")); //Kaçıncı ay da olduğumuz bilgisini verir.(03)
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Ay bilgisini kısaltmayla yazdırır.(Mar)
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // Ay bilgisini tamamı ismiyle yazdırır.(Mart)

            Console.WriteLine(DateTime.Now.ToString("yy")); // yıl bilgisini kısaltma yazdırır.(23)
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // yıl bilgisini tamamı olarak yazdırır.(2023)

            // Math Kütüphanesi

            Console.WriteLine(Math.Abs(-25)); // Mutlak değer alır.
            Console.WriteLine(Math.Sin(45)); // sinüs alır.
            Console.WriteLine(Math.Cos(135)); // cosinüs alır.
            Console.WriteLine(Math.Tan(45)); // tanjant alır

            Console.WriteLine(Math.Ceiling(22.3)); //22.3 ten büyük en küçük tam sayıyı getirir.her zaman yukarı yuvarlar.
            Console.WriteLine(Math.Round(22.3)); // 22.3 hangisine daha yakın ise yuvarlama işlemi yapar
            Console.WriteLine(Math.Floor(22.7)); // 22.7 den küçük en büyük tam sayıyı getirir.her zaman aşağıya yuvarlar

            Console.WriteLine(Math.Max(2,6)); // iki sayı arasındaki büyük sayıyı yazdırır
            Console.WriteLine(Math.Min(2,6)); // iki sayı arasında küçük sayıyı yazdırır

            Console.WriteLine(Math.Pow(3,4)); // üslü almada kullanılır. Yani 3^4 ü yazdırır.
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Log(9));  // log e tabanında 9 alır
            Console.WriteLine(Math.Exp(3));  // e üzerine 3



        }
    }
}