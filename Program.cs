using System;
class Program
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        DateTime utcNow = DateTime.UtcNow;
        string date = now.ToString("dd-MM-yyyy hh:mm:ss tt");
        string date1 = now.ToString("dd-MMM-yyyy HH:mm:ss");
        int year = now.Year;
        int month = now.Month;
        int hour = now.Hour;
        int today = now.Day;
        TimeSpan time = now.TimeOfDay;
        string afterDay = now.AddDays(-3).ToString("dd-MM-yyyy");

        Console.WriteLine(now);
        Console.WriteLine(utcNow);
        Console.WriteLine(date);
        Console.WriteLine(date1);
        Console.WriteLine(year);
        Console.WriteLine(month);
        Console.WriteLine(hour);
        Console.WriteLine(today);
        Console.WriteLine(time);
        Console.WriteLine(afterDay);

        Console.WriteLine("\nEx2****************************************************************\n");

        Console.WriteLine("Enter your input: ");
        string input = Console.ReadLine();
        string result = input == "yes" ? "the input equal yes" : (input == "Yes" ? "the input equal yes" : (input == "yEs" ? "the input equal yEs" : "the input equal no "));
        Console.WriteLine(result);

        Console.WriteLine("\nEx3****************************************************************\n");

        Console.WriteLine(Math.Sqrt(9));        // 3
        Console.WriteLine(Math.Abs(-5));        // 5
        Console.WriteLine(Math.Pow(2, 3));      // 8
        Console.WriteLine(Math.Round(2.4));     // 2
        Console.WriteLine(Math.Round(2.5));     // 2 (التقريب للأقرب زوجي)
        Console.WriteLine(Math.Ceiling(4.2));   // 5
        Console.WriteLine(Math.Floor(4.9));     // 4
        Console.WriteLine(Math.Max(4, 100));    // 100
        Console.WriteLine(Math.Min(4, 100));    // 4
        Console.WriteLine(Math.Max(Math.Max(20, 4), 25)); // 25
        Console.WriteLine(Math.Round(Math.Sqrt(50)));     // 7

        Console.WriteLine("\nEx4****************************************************************\n");

        Console.WriteLine("Enter your input:"); // اطلب من المستخدم إدخال نص
        string str = Console.ReadLine();        // اقرأ النص من المستخدم

        // 🔹 دوال التحويل والاستبدال
        string strUpper = str.ToUpper();         // تحويل إلى أحرف كبيرة
        string strLower = str.ToLower();         // تحويل إلى أحرف صغيرة
        string strReplace = str.Replace("O", "X"); // استبدال 'o' بـ 'X'

        // 🔹 دوال الفحص والطول
        int strLength = str.Length;              // إرجاع عدد الأحرف
        bool strContains = str.Contains("Full"); // هل يحتوي على كلمة "Full"
        bool strStartsWith = str.StartsWith("CC"); // هل يبدأ بـ "CC"
        bool strEndsWith = str.EndsWith("mp");     // هل ينتهي بـ "mp"

        // 🔹 دوال القص والإضافة
        string strSubString = str.Substring(2, 6); // أخذ 6 أحرف بدءًا من الفهرس 2
        string strInsert = str.Insert(5, "Az");     // إدخال رمز بعد الحرف الخامس

        // 🔹 دوال إزالة الفراغات
        string strTrim = str.Trim();               // إزالة الفراغات من البداية والنهاية

        // 🔹 فحص القيم الفارغة أو البيضاء فقط (فراغات)
        bool isNullOrEmpty = string.IsNullOrEmpty(str);         // هل النص فارغ أو null
        bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(str); // هل النص فارغ أو يحتوي فقط على فراغات

        // 🔹 طباعة النتائج
        Console.WriteLine($"str => {str}");
        Console.WriteLine($"ToUpper: {strUpper}");
        Console.WriteLine($"ToLower: {strLower}");
        Console.WriteLine($"Replace: {strReplace}");
        Console.WriteLine($"Length: {strLength}");
        Console.WriteLine($"Contains 'Full': {strContains}");
        Console.WriteLine($"StartsWith 'CC': {strStartsWith}");
        Console.WriteLine($"EndsWith 'mp': {strEndsWith}");
        Console.WriteLine($"Substring(2,6): {strSubString}");
        Console.WriteLine($"Insert(5,A): {strInsert}");
        Console.WriteLine($"Trim: {strTrim}");
        Console.WriteLine($"IsNullOrEmpty: {isNullOrEmpty}");
        Console.WriteLine($"IsNullOrWhiteSpace: {isNullOrWhiteSpace}");
















    }
}
