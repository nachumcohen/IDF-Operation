// See https://aka.ms/new-console-template for more information
using IDF_Operation.General.WeaponFolder;
using IDF_Operation.Genertor.GenerateSoldier;
using IDF_Operation.IDF;

Console.WriteLine(new Times());

F16 a = new F16();



for (int i = 0; i<= 5; i++)
{
    GenerateSoldier.GenerateIsraeliSoldier();
}