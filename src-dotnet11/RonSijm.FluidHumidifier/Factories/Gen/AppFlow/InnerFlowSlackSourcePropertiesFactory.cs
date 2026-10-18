// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowSlackSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.SlackSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.SlackSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.SlackSourceProperties Create()
    {
        var slackSourcePropertiesResult = CreateSlackSourceProperties();
        factoryAction?.Invoke(slackSourcePropertiesResult);

        return slackSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.SlackSourceProperties CreateSlackSourceProperties()
    {
        var slackSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.SlackSourceProperties();

        return slackSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowSlackSourcePropertiesFactoryExtensions
{
}
