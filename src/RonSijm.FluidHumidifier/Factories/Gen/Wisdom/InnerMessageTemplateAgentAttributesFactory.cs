// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerMessageTemplateAgentAttributesFactory(Action<Humidifier.Wisdom.MessageTemplateTypes.AgentAttributes> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.MessageTemplateTypes.AgentAttributes>
{

    protected override Humidifier.Wisdom.MessageTemplateTypes.AgentAttributes Create()
    {
        var agentAttributesResult = CreateAgentAttributes();
        factoryAction?.Invoke(agentAttributesResult);

        return agentAttributesResult;
    }

    private Humidifier.Wisdom.MessageTemplateTypes.AgentAttributes CreateAgentAttributes()
    {
        var agentAttributesResult = new Humidifier.Wisdom.MessageTemplateTypes.AgentAttributes();

        return agentAttributesResult;
    }

} // End Of Class

public static class InnerMessageTemplateAgentAttributesFactoryExtensions
{
}
