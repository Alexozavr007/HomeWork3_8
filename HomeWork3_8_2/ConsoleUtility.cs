namespace HomeWork3_8_2;

public enum EConsoleColor {
    White = 1,
    Green = 2,
    Red = 3,
    Yellow = 4,
}
public static class ConsoleUtility {
    public static void Print(string stroka, EConsoleColor color) {
        var a = Console.ForegroundColor;
        switch (color) {
            case EConsoleColor.White:
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case EConsoleColor.Green:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case EConsoleColor.Red:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case EConsoleColor.Yellow:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
        Console.Write(stroka);
        Console.ForegroundColor = a;
    }

}
