using System.Reflection;

public class Alphabet 
{
    public static string FaiqahAlphabet()
    {
        Dictionary<char, string> Ade = new Dictionary<char, string>();
        Ade['A'] = "Aluminium";
        Ade['B'] = "Berilium";
        Ade['C'] = "Calcium";
        Ade['D'] = "Diffussion"; 
        Ade['E'] = "Element";
        Ade['F'] = "Force";
        Ade['G'] = "Geology";
        Ade['H'] = "Hormones"; 
        Ade['I'] = "Ion";
        Ade['J'] = "Jet stream";
        Ade['K'] = "Kelvin";
        Ade['L'] = "Laser";
        Ade['M'] = "Molecule";
        Ade['N'] = "Neon";
        Ade['O'] = "Ozone";
        Ade['P'] = "Planet";
        Ade['Q'] = "Quark";
        Ade['R'] = "Radiation";
        Ade['S'] = "Speed";
        Ade['T'] = "Tissue";
        Ade['U'] = "Urea";
        Ade['V'] = "Velocity";
        Ade['W'] = "Wind";
        Ade['X'] = "X-ray";
        Ade['Y'] = "Yield";
        Ade['Z'] = "Zygote";
        int i = 1;
        foreach(var Ayo in Ade)
        {
            Console.WriteLine($"{i}. {Ayo.Key}: {Ayo.Value}");
            i++;
            
        } 
        return"Faidah";
    }





}