// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerFlowFlowDefinitionFactory(Action<Humidifier.Bedrock.FlowTypes.FlowDefinition> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.FlowTypes.FlowDefinition>
{

    protected override Humidifier.Bedrock.FlowTypes.FlowDefinition Create()
    {
        var flowDefinitionResult = CreateFlowDefinition();
        factoryAction?.Invoke(flowDefinitionResult);

        return flowDefinitionResult;
    }

    private Humidifier.Bedrock.FlowTypes.FlowDefinition CreateFlowDefinition()
    {
        var flowDefinitionResult = new Humidifier.Bedrock.FlowTypes.FlowDefinition();

        return flowDefinitionResult;
    }

} // End Of Class

public static class InnerFlowFlowDefinitionFactoryExtensions
{
}
