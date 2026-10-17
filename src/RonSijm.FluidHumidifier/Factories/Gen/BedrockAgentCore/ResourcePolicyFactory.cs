// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.ResourcePolicy>(resourceName)
{

    protected override Humidifier.BedrockAgentCore.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.BedrockAgentCore.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.BedrockAgentCore.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
