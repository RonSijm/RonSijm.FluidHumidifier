using Microsoft.Extensions.Configuration;

namespace AppleStore.AWS.NimbusFactory.CLI.Core.Wiring
{
    public class SettingsWiring
    {
        public static AppSettings GetSettings()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            var settings = new AppSettings();
            config.Bind(settings);
            settings.BaseDir = Path.GetFullPath(settings.BaseDir, AppContext.BaseDirectory)
                .TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
                + Path.DirectorySeparatorChar;

            return settings;
        }
    }
}
