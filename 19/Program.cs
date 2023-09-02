int Counter_Numbers(int user_number)
{

    if (user_number != 0)
    {
        int count = 0;
        while (user_number != 0)
        {
            user_number = user_number / 10;
            count++;
        }
        return count;
    }
    else
    {
        System.Console.WriteLine("Вы ввели 0 длинна 0 = 1 символ");
    }
    return user_number;

}



int palindrome_1(int Counter_Numbers_1)
{
    int Length_user_number = Counter_Numbers_1;
    int count = 10;
    int result = 1;
    if (Counter_Numbers_1 > 1)
    {
        for (int i = 1; i < Length_user_number; i++)
        {
            result = result + count;
            count = count * 10;
            //System.Console.WriteLine("цикл");
            //System.Console.WriteLine(result);
        }
        //System.Console.WriteLine(result);

    }
    else
    {
        System.Console.WriteLine("Жаль");
    }
    return result;
}


int palindrome_2(int A, int B)
{
    if (A % B == 0)
    {
        System.Console.WriteLine("Число палиндромом");
    }
    else
    {
        System.Console.WriteLine("Число не палиндромом");
    }
    // Заглушка которую почему то он требует
    return A ;
}
// Переделай это под bool что бы он возращал логический ответ



int num3 = 878;
int num = Counter_Numbers(878);
int num_2 = palindrome_1(num);
System.Console.WriteLine(palindrome_2(num3 , num_2));