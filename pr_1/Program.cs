// Определяем Палиндром 
//-------------------Блок Последовательности-----------------------
int number_1 = 0;
EnterNumber(ref number_1);
CheckParameters(number_1);

//--------------------Блок Выполнения-------------------------------

//-1.Проверка числана корректонсть----------------------------------
static void EnterNumber (ref int number_1) 
{   Console.Write("Введите число: ");
    while(true) 
    {
        if (int.TryParse(Console.ReadLine(),out number_1)) 
        {
            if (number_1 >= 10000 && number_1<=99999)
            break;
            Console.Write($"Число {number_1} - не пятизначное. ");
        }
        Console.WriteLine("Ошибка ввода!");
    }
    Console.WriteLine("");
    Console.WriteLine($"Вы ввели число {number_1}");
}

//-2.Проверка числа на условие---------------------------------------
static void CheckParameters (int number_1) 
{   
    if (number_1/10000 == number_1%10 && (number_1/1000)%10 == (number_1%100)/10)
    {
        Console.WriteLine($"Число {number_1} -> Палиндром");
    }
    else 
    {
        Console.WriteLine($"Число {number_1} -> Не палиндром");
    }
}