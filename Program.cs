// int age = 15;
// if (age >= 18) {
//     System.Console.WriteLine("Доступ разрешён");
// }
// System.Console.WriteLine("Программа продолжает работу");
// int age = 15;
// if (age >= 18)
// {
//     System.Console.WriteLine("Доступ разрешён");
// } else
// {
//     System.Console.WriteLine("Доступ запрещён");
//     System.Console.WriteLine($"До совершеннолетия {18 - age} года");
// }
// int age = 14;
// if (age < 13)
// {
//     System.Console.WriteLine("Ребёнок");
// } else if (age < 18)
// {
//     System.Console.WriteLine("Подросток");
// } else if (age >= 18 && age <= 59)
// {
//     System.Console.WriteLine("Взрослый");
// }
// else
// {
//     System.Console.WriteLine("Пенсионер");
// }
int age = 16;
double height = 1.4;
bool hasParents = true;
if (age >= 14 && height >= 1.5)
{
    System.Console.WriteLine("Можно кататься");
} else if (height < 1.5 && hasParents)
{
   System.Console.WriteLine("Можно кататься");
} else
{
    System.Console.WriteLine("Пока нельзя");
}

