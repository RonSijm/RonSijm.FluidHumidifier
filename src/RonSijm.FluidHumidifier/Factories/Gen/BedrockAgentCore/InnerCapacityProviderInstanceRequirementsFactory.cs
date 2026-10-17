// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerCapacityProviderInstanceRequirementsFactory(Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceRequirements> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceRequirements>
{

    protected override Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceRequirements Create()
    {
        var instanceRequirementsResult = CreateInstanceRequirements();
        factoryAction?.Invoke(instanceRequirementsResult);

        return instanceRequirementsResult;
    }

    private Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceRequirements CreateInstanceRequirements()
    {
        var instanceRequirementsResult = new Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceRequirements();

        return instanceRequirementsResult;
    }

} // End Of Class

public static class InnerCapacityProviderInstanceRequirementsFactoryExtensions
{
}
