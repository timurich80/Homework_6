/* 
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 
*/

double[] inputNums()
{
    Console.WriteLine("Введите значения через пробел: \n");

    string [] stringNums = Console.ReadLine ().Split(' ');
    double[] nums = new double[stringNums.Length];
    for(int i=0; i<stringNums.Length; i++)
    {
        nums[i]  = Convert.ToDouble(stringNums[i]);
    }
    return nums;
}

void printFn(double[ ] nums)

{
    double b1 = nums[0];
    double k1 = nums[1];
    double b2 = nums[2];
    double k2 = nums[3];

    double x = (b2 - b1) /(k1 - k2);
    double y = k1*x + b1;
    System.Console.WriteLine($"Точка пересечения ({x}, {y})");
}

printFn(inputNums());
