// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECRPublic;

public class RegistryFactory(string resourceName = null, Action<Humidifier.ECRPublic.Registry> factoryAction = null) : ResourceFactory<Humidifier.ECRPublic.Registry>(resourceName)
{

    protected override Humidifier.ECRPublic.Registry Create()
    {
        var registryResult = CreateRegistry();
        factoryAction?.Invoke(registryResult);

        return registryResult;
    }

    private Humidifier.ECRPublic.Registry CreateRegistry()
    {
        var registryResult = new Humidifier.ECRPublic.Registry
        {
            GivenName = InputResourceName,
        };

        return registryResult;
    }

} // End Of Class

public static class RegistryFactoryExtensions
{
}
