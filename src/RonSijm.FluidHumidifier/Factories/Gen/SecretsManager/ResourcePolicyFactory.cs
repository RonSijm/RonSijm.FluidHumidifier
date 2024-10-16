// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecretsManager;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.SecretsManager.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.SecretsManager.ResourcePolicy>(resourceName)
{

    protected override Humidifier.SecretsManager.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.SecretsManager.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.SecretsManager.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
