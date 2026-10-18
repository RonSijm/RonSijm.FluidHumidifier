namespace RonSijm.FluidHumidifier.CodeGen.CLI.Helpers
{
    public static class PropertyNameFormatter
    {
        public static void WriteSpecsToFile(string srcPath, string json)
        {
            var codegenPath = Path.Combine(srcPath, "Humidifier.CodeGen.Lib");
            var path = Path.Combine(codegenPath, "Specification.json");
            if (!File.Exists(path) || File.ReadAllText(path) != json)
            {
                File.WriteAllText(path, json);
            }
        }
    }
}
