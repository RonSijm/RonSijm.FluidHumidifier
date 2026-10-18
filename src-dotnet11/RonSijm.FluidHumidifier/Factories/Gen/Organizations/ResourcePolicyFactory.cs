// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Organizations;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.Organizations.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.Organizations.ResourcePolicy>(resourceName)
{

    protected override Humidifier.Organizations.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.Organizations.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.Organizations.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
