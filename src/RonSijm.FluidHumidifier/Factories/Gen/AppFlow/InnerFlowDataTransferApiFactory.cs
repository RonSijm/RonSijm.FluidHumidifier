// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowDataTransferApiFactory(Action<Humidifier.AppFlow.FlowTypes.DataTransferApi> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.DataTransferApi>
{

    protected override Humidifier.AppFlow.FlowTypes.DataTransferApi Create()
    {
        var dataTransferApiResult = CreateDataTransferApi();
        factoryAction?.Invoke(dataTransferApiResult);

        return dataTransferApiResult;
    }

    private Humidifier.AppFlow.FlowTypes.DataTransferApi CreateDataTransferApi()
    {
        var dataTransferApiResult = new Humidifier.AppFlow.FlowTypes.DataTransferApi();

        return dataTransferApiResult;
    }

} // End Of Class

public static class InnerFlowDataTransferApiFactoryExtensions
{
}
