// Console.WriteLine("Введите пароль");
// string password = Console.ReadLine();
// Console.WriteLine("Повторите пароль");
// string password1 = Console.ReadLine();
// string proverka = (password == password1) ? "Пароль верный" : "Пароль не верный";
// Console.WriteLine(proverka);


// Console.WriteLine("Введите ваш возраст");
// int AGE = int.Parse(Console.ReadLine());
// string proverka = (AGE >= 18) ? "Доступ разрешён" : "Доступ запрещён";
// Console.WriteLine(proverka);


// Console.WriteLine("Введите 2 цифры и операцию");
// int num = int.Parse(Console.ReadLine());
// int num1 = int.Parse(Console.ReadLine());
// string symb = Console.ReadLine();
// switch(symb){
//     case "+":
//     Console.WriteLine(num+num1);
//         break;
//     case "-":
//     Console.WriteLine(num-num1);
//         break;
//     case "*":
//     Console.WriteLine(num*num1);
//         break;
//     case "/":
//     Console.WriteLine(num/num1);
//         break;
//     default:
//         Console.WriteLine("Нет такой операции");
//         break;
// }


// int sum = 0;
// Console.WriteLine("Напишите 3 числа");
// int num1 = int.Parse(Console.ReadLine());
// int num2 = int.Parse(Console.ReadLine());
// int num3 = int.Parse(Console.ReadLine());
// if (num1 > 0){
//     sum += num1;
// }
// if (num2 > 0){
//     sum += num2;
// }
// if (num3 > 0){
//     sum += num3;
// }
// Console.WriteLine(sum);


// Console.WriteLine("Выберите путь: A / B");
// string choice = Console.ReadLine();
// switch (choice)
// {
//     case "A":
//     Console.WriteLine("загадка");
//     Console.WriteLine("Кто не дышит, но живёт; хоть не нужно — много пьёт; и вжизни, и в смерти тело как лёд");
//     string choice1 = Console.ReadLine();
//     switch (choice1)
//     {
//         case "рыба":
//         Console.WriteLine("Вы проходите дальше");
//         break;
//         default:
//         Console.WriteLine("Вас съели");
//         break;
//     }
//     break;
//     case "B":
//     Console.WriteLine("Выберите дверь: 1 / 2");
//     string choice2 = Console.ReadLine();
//     switch (choice2)
//     {
//         case "1":
//         Console.WriteLine("Вы нашли скрытые сокровища!");
//         break;
//         case "2":
//         Console.WriteLine("Вы попали в ловушку!");
//         break;
//         default:
//         Console.WriteLine("такой двери нет");
//         break;
//     }
//     break;
//     default:
//     Console.WriteLine("нет такого пути");
//     break;
// }