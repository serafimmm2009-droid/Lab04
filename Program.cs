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
// int age = 16;
// double height = 1.4;
// bool hasParents = true;
// if (age >= 14 && height >= 1.5)
// {
//     System.Console.WriteLine("Можно кататься");
// } else if (height < 1.5 && hasParents)
// {
//    System.Console.WriteLine("Можно кататься");
// } else
// {
//     System.Console.WriteLine("Пока нельзя");
// }

// Вариант 3
// System.Console.WriteLine("Введите номер месяца");
// int numberMonths = int.Parse(Console.ReadLine());
// string nameSeason = "";
// switch(numberMonths)
// {
//     case 12 or 1 or 2:
//         nameSeason = "Зима";
//         break;
//     case 3 or 4 or 5:
//         nameSeason = "Весна";
//         break;
//     case 6 or 7 or 8:
//         nameSeason = "Лето";
//         break;
//     case 9 or 10 or 11:
//         nameSeason = "Осень";
//         break;
//     default:
//         nameSeason = "Неверный месяц";
//         break;
// }
// System.Console.WriteLine($"Время года: {nameSeason}");

// Вариант 6
System.Console.WriteLine("Введите кол-во баллов за экзамен");
int scoreExam = int.Parse(Console.ReadLine());
if (scoreExam < 0 || scoreExam > 100) {
    System.Console.WriteLine("Неверное значение");
} else if (scoreExam >= 90 && scoreExam <= 100){
    System.Console.WriteLine("Отлично");
} else if (scoreExam <= 89 && scoreExam >= 75)
{
    System.Console.WriteLine("Хорошо");
} else if (scoreExam <= 74 && scoreExam >= 60)
{
    System.Console.WriteLine("Удовлетворительно");
} else if (scoreExam < 60)
{
    System.Console.WriteLine("Неудовлетворительно");
}
