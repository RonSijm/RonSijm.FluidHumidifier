namespace RonSijm.FluidHumidifier.CodeGen.CLI
{
    public static class CodeGenSettings
    {
        public static string OutputPath { get; } = Path.GetFullPath(Path.Combine(
            AppContext.BaseDirectory,
            "..",
            "..",
            "..",
            "..",
            "RonSijm.FluidHumidifier",
            "Factories",
            "Gen"));
    }
}
