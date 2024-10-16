// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceSemanticChunkingConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.SemanticChunkingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.SemanticChunkingConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.SemanticChunkingConfiguration Create()
    {
        var semanticChunkingConfigurationResult = CreateSemanticChunkingConfiguration();
        factoryAction?.Invoke(semanticChunkingConfigurationResult);

        return semanticChunkingConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.SemanticChunkingConfiguration CreateSemanticChunkingConfiguration()
    {
        var semanticChunkingConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.SemanticChunkingConfiguration();

        return semanticChunkingConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceSemanticChunkingConfigurationFactoryExtensions
{
}
