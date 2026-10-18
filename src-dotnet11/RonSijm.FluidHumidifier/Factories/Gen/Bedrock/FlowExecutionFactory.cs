// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class FlowExecutionFactory(string resourceName = null, Action<Humidifier.Bedrock.FlowExecution> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.FlowExecution>(resourceName)
{

    protected override Humidifier.Bedrock.FlowExecution Create()
    {
        var flowExecutionResult = CreateFlowExecution();
        factoryAction?.Invoke(flowExecutionResult);

        return flowExecutionResult;
    }

    private Humidifier.Bedrock.FlowExecution CreateFlowExecution()
    {
        var flowExecutionResult = new Humidifier.Bedrock.FlowExecution
        {
            GivenName = InputResourceName,
        };

        return flowExecutionResult;
    }

} // End Of Class

public static class FlowExecutionFactoryExtensions
{
}
