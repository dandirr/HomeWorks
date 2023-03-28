
using System.Runtime.Serialization.Formatters;
Console.WriteLine("Введите число");

string readLineResult = Console.ReadLine();
Console.WriteLine($"Пользователь ввел: {readLineResult}");
//long myVar = long.Parse(readLineResult);
bool success = long.TryParse(readLineResult, out long myVar);
if (!success)
{
    Console.WriteLine("введено не число\n");
    return;
}


Console.WriteLine("Нажмите соответствую цифру, если вы хотите проверить на возможность явного приведение:\n 1 - sbyte,\n 2 - short,\n 3 - int,\n 4 - long,\n 5 - byte,\n 6 - ushort,\n 7 - uint,\n 8 - ulong\n");
string type = Console.ReadLine();

//long myType = long.Parse(type);

success = ulong.TryParse(type, out ulong myType);
if (!success)
{
    Console.WriteLine("введено не число\n");
    return;
}else if(myType > 8)
{
    Console.WriteLine("неизвестный вариант\n");
    return;
}


if (myType == 1)
{
    Console.WriteLine("Проверка sbyte");
    if (sbyte.MinValue < myVar && myVar < sbyte.MaxValue)
    {
        sbyte result = (sbyte)myVar;
        Console.WriteLine($"Переменная {myVar} приводится без потери значения к переменной типа sbyte {result}");
    }
    else
    {
        Console.WriteLine($"Для приведения числа {myVar} к типу sbyte число не может быть больше {sbyte.MaxValue} и меньше {sbyte.MinValue}. Приведение без потери значения невозможно");
    }
}
else if (myType == 2)
{
    Console.WriteLine("Тип проверяемых данных short");
    if (short.MinValue <= myVar && myVar < short.MaxValue)
    {
        short result = (short)myVar;
        Console.WriteLine($"Переменная {myVar} приводится без потери значения к переменной типа short {result}");
    }
    else
    {
        Console.WriteLine($"Для приведения числа {myVar} к типу short число не может быть больше {short.MaxValue} и меньше {short.MinValue}. Приведение без потери значения невозможно");
    }

}
else if (myType == 3)
{
    Console.WriteLine("Тип проверяемых данных int");
    if (int.MinValue < myVar && myVar < int.MaxValue)
    {
        int result = (int)myVar;
        Console.WriteLine($"Переменная {myVar} приводится без потери значения к переменной типа int {result}");
    }
    else
    {
        Console.WriteLine($"Для приведения числа {myVar} к типу int число не может быть больше {int.MaxValue} и меньше {int.MinValue}. Приведение без потери значения невозможно");
    }

}
else if (myType == 4)
{
    Console.WriteLine("Тип проверяемых данных long");
    if (long.MinValue < myVar && myVar < long.MaxValue)
    {
        long result = (long)myVar;
        Console.WriteLine($"Переменная {myVar} приводится без потери значения к переменной типа long {result}");
    }
    else
    {
        Console.WriteLine($"Для приведения числа {myVar} к типу long число не может быть больше {long.MaxValue} и меньше {long.MinValue}. Приведение без потери значения невозможно");
    }
}
else if (myType == 5)
{
    Console.WriteLine("Тип проверяемых данных byte");
    if (byte.MinValue < myVar && myVar < byte.MaxValue)
    {
        byte result = (byte)myVar;
        Console.WriteLine($"Переменная {myVar} приводится без потери значения к переменной типа byte {result}");
    }
    else
    {
        Console.WriteLine($"Для приведения числа {myVar} к типу byte число не может быть больше {byte.MaxValue} и меньше {byte.MinValue}. Приведение без потери значения невозможно");
    }
}
else if (myType == 6)
{
    Console.WriteLine("Тип проверяемых данных ushort");
    if (ushort.MinValue < myVar && myVar < ushort.MaxValue)
    {
        ushort result = (ushort)myVar;
        Console.WriteLine($"Переменная {myVar} приводится без потери значения к переменной типа ushort {result}");
    }
    else
    {
        Console.WriteLine($"Для приведения числа {myVar} к типу ushort число не может быть больше {ushort.MaxValue} и меньше {ushort.MinValue}. Приведение без потери значения невозможно");
    }
}
else if (myType == 7)
{
    Console.WriteLine("Тип проверяемых данных uint");

    if (uint.MinValue < myVar && myVar < uint.MaxValue)
    {
        uint result = (uint)myVar;
        Console.WriteLine($"Переменная {myVar} приводится без потери значения к переменной типа uint {result}");
    }
    else
    {
        Console.WriteLine($"Для приведения числа {myVar} к типу uint число не может быть больше {uint.MaxValue} и меньше {uint.MinValue}. Приведение без потери значения невозможно");
    }
}
else if (myType == 8)
{
    Console.WriteLine("Тип проверяемых данных ulong");
    ulong myVar2;
    bool suc = ulong.TryParse(readLineResult, out myVar2);
    if (success == true)
    {
        ulong result = (ulong)myVar2;
        Console.WriteLine($"Переменная {myVar2} приводится без потери значения к переменной типа ulong {result}");
    }
    else
    {
        Console.WriteLine($"Для приведения числа {myVar2} к типу ulong число не может быть больше {ulong.MaxValue} и меньше {ulong.MinValue}. Приведение без потери значения невозможно");
    }



}





/*string readLineResult1 = Console.ReadLine();
Console.WriteLine($"Пользователь ввел: {readLineResult1}");
long myVar1 = long.Parse(readLineResult1);
var min = sbyte.MinValue;
var max = sbyte.MaxValue;

if (min < myVar1 && myVar1 < max)
{

    var result = (sbyte)myVar1;

    Console.WriteLine($"Явное приведение переменной: {result}");
}
else
{
    Console.WriteLine($"Для приведения числа {myVar1} к типу {max.GetType()} число не может быть больше {max} и меньше {min}");

}*/
