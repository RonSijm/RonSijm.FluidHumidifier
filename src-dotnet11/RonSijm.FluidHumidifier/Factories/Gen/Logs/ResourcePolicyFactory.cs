// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.Logs.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.Logs.ResourcePolicy>(resourceName)
{

    protected override Humidifier.Logs.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.Logs.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.Logs.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
