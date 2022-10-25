//Задача № 21
//А(3,6,8); В(2,1,-7) ->  15.84
//А(7,-5,0); В(1,-1,9) ->  11.53
//-------------------Блок Последовательности-----------------------

int x_1 = EnterNumber("Число X1: ");
int y_1 = EnterNumber("Число Y1: ");
int z_1 = EnterNumber("Число Z1: ");

int x_2 = EnterNumber("Число X2: ");
int y_2 = EnterNumber("Число Y2: ");
int z_2 = EnterNumber("Число Z2: ");

double final_result = Check_Result(x_1, y_1, z_1, x_2, y_2, z_2);

Console.WriteLine($"A({x_1},{y_1},{z_1}) - B({x_2},{y_2},{z_2}) -> {final_result}");

//--------------------Блок Выполнения-------------------------------
static int EnterNumber (string message) 
{
    Console.Write(message);
    int number_1 = int.Parse(Console.ReadLine() ?? "");
    return number_1;
}

static double Check_Result (int x_1, int y_1, int z_1, int x_2, int y_2, int z_2) 
{
    double result = Math.Sqrt(Math.Pow(x_2 - x_1, 2)+Math.Pow(y_2 - y_1, 2)+Math.Pow(z_2 - z_1, 2));
    return result;
}
