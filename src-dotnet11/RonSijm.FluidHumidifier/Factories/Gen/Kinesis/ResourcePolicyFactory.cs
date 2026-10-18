// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kinesis;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.Kinesis.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.Kinesis.ResourcePolicy>(resourceName)
{

    protected override Humidifier.Kinesis.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.Kinesis.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.Kinesis.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
