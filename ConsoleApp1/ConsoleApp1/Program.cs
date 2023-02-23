// See https://aka.ms/new-console-template for more information

static void TypeDemo()
{
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
int x = 5;
int y = 1;
Console.WriteLine(y++);
Console.WriteLine(y);
y = 1;
Console.Write(++y);