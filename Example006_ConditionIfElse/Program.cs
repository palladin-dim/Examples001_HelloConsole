// if(Условие)
// {
//   Набор действий 1  
// }
// else(Иначе)
// {
//   Набор действий 2  
// }
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

// if(username = "Маша")

if(username.ToLower == "Маша")
{
    Console.WriteLine("Урра, это же Маша!");
}
else
{
    Console.Write("Приввет, ");
    Console.WriteLine(username);
}
// Решение проблемы с регистром
// После комады username в двенадатой строке нужно ввести ToLower 


