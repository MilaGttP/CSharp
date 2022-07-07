
using static System.Console;

namespace Classes
{
    internal partial class Classes
    {
        static void SquareSymbolTest()
        {
            Write("Enter a square side -> "); int side = Convert.ToInt32(ReadLine());
            Write("Enter a symbol -> "); string symbol = ReadLine();
            FillAndShowSquare(side, symbol);
        }
        static void PalindromTest()
        {
            Write("Enter your number -> "); int number = Convert.ToInt32(ReadLine());
            if (IsPalindrom(number) == true) WriteLine("Your number is a palindrom!");
            else WriteLine("Your number isn`t a palindrom!");
        }
        static void FilterArrayTest()
        {
            Write("Enter an origin array -> "); string origin = ReadLine();
            Write("Enter a filtering array -> "); string filtering = ReadLine();
            WriteLine($"Resulting array: {FilteringArray(origin, filtering)}");
        }
        static void ClassWebsiteTest()
        {
            Website website = new Website();
            website.Enter();
            WriteLine(website.ToString());
            Website otherWebsite = new Website("MyStat", "https://mystat.itstep.org/ua/main/dashboard/page/index", "Website for students of STEP Academy", "172.67.23.193");
            WriteLine(otherWebsite.ToString());
        }
        static void ClassMagazineTest()
        {
            Magazine magazine = new Magazine();
            magazine.Enter();
            WriteLine(magazine.ToString());
            Magazine otherMagazine = new Magazine("Time", 1923, "TIME Magazine has been one of the most authoritative " +
                "and informative guide to what is happening in current affairs, politics, business, health, " +
                "science and entertainment.", "0345 045 0360", "letters@time.com");
            WriteLine(otherMagazine.ToString());
        }
        static void ClassShopTest()
        {
            Shop shop = new Shop();
            shop.Enter();
            WriteLine(shop.ToString());
            Shop otherShop = new Shop("Samsung", "South Korea", "Devices shop", "1-800-40-726-7864", "s.help@samsung.com");
            Write(otherShop.ToString());
        }
    }
}