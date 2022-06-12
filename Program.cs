// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры: 
// "hello", "2", "world", ":)"  => ["2", ":)"]
// "1234", "1567", "-2", "computer science" => ["-2"]
// "Russia", "Denmark", "Kazan" => []
Console.WriteLine($"Программа, которая из имеющегося массива строк формирует массив из строк, длина которой меньше либо равно 3 символа");
Console.WriteLine("Входные данные:  ");
string[] array = new string[] { "1234", "1567", "-2", "computer science" };
//string[] array = new string[] { "hello", "2", "world", ":)" };
// string[] array = new string[] { "Russia", "Denmark", "Kazan" };
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FormArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string array1 = array[i];
        if (array1.Length <= 3)
        {
            array[i] = array1;
    }
        else array[i] = string.Empty;
    }
}

PrintArray(array);
Console.WriteLine($"Полученный результат: ");
FormArray(array);
PrintArray(array);
Console.WriteLine($"Спасибо за внимание!");
