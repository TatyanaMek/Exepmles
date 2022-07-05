Console.Write("Ведите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Привет! Это же Маша!");
}    
 else
 {
    Console.Write("Привет, ");
    Console.WriteLine(username);
 }
