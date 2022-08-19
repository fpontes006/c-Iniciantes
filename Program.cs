using System;


Console.Write("Digite seu Nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Olá {name}!");
Console.Write("Digite sue ano de Nascimento: ");
int year = int.Parse(Console.ReadLine());
int age = 2022 - year;
Console.WriteLine($"Voce tem {age} anos!");

if (age >= 18) 
{
    Console.WriteLine("Voce é maior de Idade.");
}
else
{
    Console.WriteLine("Voce é menor de Idade.");
}


string[] names = {"Felipe","mariana"};

/*for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine(names[i]);
}
*/
foreach (string teste in names) {
    Console.WriteLine(teste);
}



