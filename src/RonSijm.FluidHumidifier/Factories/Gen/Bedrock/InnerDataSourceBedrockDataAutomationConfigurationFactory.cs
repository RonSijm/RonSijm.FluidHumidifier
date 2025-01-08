// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceBedrockDataAutomationConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.BedrockDataAutomationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.BedrockDataAutomationConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.BedrockDataAutomationConfiguration Create()
    {
        var bedrockDataAutomationConfigurationResult = CreateBedrockDataAutomationConfiguration();
        factoryAction?.Invoke(bedrockDataAutomationConfigurationResult);

        return bedrockDataAutomationConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.BedrockDataAutomationConfiguration CreateBedrockDataAutomationConfiguration()
    {
        var bedrockDataAutomationConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.BedrockDataAutomationConfiguration();

        return bedrockDataAutomationConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceBedrockDataAutomationConfigurationFactoryExtensions
{
}
