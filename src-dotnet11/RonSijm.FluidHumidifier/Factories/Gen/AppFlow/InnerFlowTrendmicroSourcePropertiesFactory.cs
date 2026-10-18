// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowTrendmicroSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.TrendmicroSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.TrendmicroSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.TrendmicroSourceProperties Create()
    {
        var trendmicroSourcePropertiesResult = CreateTrendmicroSourceProperties();
        factoryAction?.Invoke(trendmicroSourcePropertiesResult);

        return trendmicroSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.TrendmicroSourceProperties CreateTrendmicroSourceProperties()
    {
        var trendmicroSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.TrendmicroSourceProperties();

        return trendmicroSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowTrendmicroSourcePropertiesFactoryExtensions
{
}
