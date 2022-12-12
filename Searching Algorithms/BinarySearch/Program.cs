namespace BinarySearch
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            int[] data = { 2, 4, 5, 6, 8, 9, 11, 11, 11, 11, 11, 11, 32, 53, 201, 987 };
            int n = data.Length;

            int s = 0;
            int e = n - 1;
            int m = (s + e) / 2;
            int cnt = 0;

            print_data(data);
            Console.Write("Please type the number you are looking for: ");
            string num = Console.ReadLine();
            int number = Convert.ToInt32(num);

            if ((number < data[0]) || (number > data[n - 1]))
            {
                Console.WriteLine(number + " was not found!! : " + cnt + " iterations");
            }
            do
            {
                cnt++;
                if (data[m] == number)
                {
                    Console.WriteLine(number + " was found at position " + m + ": " + cnt + " iterations");
                    break;
                }
                else if (data[m] < number)
                    s = m + 1;
                else
                    e = m - 1;
                m = (s + e) / 2;
            } while (e >= s);

            if (e < s)
                Console.WriteLine(number + " was not found!! : " + cnt + " iterations");

        }

        public static void print_data(int[] data)
        {
            int n = data.Length;
            for (int i = 0; i < n; i++)
                Console.Write(data[i] + " ");
            Console.WriteLine();
        }
    }
    
}


