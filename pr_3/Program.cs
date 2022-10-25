//Задача № 23
//Куб каждого числа до N -> 3,5

//-------------------Блок Последовательности-----------------------
int number_1 = 0;
EnterNumber(ref number_1);
string final_result= Calculation(number_1);
Console.WriteLine($"{number_1} -> {final_result}");


//-1.Проверка числана корректонсть----------------------------------
static void EnterNumber (ref int number_1) 
{   Console.Write("Введите число: ");
    while(true) 
    {
        if (int.TryParse(Console.ReadLine(),out number_1)) 
        break;
        Console.WriteLine("Ошибка ввода!");
    }
    Console.WriteLine("");
}

static string Calculation (int number_1) 
{   
    string result = "";
    for (int i = 1; i < number_1; i++) 
        {
        result =  $"{result}{Math.Pow(i, 3)}, " ;
        }
    result = $"{result}{Math.Pow(number_1, 3)}, " ;
    
    return result;
}