void sum_of_numbers(int user_number )
{
int initial_number = user_number;
int result = 0;
int [] aaray = new int [100];
for (int i = 0; i <= user_number; i++)
{
    aaray[i] = user_number % 10; 
    user_number = user_number / 10;
    //System.Console.WriteLine($"Это сахранненый индекс {aaray[i]}");
    result = result + aaray[i];
    //System.Console.WriteLine($"Это результат сложения остатка от деления {result}");
    //System.Console.WriteLine($"Это результат сложения остатка от деления {result}");
}
    System.Console.WriteLine($"Сумма и произведение цифр числа  {initial_number } = {result}");
}

sum_of_numbers(9012);