Console.Write ("Ввидите имя пользователя: ");
string username = Console.ReadLine ();

if ( username.ToLower() == "оксана" )
{
    Console.WriteLine ("Приветик моя дорогая Оксаночка :*");
}
else
{
    Console.Write ("Привет ");
    Console.WriteLine (username);
}