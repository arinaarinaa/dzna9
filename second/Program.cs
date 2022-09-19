// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int m = 5;
int n = 9;
void Result (int m, int n)
{
    int result = 0;
    if(m<n)
    {
        for(int i = m; i<=n; i++)
        {
            result = result+i;
            
        }
        Console.WriteLine(result);
    }
        return;
}
Result(m,n);