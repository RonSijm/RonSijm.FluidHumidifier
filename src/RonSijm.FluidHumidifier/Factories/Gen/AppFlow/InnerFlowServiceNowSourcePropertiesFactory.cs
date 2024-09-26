// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowServiceNowSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.ServiceNowSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.ServiceNowSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.ServiceNowSourceProperties Create()
    {
        var serviceNowSourcePropertiesResult = CreateServiceNowSourceProperties();
        factoryAction?.Invoke(serviceNowSourcePropertiesResult);

        return serviceNowSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.ServiceNowSourceProperties CreateServiceNowSourceProperties()
    {
        var serviceNowSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.ServiceNowSourceProperties();

        return serviceNowSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowServiceNowSourcePropertiesFactoryExtensions
{
}
