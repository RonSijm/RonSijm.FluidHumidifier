// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowMarketoSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.MarketoSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.MarketoSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.MarketoSourceProperties Create()
    {
        var marketoSourcePropertiesResult = CreateMarketoSourceProperties();
        factoryAction?.Invoke(marketoSourcePropertiesResult);

        return marketoSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.MarketoSourceProperties CreateMarketoSourceProperties()
    {
        var marketoSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.MarketoSourceProperties();

        return marketoSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowMarketoSourcePropertiesFactoryExtensions
{
}
