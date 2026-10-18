// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerPolicyGenerationResourceFactory(Action<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource>
{

    protected override Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource Create()
    {
        var resourceResult = CreateResource();
        factoryAction?.Invoke(resourceResult);

        return resourceResult;
    }

    private Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource CreateResource()
    {
        var resourceResult = new Humidifier.BedrockAgentCore.PolicyGenerationTypes.Resource();

        return resourceResult;
    }

} // End Of Class

public static class InnerPolicyGenerationResourceFactoryExtensions
{
}
