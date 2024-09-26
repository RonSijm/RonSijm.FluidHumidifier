// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowZendeskSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.ZendeskSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.ZendeskSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.ZendeskSourceProperties Create()
    {
        var zendeskSourcePropertiesResult = CreateZendeskSourceProperties();
        factoryAction?.Invoke(zendeskSourcePropertiesResult);

        return zendeskSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.ZendeskSourceProperties CreateZendeskSourceProperties()
    {
        var zendeskSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.ZendeskSourceProperties();

        return zendeskSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowZendeskSourcePropertiesFactoryExtensions
{
}
