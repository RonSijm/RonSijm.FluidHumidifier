// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventSchemas;

public class RegistryPolicyFactory(string resourceName = null, Action<Humidifier.EventSchemas.RegistryPolicy> factoryAction = null) : ResourceFactory<Humidifier.EventSchemas.RegistryPolicy>(resourceName)
{

    protected override Humidifier.EventSchemas.RegistryPolicy Create()
    {
        var registryPolicyResult = CreateRegistryPolicy();
        factoryAction?.Invoke(registryPolicyResult);

        return registryPolicyResult;
    }

    private Humidifier.EventSchemas.RegistryPolicy CreateRegistryPolicy()
    {
        var registryPolicyResult = new Humidifier.EventSchemas.RegistryPolicy
        {
            GivenName = InputResourceName,
        };

        return registryPolicyResult;
    }

} // End Of Class

public static class RegistryPolicyFactoryExtensions
{
}
