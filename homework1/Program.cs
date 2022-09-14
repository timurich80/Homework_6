/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 
*/


int[] DataEntry()
{
    System.Console.WriteLine("Введите с клавиатуры положительные и отрицательные числа через пробел:  ");
    string temp = Console.ReadLine();
    string[] s = temp.Split(' ');
    int[] nums = new int[s.Length];

    for (var i = 0; i<s.Length; i++)
    {
        nums[i] = Convert.ToInt32(s[i]);

    }
    return nums;    
}

void PrintCountPositiveNums(int[] nums)
{
    Console.WriteLine(nums.Where(i => i > 0 == true).Sum());
    Console.WriteLine(nums);
}

PrintCountPositiveNums(DataEntry());

