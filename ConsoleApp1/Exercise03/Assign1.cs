static void TypeDemo()
{

    Console.WriteLine("----------------------------------ByteDemo----------------------------");
    Console.WriteLine("Value Type");
    Console.WriteLine("------------------------------------------------------------------------------");

    Console.WriteLine("sbyte = {0}\tMaxValue:{1}\tMinValue:{2}\n", typeof(sbyte), sbyte.MaxValue, sbyte.MinValue);

    Console.WriteLine("byte = {0}\tMaxValue:{1}\tMinValue:{2}\n", typeof(byte), byte.MaxValue, byte.MinValue);

    Console.WriteLine("short = {0}\tMaxValue:{1}\tMinValue:{2}\n", typeof(short), short.MaxValue, short.MinValue);

    Console.WriteLine("ushort = {0}\tMaxValue:{1}\tMinValue:{2}\n", typeof(ushort), ushort.MaxValue, ushort.MinValue);

    Console.WriteLine("int = {0}\tMaxValue:{1}\tMinValue:{2}\n", typeof(int), int.MaxValue, int.MinValue);

    Console.WriteLine("uint = {0}\tMaxValue:{1}\tMinValue:{2}\n", typeof(uint), uint.MaxValue, uint.MinValue);

    Console.WriteLine("long = {0}\tMaxValue:{1}\tMinValue:{2}\n", typeof(long), long.MaxValue, long.MinValue);


    Console.WriteLine("ulong = {0}\tMaxValue:{1}\tMinValue:{2}\n", typeof(ulong), ulong.MaxValue, ulong.MinValue);


    Console.WriteLine("float = {0}\tMaxValue:{1}\tMinValue:{2}\n", typeof(float), float.MaxValue, float.MinValue);

    Console.WriteLine("double = {0}\tMaxValue:{1}\tMinValue:{2}\n", typeof(double), double.MaxValue, double.MinValue);

    Console.WriteLine("decimal = {0}\tMaxValue:{1}\tMinValue:{2}\n", typeof(decimal), decimal.MaxValue, decimal.MinValue);
}




static void CentriesConversion()
{

    Console.WriteLine("----------------------------------Century Conversion----------------------------");
    Console.Write("EnterNumber of Centries:");
    int centuries = int.Parse(Console.ReadLine());


    long years = centuries * 100;
    long days = years * 365 + years / 4 - years / 100 + years / 400;
    long hours = days * 24;
    long minutes = hours * 60;
    long seconds = minutes * 60;
    long milliseconds = seconds * 1000;
    long microseconds = milliseconds * 1000;
    ulong nanoseconds = (ulong)microseconds * 1000;

    Console.WriteLine(" {0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = " +
        "{7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);


}
//TypeDemo();
//CentriesConversion();
//Console.WriteLine("int = {0}\tMaxValue:{1}\tMinValue:{2}\n", typeof(int), int.MaxValue, int.MinValue);
//Console.WriteLine(5.0 / 0);
//Console.WriteLine(int.MaxValue + 1);

//for (; true;) ;
//int x = 5;
//int y = 1;
//Console.WriteLine(y++);
//Console.WriteLine(y);
//y = 1;
//Console.Write(++y);


static void fizzbuzz()
{
    Console.WriteLine("----------------------------------Fizzbuzz----------------------------");
    for (int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("i = {0} fizzbuzz", i);

        }

        if (i % 3 == 0)
        {
            Console.WriteLine("i = {0} fizz", i);

        }
        if (i % 5 == 0)
        {
            Console.WriteLine("i = {0} buzz", i);

        }
    }
}

//fizzbuzz();
static void guessNum()
{
    Console.WriteLine("----------------------------------Guess Number Between 1-3----------------------------");
    int num = new Random().Next(3) + 1;
    Console.WriteLine("Input numbers between 1 and 3");
    int guessNumber = int.Parse(Console.ReadLine());

    if (guessNumber < 1 || guessNumber > 3)
        Console.WriteLine("Guess out of range");

    else if (guessNumber < num)
        Console.WriteLine("Guess higher");

    else if (guessNumber > num)
        Console.WriteLine("Guess lower");

    else
        Console.WriteLine("Guess Right");
}


static void printPrymaid(int n)
{
    Console.WriteLine("----------------------------------Print Prymaid----------------------------");
    int i, j;
   
    for (i = 0; i <= n; i++)
    {
        for (j = 1; j <= n - i; j++)
            Console.Write(" ");
        for (j = 1; j <= 2 * i - 1; j++)
            Console.Write("*");
        Console.Write("\n");
    }
}

static void daysAnniversary()
{

    Console.WriteLine("----------------------------------Days Anniversary----------------------------");
    DateTime birthDay = new DateTime(1997, 5, 15);
    DateTime today = DateTime.Now.Date;


    int totalDay = (int)(today - birthDay).TotalDays;
    Console.WriteLine("Days Old is {0}", totalDay);

    int daysToNextAnniversary = 10000 - (totalDay % 10000);
    Console.WriteLine("next 10000 day Anniversary is in {0} days", daysToNextAnniversary);

}

static void greeting()
{
    //DateTime time = DateTime.Now;
    Console.WriteLine("----------------------------------Greeting----------------------------");
    DateTime time = new DateTime(1924,4,2,12,4,5);
    int hour = time.Hour;

    if (hour < 12)
        Console.WriteLine("Good Morning");

    else if (hour < 18)
        Console.WriteLine("Good Afternoon");

    else if (hour < 22)
        Console.WriteLine("Good Evening");

    else
        Console.WriteLine("Good Night");
}

//greeting();

static void Counting()
{
    Console.WriteLine("----------------------------------Counting----------------------------");
    for (int i = 1; i < 5; i++)
    {
        for (int cnt = 0; cnt < 25; cnt += i)
        {
            Console.Write(cnt + ",");
        }
        Console.Write("\n");
    }
}

TypeDemo();
CentriesConversion();
fizzbuzz();
guessNum();
printPrymaid(5);
daysAnniversary();
greeting();
Counting();