// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowSAPODataPaginationConfigFactory(Action<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig>
{

    protected override Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig Create()
    {
        var sAPODataPaginationConfigResult = CreateSAPODataPaginationConfig();
        factoryAction?.Invoke(sAPODataPaginationConfigResult);

        return sAPODataPaginationConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig CreateSAPODataPaginationConfig()
    {
        var sAPODataPaginationConfigResult = new Humidifier.AppFlow.FlowTypes.SAPODataPaginationConfig();

        return sAPODataPaginationConfigResult;
    }

} // End Of Class

public static class InnerFlowSAPODataPaginationConfigFactoryExtensions
{
}
