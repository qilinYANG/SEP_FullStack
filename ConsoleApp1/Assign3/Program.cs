// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int[] GenerateNumbers(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = i;
    }
    return arr;


}
static void reversed(ref int[] numbers)
{
    int length = numbers.Length;

    for(int i = 0,j = length-1; i < j;i++,j--)
    {
        int temp = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = temp;
    }
}
static void print(int[] numbers)
{
    foreach(var number in numbers)
    {
        Console.Write(number + " ");
        
    }
    Console.Write("\n");
}


static void Fibonacci(int n)
{
    int a = 0, b = 1, c = 1;

    for(int i = 1; i <= n; i++)
    {
        Console.Write(c + " ");
        c = a + b;
        a = b;
        b = c;
    }
}
int[] numbers = GenerateNumbers(10);
reversed(ref numbers);
print(numbers);
Fibonacci(10);
