namespace RonSijm.FluidHumidifier.CodeGen.CLI
{
    public static class ConfigArgParser
    {
        public static FluentGeneratorCoreSettings CreateConfig(string[] args)
        {
            var config = new FluentGeneratorCoreSettings
            {
                Directory = GetDirectory(args),
                ForceRedownload = args.Any(x => x.Equals("-ForceRedownload", StringComparison.InvariantCultureIgnoreCase)),
                ForceRegenerate = args.Any(x => x.Equals("-ForceRegenerate", StringComparison.InvariantCultureIgnoreCase)),
                NoUpdateCheck = args.Any(x => x.Equals("-NoUpdateCheck", StringComparison.InvariantCultureIgnoreCase)),
            };
            return config;
        }

        private static string GetDirectory(string[] args)
        {
            string directory = null;

            for (var i = 0; i < args.Length; i++)
            {
                if (args[i].Equals("-directory", StringComparison.OrdinalIgnoreCase) && i + 1 < args.Length)
                {
                    directory = args[i + 1];
                }
            }

            if (directory == null)
            {
                Console.WriteLine("-directory args not specified. Using current dir.");
                directory = Directory.GetCurrentDirectory();
            }
            else
            {
                Console.WriteLine($"-directory specified. Using {directory}");
            }

            if (directory.EndsWith("RonSijm.Humidifier"))
            {
                directory = Path.Combine(directory, "src");
            }

            return directory;
        }
    }
}
