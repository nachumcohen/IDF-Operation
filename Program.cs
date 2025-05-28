// See https://aka.ms/new-console-template for more information
using IDF_Operation.Enemy;
using IDF_Operation.General.WeaponFolder;
using IDF_Operation.General.WeaponFolder.TerroristWeapon;
using IDF_Operation.Genertor.GenerateSoldier;
using IDF_Operation.IDF;




IDF idf = new IDF();
for (int i = 0; i<= 5; i++)
{
    IsraeliSoldier g = GenerateSoldier.GenerateIsraeliSoldier();

    Terrorist t = GenerateSoldier.GenerateTerrorist();


    try
    {
        idf.ShowAvailbleStrike();
        idf.Fire();
    }
    catch
    {

    }

}