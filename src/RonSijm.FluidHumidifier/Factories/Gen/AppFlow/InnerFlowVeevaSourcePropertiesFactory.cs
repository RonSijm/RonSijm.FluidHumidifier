// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowVeevaSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.VeevaSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.VeevaSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.VeevaSourceProperties Create()
    {
        var veevaSourcePropertiesResult = CreateVeevaSourceProperties();
        factoryAction?.Invoke(veevaSourcePropertiesResult);

        return veevaSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.VeevaSourceProperties CreateVeevaSourceProperties()
    {
        var veevaSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.VeevaSourceProperties();

        return veevaSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowVeevaSourcePropertiesFactoryExtensions
{
}
