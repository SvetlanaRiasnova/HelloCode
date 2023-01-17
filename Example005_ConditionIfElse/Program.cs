Console.WriteLine("Введите ваше имя");
string userName = Console.ReadLine();

if (userName.ToLower() == "мария") 
{
    Console.WriteLine("Ура! Это же Мария!");
}
else 
{
    Console.WriteLine("Привет, ", userName);
}
