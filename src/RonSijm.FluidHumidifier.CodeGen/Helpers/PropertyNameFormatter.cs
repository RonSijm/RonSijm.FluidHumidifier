namespace RonSijm.FluidHumidifier.CodeGen.CLI.Helpers
{
    public static class PropertyNameFormatter
    {
        public static void WriteSpecsToFile(string srcPath, string json)
        {
            var codegenPath = Path.Combine(srcPath, "Humidifier.CodeGen.Lib");
            File.WriteAllText(Path.Combine(codegenPath, "Specification.json"), json);
        }
    }
}