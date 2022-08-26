bool CheckDay(int day)
{
    if(day == 6 || day == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели");

int number = Convert.ToInt32(Console.ReadLine());

bool result = CheckDay(number);

if(result == true)
{
    Console.WriteLine("ура, выходной");
}
else
{
    Console.WriteLine("нет, не выходной :(");
}

