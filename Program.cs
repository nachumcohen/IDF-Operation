// See https://aka.ms/new-console-template for more information
using IDF_Operation.Enemy;
using IDF_Operation.General.WeaponFolder;
using IDF_Operation.General.WeaponFolder.TerroristWeapon;
using IDF_Operation.Genertor.GenerateSoldier;
using IDF_Operation.IDF;





for (int i = 0; i<= 5; i++)
{
    IsraeliSoldier g = GenerateSoldier.GenerateIsraeliSoldier();
    Console.WriteLine(g);

    Terrorist t = GenerateSoldier.GenerateTerrorist();
    Console.WriteLine(t);

}