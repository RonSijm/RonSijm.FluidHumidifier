// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SMSVOICE;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.SMSVOICE.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.SMSVOICE.ResourcePolicy>(resourceName)
{

    protected override Humidifier.SMSVOICE.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.SMSVOICE.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.SMSVOICE.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
