// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.EventsV2.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.EventsV2.ResourcePolicy>(resourceName)
{

    protected override Humidifier.EventsV2.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.EventsV2.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.EventsV2.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
