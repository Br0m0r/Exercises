using D_D_Character;
using System;

public class DnDCharacterGenerator : CalcGen
{
    

    public static void Main()
    {
        int[] abilities = new int[6];  
        string[] abilityNames = { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" };

        
        for (int i = 0; i < 6; i++)
        {
            abilities[i] = GenerateAbilityScore();
            Console.WriteLine($"{abilityNames[i]}: {abilities[i]}");
        }

       
        int hitpoints = CalculateHitpoints(abilities[2]);  
        Console.WriteLine($"Hitpoints: {hitpoints}");
    }

    
}