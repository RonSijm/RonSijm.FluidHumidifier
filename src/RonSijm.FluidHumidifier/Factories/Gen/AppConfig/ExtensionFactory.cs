// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppConfig;

public class ExtensionFactory(string resourceName = null, Action<Humidifier.AppConfig.Extension> factoryAction = null) : ResourceFactory<Humidifier.AppConfig.Extension>(resourceName)
{

    protected override Humidifier.AppConfig.Extension Create()
    {
        var extensionResult = CreateExtension();
        factoryAction?.Invoke(extensionResult);

        return extensionResult;
    }

    private Humidifier.AppConfig.Extension CreateExtension()
    {
        var extensionResult = new Humidifier.AppConfig.Extension
        {
            GivenName = InputResourceName,
        };

        return extensionResult;
    }

} // End Of Class

public static class ExtensionFactoryExtensions
{
}
