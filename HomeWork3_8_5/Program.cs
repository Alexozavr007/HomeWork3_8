Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Введіть дату народження");
DateTime birthday = Convert.ToDateTime(Console.ReadLine());
var today = DateTime.Now;

int tm = today.Month;
int td = today.Day;
int bm = birthday.Month;
int bd = birthday.Day;

var diffMonths = bm - tm;
var diffDays = bd - td;
if (diffMonths < 0) {
   diffMonths =  diffMonths * -1;
}
if (diffDays < 0) {
    diffDays = diffDays * -1;
}

Console.WriteLine($"До вашого дня народження залишилося  {diffMonths} місяця(ів) та {diffDays}дня(ів)");