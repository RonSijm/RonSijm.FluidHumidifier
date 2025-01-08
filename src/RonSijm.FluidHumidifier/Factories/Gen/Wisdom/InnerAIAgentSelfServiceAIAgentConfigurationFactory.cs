// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerAIAgentSelfServiceAIAgentConfigurationFactory(Action<Humidifier.Wisdom.AIAgentTypes.SelfServiceAIAgentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.AIAgentTypes.SelfServiceAIAgentConfiguration>
{

    protected override Humidifier.Wisdom.AIAgentTypes.SelfServiceAIAgentConfiguration Create()
    {
        var selfServiceAIAgentConfigurationResult = CreateSelfServiceAIAgentConfiguration();
        factoryAction?.Invoke(selfServiceAIAgentConfigurationResult);

        return selfServiceAIAgentConfigurationResult;
    }

    private Humidifier.Wisdom.AIAgentTypes.SelfServiceAIAgentConfiguration CreateSelfServiceAIAgentConfiguration()
    {
        var selfServiceAIAgentConfigurationResult = new Humidifier.Wisdom.AIAgentTypes.SelfServiceAIAgentConfiguration();

        return selfServiceAIAgentConfigurationResult;
    }

} // End Of Class

public static class InnerAIAgentSelfServiceAIAgentConfigurationFactoryExtensions
{
}
