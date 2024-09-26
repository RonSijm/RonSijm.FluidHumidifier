// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowSAPODataParallelismConfigFactory(Action<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig>
{

    protected override Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig Create()
    {
        var sAPODataParallelismConfigResult = CreateSAPODataParallelismConfig();
        factoryAction?.Invoke(sAPODataParallelismConfigResult);

        return sAPODataParallelismConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig CreateSAPODataParallelismConfig()
    {
        var sAPODataParallelismConfigResult = new Humidifier.AppFlow.FlowTypes.SAPODataParallelismConfig();

        return sAPODataParallelismConfigResult;
    }

} // End Of Class

public static class InnerFlowSAPODataParallelismConfigFactoryExtensions
{
}
