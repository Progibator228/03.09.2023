void Exponentiation (int num_1 , int num_2 )
{
int result = num_1;
for (int i = 1; i < num_2; i++)  
    {
        //System.Console.WriteLine($"Цикл {i}");
        result = result * num_1 ;
    }
    System.Console.WriteLine($"{num_1} в натуральной степени {num_2} = {result}");
}


int A = 2;
int B = 4;
Exponentiation(A,B);