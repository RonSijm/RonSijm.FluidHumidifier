// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.CloudTrail.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.CloudTrail.ResourcePolicy>(resourceName)
{

    protected override Humidifier.CloudTrail.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.CloudTrail.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.CloudTrail.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
