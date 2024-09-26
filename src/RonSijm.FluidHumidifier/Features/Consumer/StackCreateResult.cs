namespace RonSijm.FluidHumidifier.Features.Consumer
{
    public class StackCreateResult
    {
        public Stack Stack { get; set; }
        public ExportModel Export { get; set; } = new();
    }
}