namespace OHCE
{
    public interface ILangue
    {
        string BienDit { get; }
        string DireBonjour(PériodeJournée periodeJournée);
        string DireAuRevoir(PériodeJournée periodeJournée);
        string LangageUtilise { get; }
        string Periode { get; }
        string InputText { get; }
        string MotInverse { get; }
    }
}
