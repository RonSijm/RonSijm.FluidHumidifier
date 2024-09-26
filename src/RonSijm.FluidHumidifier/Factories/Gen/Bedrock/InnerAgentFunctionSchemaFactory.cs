// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentFunctionSchemaFactory(Action<Humidifier.Bedrock.AgentTypes.FunctionSchema> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentTypes.FunctionSchema>
{

    protected override Humidifier.Bedrock.AgentTypes.FunctionSchema Create()
    {
        var functionSchemaResult = CreateFunctionSchema();
        factoryAction?.Invoke(functionSchemaResult);

        return functionSchemaResult;
    }

    private Humidifier.Bedrock.AgentTypes.FunctionSchema CreateFunctionSchema()
    {
        var functionSchemaResult = new Humidifier.Bedrock.AgentTypes.FunctionSchema();

        return functionSchemaResult;
    }

} // End Of Class

public static class InnerAgentFunctionSchemaFactoryExtensions
{
}
