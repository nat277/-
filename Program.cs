// Описание алгоритма решения:

// Сoздаем и объявляем два массива общей длины.
// Далее создается метод,где цикл соответствует длине массива.
// Далее проверка цикла по заданному условию, т.е. <=3, если 
// условие выполняется,то элемент первого массива заносится во 
// второй массив. После присвоения второго массива, увеличиваем 
// переменную N на 1 и возвращаемся к циклу в котором i элементов 
// увеличивается на 1. И так проходим по циклу, пока удовлетворяется условие.
// Когда условия перестали удовлетворятся, делаем вывод на экран результата.


string[] array1 = new string[3] {"hello", "2", ":-)"};
string[] array2 = new string[array1.Length];

void SecondArrayWith(string[] array1, string[] array2)
{
    int N = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[N] = array1[i];
        N++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWith(array1, array2);
PrintArray(array2);
