// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowSuccessResponseHandlingConfigFactory(Action<Humidifier.AppFlow.FlowTypes.SuccessResponseHandlingConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.SuccessResponseHandlingConfig>
{

    protected override Humidifier.AppFlow.FlowTypes.SuccessResponseHandlingConfig Create()
    {
        var successResponseHandlingConfigResult = CreateSuccessResponseHandlingConfig();
        factoryAction?.Invoke(successResponseHandlingConfigResult);

        return successResponseHandlingConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.SuccessResponseHandlingConfig CreateSuccessResponseHandlingConfig()
    {
        var successResponseHandlingConfigResult = new Humidifier.AppFlow.FlowTypes.SuccessResponseHandlingConfig();

        return successResponseHandlingConfigResult;
    }

} // End Of Class

public static class InnerFlowSuccessResponseHandlingConfigFactoryExtensions
{
}
