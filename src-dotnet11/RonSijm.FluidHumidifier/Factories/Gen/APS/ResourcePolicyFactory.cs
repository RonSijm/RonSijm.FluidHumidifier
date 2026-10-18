// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.APS.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.APS.ResourcePolicy>(resourceName)
{

    protected override Humidifier.APS.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.APS.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.APS.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
