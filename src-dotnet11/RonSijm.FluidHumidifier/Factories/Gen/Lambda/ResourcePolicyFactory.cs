// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.Lambda.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.Lambda.ResourcePolicy>(resourceName)
{

    protected override Humidifier.Lambda.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.Lambda.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.Lambda.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
