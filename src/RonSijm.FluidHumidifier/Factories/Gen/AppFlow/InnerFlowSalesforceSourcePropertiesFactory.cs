// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowSalesforceSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.SalesforceSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.SalesforceSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.SalesforceSourceProperties Create()
    {
        var salesforceSourcePropertiesResult = CreateSalesforceSourceProperties();
        factoryAction?.Invoke(salesforceSourcePropertiesResult);

        return salesforceSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.SalesforceSourceProperties CreateSalesforceSourceProperties()
    {
        var salesforceSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.SalesforceSourceProperties();

        return salesforceSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowSalesforceSourcePropertiesFactoryExtensions
{
}
