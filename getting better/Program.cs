// creating a quiz app again init.

using static System.Formats.Asn1.AsnWriter;
using System.Drawing;

string question1 = "what is your name?";
string answer1 = "bibhot";
string question2 = "What is your favourite color?";
string answer2 = "blue";
string question3 = "what is your favourite drink?";
string answer3 = "coffee";
int score = 0;

Console.WriteLine(question1);
string userAnswer = Console.ReadLine();
if (userAnswer == answer1)
{
    Console.WriteLine("good job you scored 1 point");
    score = score + 1;
}
else
{
    Console.WriteLine("wrong answer");
}
Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2 == answer2)
{
    Console.WriteLine("good job you scored 1 point");
    score = score + 1;
}
else
{
    Console.WriteLine("wrong answer");
}
Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if(userAnswer3 == answer3)
{
    Console.WriteLine("good job you scored 1 point");
    score = score + 1;
}
else
{
    Console.WriteLine("wrong answer");
}
Console.WriteLine("your score is " + score);