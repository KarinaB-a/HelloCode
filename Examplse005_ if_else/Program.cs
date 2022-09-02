Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "радость наша")
{
    Console.WriteLine("Ура, это же Радость наша! "); 
}
else
{
    Console.Write("Привет! ");
    Console.WriteLine(username);
}