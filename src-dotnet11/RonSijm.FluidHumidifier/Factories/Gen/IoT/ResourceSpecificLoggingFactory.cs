// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class ResourceSpecificLoggingFactory(string resourceName = null, Action<Humidifier.IoT.ResourceSpecificLogging> factoryAction = null) : ResourceFactory<Humidifier.IoT.ResourceSpecificLogging>(resourceName)
{

    protected override Humidifier.IoT.ResourceSpecificLogging Create()
    {
        var resourceSpecificLoggingResult = CreateResourceSpecificLogging();
        factoryAction?.Invoke(resourceSpecificLoggingResult);

        return resourceSpecificLoggingResult;
    }

    private Humidifier.IoT.ResourceSpecificLogging CreateResourceSpecificLogging()
    {
        var resourceSpecificLoggingResult = new Humidifier.IoT.ResourceSpecificLogging
        {
            GivenName = InputResourceName,
        };

        return resourceSpecificLoggingResult;
    }

} // End Of Class

public static class ResourceSpecificLoggingFactoryExtensions
{
}
