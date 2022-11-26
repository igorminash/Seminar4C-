Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {A} = {GetSum(A)} ");


int GetSum (int number){
    int Sum = 0;
    while (number%10 !=0){
        Sum = number%10 + Sum;
        number/=10;
    }
    return Sum;
}    
