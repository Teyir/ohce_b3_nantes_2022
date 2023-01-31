namespace OHCE.Langues
{
    public class LangueFrançaise : ILangue
    {
      
        public string BienDit => Expressions.Français.BienDit;

     
        public string DireBonjour(PériodeJournée periodeJournée)
        {
            return periodeJournée == PériodeJournée.Soir 
                ? Expressions.Français.Bonsoir 
                : Expressions.Français.Bonjour;
        }

        public string DireAuRevoir(PériodeJournée periodeJournée)
        {
            return periodeJournée == PériodeJournée.Soir
                ? Expressions.Français.Bonsoir
                : Expressions.Français.AuRevoir;
        }


        public string LangageUtilise => Expressions.Français.LangueUtilisee;

        public string Periode => Expressions.Français.Periode;

        public string InputText => Expressions.Français.InputText;

        public string MotInverse => Expressions.Français.MotInversé;
    }
}
