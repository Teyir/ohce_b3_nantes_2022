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
            new StringBuilder(DireBonjour() + "\n");

        if (reversed.Equals(input.ToLower()))
            stringBuilder.Append(reversed + "\n" + DireBienDit() + "\n");
        else
            stringBuilder.Append(_langue.MotInverse + " : " + reversed + "\n");

        stringBuilder.Append(DireAuRevoir());

        return stringBuilder.ToString();
    }

    public string GenererPalindrome()
    {
        List<string> list = new List<string>() { "été", "kayak", "non", "elle", "ère", "rotor", "coloc", "bob", "gag", "radar", "ici"};

        return list.ElementAt(new Random().Next(1, list.Count)).ToString() ?? "C pété";
    }

    public string DireBienDit()
    {

        return _langue.BienDit;
    }

    public string DireBonjour()
    {

        return _langue.DireBonjour(_périodeJournée);
    }

    public string DireAuRevoir()
    {
        return _langue.DireAuRevoir(_périodeJournée);
    }
}