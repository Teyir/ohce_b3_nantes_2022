using System.Text;

namespace OHCE;

public class Ohce
{

    private readonly ILangue _langue;
    private readonly PériodeJournée _périodeJournée;

    public Ohce(ILangue langue, PériodeJournée périodeJournée)
    {
        _langue = langue;
        _périodeJournée = périodeJournée;
    }

    public string Palindrome(string input)
    {
        var reversed = new string(
            input.ToLower().Reverse().ToArray()
        );

        var stringBuilder =
            new StringBuilder("\n################################################\n" + 
            "Voici votre résultat: " 
            + reversed +
            "\n################################################\n");

        if (reversed.Equals(input.ToLower()))
            stringBuilder.Append(_langue.BienDit);

        return stringBuilder.ToString();
    }

    public string GenererPalindrome()
    {
        List<string> list = new List<string>() { "été", "kayak", "non", "elle", "ère", "rotor", "coloc", "bob", "gag", "radar", "ici"};

        return list.ElementAt(new Random().Next(1, list.Count)).ToString() ?? "C pété";
    }

    public string DireBonjour()
    {
        var stringBuilder =
            new StringBuilder(_langue.DireBonjour(_périodeJournée));

        return stringBuilder.ToString();
    }

    public string DireAurevoir()
    {
        var stringBuilder =
            new StringBuilder(_langue.AuRevoir);

        return stringBuilder.ToString();
    }
}