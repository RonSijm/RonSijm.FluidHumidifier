// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.Bedrock.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.ResourcePolicy>(resourceName)
{

    protected override Humidifier.Bedrock.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.Bedrock.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.Bedrock.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
