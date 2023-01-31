namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        public string BienDit => Expressions.English.BienDit;


        public string DireBonjour(PériodeJournée periodeJournée)
        {
            return periodeJournée == PériodeJournée.Soir
                ? Expressions.English.Bonsoir
                : Expressions.English.Bonjour;
        }

        public string DireAuRevoir(PériodeJournée periodeJournée)
        {
            return periodeJournée == PériodeJournée.Soir
                ? Expressions.English.Bonsoir
                : Expressions.English.AuRevoir;
        }


        public string LangageUtilise => Expressions.English.LangueUtilisee;

        public string Periode => Expressions.English.Periode;

        public string InputText => Expressions.English.InputText;

        public string MotInverse => Expressions.English.MotInversé;
    }
}
