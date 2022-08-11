//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


//С исскуственным заполнением

// int[] mas = new int[] {/* элементы массива */};
// int sumEven = mas.Where(num => num % 2 == 0).Sum(); // сумма чётных
// int sumOdd = mas.Where(num => num % 2 != 0).Sum(); // сумма нечётных

//С рандомным заполнением понял так
int[] mas = new int[5];
for (int i = 0; i < mas.Length; i++)
{
          mas[i] = new Random().Next (1, 21);
          Console.Write(mas[i] + " ");
}
int sumEven = mas.Where(mas => mas % 2 != 0).Sum(); // сумма нечётных
Console.Write(sumEven);