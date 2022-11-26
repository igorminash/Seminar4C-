Console.WriteLine("Введите число А: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {number1} в степени числа {number2} = {GetDegree(number2)} ");
GetDegree(number2);


int GetDegree (int num2 ){
    int Num = 1;
    for ( int i = 1; i <= num2; i++){
        Num = number1 * Num;
    }
return Num;

}

