string[] types =
   { "sbyte"
    ,"byte"
    ,"short"
    ,"ushort"
    ,"int"
    ,"uint"
    ,"long"
      }; // ulong усложняет жизнь (вводимая переменная парсится в long, а если мы введем
         // с консоли long.maxValue + 1, то ломается код. Вероятность, что пользователь введет отрица знач больше, чем он введет long.MaxValue+1)

long[] maxValues =
{
     sbyte.MaxValue
    ,byte.MaxValue
    ,short.MaxValue
    ,ushort.MaxValue
    ,int.MaxValue
    ,uint.MaxValue
    ,long.MaxValue
};

long[] minValues =
{
     sbyte.MinValue
    ,byte.MinValue
    ,short.MinValue
    ,ushort.MinValue
    ,int.MinValue
    ,uint.MinValue
    ,long.MinValue
};


Console.WriteLine("Введите число");

string readLineResult = Console.ReadLine();
Console.WriteLine($"Пользователь ввел: {readLineResult}");

long myVar;
bool success = long.TryParse(readLineResult, out myVar);
if (!success)
{
    Console.WriteLine("введено не число или это число не вхтодит во множество long\n");
    return;
}


for (int i = 0; i < types.Length; i++)
{
    if (myVar <= maxValues[i] && myVar >= minValues[i])
    {
        Console.WriteLine($"{types[i]} преобразуется без потери значения");
    }
}