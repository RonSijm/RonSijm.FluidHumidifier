// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowPardotSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.PardotSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.PardotSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.PardotSourceProperties Create()
    {
        var pardotSourcePropertiesResult = CreatePardotSourceProperties();
        factoryAction?.Invoke(pardotSourcePropertiesResult);

        return pardotSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.PardotSourceProperties CreatePardotSourceProperties()
    {
        var pardotSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.PardotSourceProperties();

        return pardotSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowPardotSourcePropertiesFactoryExtensions
{
}
