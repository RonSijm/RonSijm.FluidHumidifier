// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class RegistryFactory(string resourceName = null, Action<Humidifier.Glue.Registry> factoryAction = null) : ResourceFactory<Humidifier.Glue.Registry>(resourceName)
{

    protected override Humidifier.Glue.Registry Create()
    {
        var registryResult = CreateRegistry();
        factoryAction?.Invoke(registryResult);

        return registryResult;
    }

    private Humidifier.Glue.Registry CreateRegistry()
    {
        var registryResult = new Humidifier.Glue.Registry
        {
            GivenName = InputResourceName,
        };

        return registryResult;
    }

} // End Of Class

public static class RegistryFactoryExtensions
{
}
