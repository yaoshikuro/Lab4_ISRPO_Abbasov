
using System.Linq.Expressions;

string hello = "Hello, World!";
string fio = "Аббасов Салман Сананович";
string gruppa = "ИСП-233";
string data = "25.02.2026";

int q = Convert.ToInt32(Console.ReadLine());
if (q == 1)
{
    Console.WriteLine(hello);
}
if (q == 2)
{
    Console.WriteLine(fio);
}
if (q == 3)
{
    Console.WriteLine(gruppa);
}
if (q == 4)
{
    Console.WriteLine(data);
}