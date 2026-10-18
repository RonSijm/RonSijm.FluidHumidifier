// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowDynatraceSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.DynatraceSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.DynatraceSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.DynatraceSourceProperties Create()
    {
        var dynatraceSourcePropertiesResult = CreateDynatraceSourceProperties();
        factoryAction?.Invoke(dynatraceSourcePropertiesResult);

        return dynatraceSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.DynatraceSourceProperties CreateDynatraceSourceProperties()
    {
        var dynatraceSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.DynatraceSourceProperties();

        return dynatraceSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowDynatraceSourcePropertiesFactoryExtensions
{
}
