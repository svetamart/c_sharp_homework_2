Console.WriteLine("Введите число, чтобы узнать третью цифру");

string input = Console.ReadLine();

bool ValidateInput(string input)
{

    if(input.Length < 2)
    {
        return false;
    }
    else
    {
        return true;
    }

}

char FindThirdDigit(string number)
{
    if(number.Contains("-"))
    {
        return number[3];
    }
    return number[2];
}

bool isValid = ValidateInput(input);


if(isValid == false)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    char result = FindThirdDigit(input);
    Console.WriteLine(result);
}
