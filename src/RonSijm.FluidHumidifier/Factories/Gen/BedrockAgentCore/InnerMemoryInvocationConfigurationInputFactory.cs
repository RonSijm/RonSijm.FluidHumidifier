// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerMemoryInvocationConfigurationInputFactory(Action<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput>
{

    protected override Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput Create()
    {
        var invocationConfigurationInputResult = CreateInvocationConfigurationInput();
        factoryAction?.Invoke(invocationConfigurationInputResult);

        return invocationConfigurationInputResult;
    }

    private Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput CreateInvocationConfigurationInput()
    {
        var invocationConfigurationInputResult = new Humidifier.BedrockAgentCore.MemoryTypes.InvocationConfigurationInput();

        return invocationConfigurationInputResult;
    }

} // End Of Class

public static class InnerMemoryInvocationConfigurationInputFactoryExtensions
{
}
