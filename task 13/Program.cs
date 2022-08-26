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
    return number[2];
}
// if(number[0] == -)                  здесь хотела, чтобы программа выдавала третьий символ, если число отрицательное
// {                                      т.е. под индексом 0 у него стоит минус. но ничего не вышло :(
//     return number[3];
// }

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
