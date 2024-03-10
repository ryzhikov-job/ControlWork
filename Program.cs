internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.Write("Введите кол-во элементов массива: ");
        int num = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[num];

        Console.WriteLine($"Исходный массив: {string.Join(",\t ", CreateArray())}");
        Console.WriteLine($"Конечный массив: {string.Join(",\t", NewArray(array))}");

        string[] CreateArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент массива {i}:\t");
                array[i] = Console.ReadLine();
            }
            return array;
        }

        int CheckArray(string[] array)
        {
            int countArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    countArray++;
                }
            }
            return countArray;
        }

        string[] NewArray(string[] array)
        {
            string[] newArray = new string[CheckArray(array)];
            int size = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    newArray[size] = array[i];
                    size++;
                }
            }
            return newArray;
        }
    }
}


