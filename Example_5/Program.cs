Console. WriteLine("Enter your name please: ");
string username = Console.ReadLine();
if(username.ToLower() == "mary")
{
    Console.WriteLine("Hi, my dear mary!");
}
else 
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}