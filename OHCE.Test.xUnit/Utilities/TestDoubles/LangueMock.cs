namespace OHCE.Test.xUnit.Utilities.TestDoubles
{
    internal record LangueMock : ILangue
    {
        public string BienDit { get; init; } = string.Empty;
        public string DireBonjour(PériodeJournée periodeJournée) => String.Empty;
        public string DireAuRevoir(PériodeJournée periodeJournée) => String.Empty;
        public string LangageUtilise { get; init; } = string.Empty;
        public string Periode { get; init; } = string.Empty;
        public string InputText { get; init; } = string.Empty;
        public string MotInverse { get; init; } = string.Empty;
    }
}
