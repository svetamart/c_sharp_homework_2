Console.WriteLine("Введите трехзначное число");

int n = Convert.ToInt32(Console.ReadLine());

int FindSecondDigit(int number)
{
    int firstTwoDigits = n / 10; 
    int secondDigit = firstTwoDigits % 10;
    return secondDigit;
}

int result = FindSecondDigit(n);

Console.WriteLine(result);
 
