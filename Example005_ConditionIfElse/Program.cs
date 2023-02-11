// 5_2 IfElse 
Console.WriteLine("Ваше имя?");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("ВАЙ МЭ, это же Маша!");
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}