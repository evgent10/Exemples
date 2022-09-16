Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "юля")
{
    Console.WriteLine("Ура, это же ЮЛЯЛЯ!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}