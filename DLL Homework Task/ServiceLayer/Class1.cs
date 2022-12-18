namespace ServiceLayer
{
    public class CustomMath1
    {
        public void Factorial(int n)
        {
            int result = 1;


            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }

    }
}




public class CustomMath
{
    public void Count(int[] arr)
    {
        int count = 0;
        for (int i = 0; i <= arr.Length; i++)
        {
            if (i % 2 == 1)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}



