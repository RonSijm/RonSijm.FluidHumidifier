// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerFlowAliasFlowAliasConcurrencyConfigurationFactory(Action<Humidifier.Bedrock.FlowAliasTypes.FlowAliasConcurrencyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.FlowAliasTypes.FlowAliasConcurrencyConfiguration>
{

    protected override Humidifier.Bedrock.FlowAliasTypes.FlowAliasConcurrencyConfiguration Create()
    {
        var flowAliasConcurrencyConfigurationResult = CreateFlowAliasConcurrencyConfiguration();
        factoryAction?.Invoke(flowAliasConcurrencyConfigurationResult);

        return flowAliasConcurrencyConfigurationResult;
    }

    private Humidifier.Bedrock.FlowAliasTypes.FlowAliasConcurrencyConfiguration CreateFlowAliasConcurrencyConfiguration()
    {
        var flowAliasConcurrencyConfigurationResult = new Humidifier.Bedrock.FlowAliasTypes.FlowAliasConcurrencyConfiguration();

        return flowAliasConcurrencyConfigurationResult;
    }

} // End Of Class

public static class InnerFlowAliasFlowAliasConcurrencyConfigurationFactoryExtensions
{
}
