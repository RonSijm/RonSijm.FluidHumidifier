// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class RegistryPolicyFactory(string resourceName = null, Action<Humidifier.ECR.RegistryPolicy> factoryAction = null) : ResourceFactory<Humidifier.ECR.RegistryPolicy>(resourceName)
{

    protected override Humidifier.ECR.RegistryPolicy Create()
    {
        var registryPolicyResult = CreateRegistryPolicy();
        factoryAction?.Invoke(registryPolicyResult);

        return registryPolicyResult;
    }

    private Humidifier.ECR.RegistryPolicy CreateRegistryPolicy()
    {
        var registryPolicyResult = new Humidifier.ECR.RegistryPolicy
        {
            GivenName = InputResourceName,
        };

        return registryPolicyResult;
    }

} // End Of Class

public static class RegistryPolicyFactoryExtensions
{
}
