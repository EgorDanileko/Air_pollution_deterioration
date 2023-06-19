internal class Program
{
    private static void Main(string[] args)
    {
        //System.Console.WriteLine("Input N: ");
        int N = System.Convert.ToInt32(System.Console.ReadLine());
        int[] arrayM = new int[N];
        int[] arrayE = new int[N];
        int count = 0;

        string str = System.Console.ReadLine();
        arrayM[0] = System.Convert.ToInt32(str.Split(" ")[0]);
        arrayE[0] = System.Convert.ToInt32(str.Split(" ")[1]);

        for (int i = 1; i < N; i++)
        { 
            str = System.Console.ReadLine();
            arrayM[i] = System.Convert.ToInt32(str.Split(" ")[0]);
            arrayE[i] = System.Convert.ToInt32(str.Split(" ")[1]);
            if (arrayM[i] > arrayM[i - 1] && arrayE[i] > arrayE[i - 1])
                count++;
        }

        System.Console.WriteLine(count);

    }
}