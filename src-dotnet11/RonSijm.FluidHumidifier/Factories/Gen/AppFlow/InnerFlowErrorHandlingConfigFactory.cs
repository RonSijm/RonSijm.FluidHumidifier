// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowErrorHandlingConfigFactory(Action<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig>
{

    protected override Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig Create()
    {
        var errorHandlingConfigResult = CreateErrorHandlingConfig();
        factoryAction?.Invoke(errorHandlingConfigResult);

        return errorHandlingConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig CreateErrorHandlingConfig()
    {
        var errorHandlingConfigResult = new Humidifier.AppFlow.FlowTypes.ErrorHandlingConfig();

        return errorHandlingConfigResult;
    }

} // End Of Class

public static class InnerFlowErrorHandlingConfigFactoryExtensions
{
}
