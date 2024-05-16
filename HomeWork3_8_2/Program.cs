using HomeWork3_8_2;

Console.OutputEncoding =  System.Text.Encoding.Unicode;


Console.WriteLine("Оберітть колір для повідомленння (1,2,3 або 4)");
Console.WriteLine(" 1 - білий");
Console.WriteLine(" 2 - зелений");
Console.WriteLine(" 3 - червоний");
Console.WriteLine(" 4 - жовтий");

var colorStr = Console.ReadLine();
if (int.TryParse(colorStr, out var colorInt) && colorInt >= 1 && colorInt <= 4) {
    EConsoleColor color = (EConsoleColor)colorInt;
    ConsoleUtility.Print("Тест кольору", color);
} else {
    Console.WriteLine("неочікуване значення");
}