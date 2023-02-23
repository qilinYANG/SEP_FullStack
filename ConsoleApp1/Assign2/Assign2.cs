// Array Practice
static void copyArray()
{
    int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int[] arr2 = new int[arr1.Length];

    arr1.CopyTo(arr2, 0);
    foreach (var ele in arr2)
        Console.Write(ele + " ");

}


static int[] GetPrimesInRange(int start, int end)
{
    List<int> primes = new List<int>();

    for (int i = start; i <= end; i++)
    {
        bool isPrime = true;

        // Check if i is divisible by any number from 2 to i-1
        for (int j = 2; j < i; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }

        // If i is prime, add it to the list of primes
        if (isPrime && i > 1)
        {
            primes.Add(i);
        }
    }

    return primes.ToArray();
}

//int[] primes  = GetPrimesInRange(10, 100);
//foreach (var prime in primes)
//    Console.Write(prime + " ");

static void rotationSum()
{

    Console.WriteLine("Integer Array Input seperate by Space: ");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    Console.WriteLine("K Rotation: ");
    int k = int.Parse(Console.ReadLine());

    int n = arr.Length;
    int[] sum = new int[n];

    for (int r = 1; r <= k; r++)
    {
        //int[] rotated = new int[n];

        for (int i = 0; i < n; i++)
        {
            int index = (i + 1 + r) % n;
            //rotated[index] = arr[i];
            sum[i] += arr[index];
        }

        //arr = rotated;
    }

    // Print the sum array
    Console.WriteLine("Sum Array: ");
    Console.WriteLine(string.Join(" ", sum));
}

//rotationSum();



static void longestSequenceOfEqualElement() {
    // Read the input array
    Console.WriteLine("Sequence Input Seperated by Space: ");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    int longestStart = 0;   // Starting index of the longest sequence found so far
    int longestLength = 1;  // Length of the longest sequence found so far
    int currentStart = 0;   // Starting index of the current sequence being examined
    int currentLength = 1;  // Length of the current sequence being examined

    // Loop through the array, starting at index 1
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == arr[i - 1])
        {
            // The current element is part of the current sequence
            currentLength++;

            if (currentLength > longestLength)
            {
                // The current sequence is the longest one found so far
                longestStart = currentStart;
                longestLength = currentLength;
            }
        }
        else
        {
            // The current element is not part of the current sequence
            currentStart = i;
            currentLength = 1;
        }
    }

    Console.WriteLine("Longest Equal Element Sequence Output:");
    // Print the longest sequence to the console
    for (int i = longestStart; i < longestStart + longestLength; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}




//longestSequenceOfEqualElement();  
static void mostFrequentElement()
{

    Console.WriteLine("Array Input: ");
    int[] sequence = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    // Create a dictionary to count the frequency of each number
    Dictionary<int, int> frequency = new Dictionary<int, int>();

    foreach (int num in sequence)
    {
        if (frequency.ContainsKey(num))
        {
            frequency[num]++;
        }
        else
        {
            frequency[num] = 1;
        }
    }

    // Find the number with the highest frequency
    int maxFrequency = frequency.Values.Max();
    int mostFrequentNum = frequency.FirstOrDefault(x => x.Value == maxFrequency).Key;

    // Print the result to the console
    Console.WriteLine("The number " + mostFrequentNum + " is the most frequent (occurs " + maxFrequency + " times)");

}

//mostFrequentElement();


// String Practice
static void reversed(String str)
{
    //convert to char[] and back to string again;
    char[] charArr = str.ToCharArray();
    int leng = charArr.Length;
    for (int i = 0; i < (leng - 1) / 2; i++)
    {
        char tmp = charArr[i];
        charArr[i] = charArr[leng - 1 - i];
        charArr[leng - 1 - i] = tmp;

    }
    String reversed = new String(charArr);
    Console.WriteLine(reversed);

    // print in back direction

    for (int i = leng - 1; i > -1; i--)
    {
        Console.Write(str[i]);
    }
}

//reversed("Convert");



static void ReverseSentence(string sentence)
{


    string input = "The quick brown fox jumps over the lazy dog /Yes! Really!!!/.";
    string[] separators = new string[] { ".", ",", ":", ";", "=", "(", ")", "&", "[", "]", "\"", "'", "\\", "/", "!", "?", " " };
    string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    string[] separatorsOnly = input.Split(words, StringSplitOptions.RemoveEmptyEntries);
    Array.Reverse(words);
    string output = "";
    for (int i = 0; i < words.Length; i++)
    {
        output += words[i] + separatorsOnly[i];
    }
    Console.WriteLine(output);
}

static bool IsPalindrome(string word)
{
    return word.SequenceEqual(word.Reverse());
}

string text = "Hi,exe? ABBA Hog fully a string: ExE. Bob";

// Remove all non-letter characters and convert to lowercase
string cleanText = new string(text.Where(char.IsLetter).Select(char.ToLower).ToArray());

// Find all palindromes
var palindromes = cleanText.Split().Where(IsPalindrome).Distinct().OrderBy(p => p);

// Print the palindromes separated by comma and space
Console.WriteLine(string.Join(", ", palindromes));
 

    
//ReverseSentence("The quick brown fox jumps over the lazy dog /Yes! Really!!!/.");


static void httpExtraction()
{
    string input = Console.ReadLine();

    // Split the input URL into protocol, server, and resource parts
    string[] parts = input.Split(new char[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries);

    // Determine the protocol, server, and resource parts based on the number of parts found
    string protocol = "";
    string server = "";
    string resource = "";

    if (parts.Length == 2)
    {
        server = parts[0];
    }
    else if (parts.Length == 3)
    {
        protocol = parts[0];
        server = parts[1];
        resource = parts[2];
    }

    // Print the extracted parts to the console
    Console.WriteLine("[protocol] = \"" + protocol + "\"");
    Console.WriteLine("[server] = \"" + server + "\"");
    Console.WriteLine("[resource] = \"" + resource + "\"");
}

copyArray();
GetPrimesInRange(0, 100);
rotationSum();
longestSequenceOfEqualElement();
mostFrequentElement();
reversed("24tvcoi92");
ReverseSentence("The quick brown fox jumps over the lazy dog /Yes! Really!!!/.");
httpExtraction();
