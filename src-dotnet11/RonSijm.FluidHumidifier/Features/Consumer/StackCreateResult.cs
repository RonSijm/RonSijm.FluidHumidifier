namespace RonSijm.FluidHumidifier.Features.Consumer
{
    public class StackCreateResult
    {
        public Stack Stack { get; set; }
        public string Region { get; set; }
        public ExportModel Export { get; set; } = new();
    }
}
