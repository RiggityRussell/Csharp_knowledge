public static List<int> arr = new List<int>();
static void Main()
{

    var numArray = new int[10];
    FillArray(numArray);
    Statistics(arr.ToArray(), arr.Count, out int high, out int low, out int sum, out double avg);
    WriteLine($"The array has {arr.Count()} values");
    WriteLine($"The highest value is {high}");
    WriteLine($"The lowest value is {low}");
    WriteLine($"The sum of the values is {sum}");
    WriteLine($"The average is {avg}");
}

public static int FillArray(int[] array)
{
    int i = 0;
    while (i != 999 && arr.Count < 10)
    {
        try
        {
            i = int.Parse(ReadLine());
            if (i != 999)
            {
                arr.Add(i);
            }
        }
        catch { }
    }
    for (int f = 0; f < arr.Count; f++)
    {
        array[f] = arr[f];
    }
    return arr.Count;
}
public static void Statistics(int[] array, int els, out int high, out int low, out int sum, out double avg)
{
    var a = array.Take(els);
    high = a.Max();
    low = a.Min();
    sum = a.Sum();
    avg = a.Average();
}