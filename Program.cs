//task 15

Console.WriteLine("Введите день недели в числовом выражении");
int WeekDay = Convert.ToInt32(Console.ReadLine());

if (WeekDay % 6 == 0 || WeekDay % 7 == 0){
    Console.WriteLine($"Этот день недели - выходной");
}
else if(WeekDay < 1 || WeekDay > 7){
    Console.WriteLine("Даже так? Вы планируете изменить полностью систему летоисчисления?");
}
else {
    Console.WriteLine("Этот день не является выходным");
}
