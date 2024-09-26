// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceFixedSizeChunkingConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.FixedSizeChunkingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.FixedSizeChunkingConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.FixedSizeChunkingConfiguration Create()
    {
        var fixedSizeChunkingConfigurationResult = CreateFixedSizeChunkingConfiguration();
        factoryAction?.Invoke(fixedSizeChunkingConfigurationResult);

        return fixedSizeChunkingConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.FixedSizeChunkingConfiguration CreateFixedSizeChunkingConfiguration()
    {
        var fixedSizeChunkingConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.FixedSizeChunkingConfiguration();

        return fixedSizeChunkingConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceFixedSizeChunkingConfigurationFactoryExtensions
{
}
