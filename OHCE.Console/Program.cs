using OHCE;
using OHCE.Console.Adapters;

var ohce = new Ohce(SystemLangueAdapter.LangueActuelle, SystemTimePériodeJournéeAdapter.PériodeActuelle);

Console.WriteLine(ohce.DireBonjour());

Console.WriteLine($"{Expressions.Français.ExPalindrome}: {ohce.GenererPalindrome()}");

Console.WriteLine(Expressions.Français.TitrePalindrome);
Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? String.Empty));

Console.WriteLine(ohce.DireAurevoir());