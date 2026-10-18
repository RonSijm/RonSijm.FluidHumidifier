// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.XRay;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.XRay.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.XRay.ResourcePolicy>(resourceName)
{

    protected override Humidifier.XRay.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.XRay.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.XRay.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
