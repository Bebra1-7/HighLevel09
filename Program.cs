// int[] scores = [5, 4, 3, 5, 4];


// Console.WriteLine($"First element: {scores[0]}");
// Console.WriteLine($"Last element: {scores[scores.Length - 1]}");
// scores[1] = 2;
// Console.WriteLine($"All array: {string.Join(", ", scores)}");

// Здесь мы имеем доступ к индексам элементов, благодаря которым можем менять элементы
// for (int i = 0; i < scores.Length; i++)
// {
//     Console.WriteLine($"Index {i}: {scores[i]}");
// }
// foreach(int num in scores)
// {
//     Console.WriteLine(num);
// }

// int[] numbers = [10, 20, 30];

// // 1. Цикл успел вывести все данные массива
// // 2. i = 3 and Length = 3;
// // 3. Потому что индекс вышел за предел массива
// // 4. Вместо <= надо поставить <
// for (int i = 0; i <= numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }

// void ChangeFirst(int[] array)
// {
//     array[0] = 100;
// }

// int[] data = [1, 2, 3];
// Console.WriteLine(string.Join(", ", data));
// ChangeFirst(data);
// Console.WriteLine(string.Join(", ", data));

// int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
// Console.WriteLine($"Before: {string.Join(", ", array)}");
// ArrayMultiplyin2(array);
// Console.WriteLine($"After: {string.Join(", ", array)}");
// // Не используется ref так, как из теории было сказано, что массивы в вызове метода явл. ссылочным типом, поэтому изменения видны снаружи
// void ArrayMultiplyin2(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * 2;
//     }
// }

// int[] data = [-5, -2, -9];
// //[7, -3, 12, 0, 5, 9, -8];
// int total = 0;
// int max = data[0]; // Не пишем "0" так, как отриц. значения будут меньше всегда
// int min = data[0];
// for (int i = 0; i < data.Length; i++)
// {
//     total += data[i];
//     if (data[i] > max) max = data[i];
//     if (data[i] < min) min = data[i];
// }
// double averageValue = (double)total / data.Length;
// Console.WriteLine($"Сумма: {total} \nAverage value: {Math.Round(averageValue, 2)} \nMAX: {max} \n MIN: {min}");

class Program
{
    static void Main()
    {
        int size;
        bool input;
        do
        {
            Console.Write("Сколько результатов? ");
            string num = Console.ReadLine();
            input = int.TryParse(num, out size);
        } while (!input);
        int[] array = new int[size];
        Console.WriteLine();
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Результат {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"\n {OutputResults(array, size)}");
    }
    static string OutputResults(int[] array, int size) {
        int max = array[0];
        int min = array[0];

        double averageValue = 0;

        int countBig17 = 0;
        Console.WriteLine("Results:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"{i + 1}: {array[i]}");
            averageValue += array[i];

            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
            if (array[i] >= 17) countBig17++;
        }
        averageValue /= size;

        return $"Average value: {Math.Round(averageValue, 2)} \nЛучший результат: {max} \n Худший результат: {min} \nРезультатов не ниже 17: {countBig17}";
    }
}