// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceHierarchicalChunkingConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.HierarchicalChunkingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.HierarchicalChunkingConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.HierarchicalChunkingConfiguration Create()
    {
        var hierarchicalChunkingConfigurationResult = CreateHierarchicalChunkingConfiguration();
        factoryAction?.Invoke(hierarchicalChunkingConfigurationResult);

        return hierarchicalChunkingConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.HierarchicalChunkingConfiguration CreateHierarchicalChunkingConfiguration()
    {
        var hierarchicalChunkingConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.HierarchicalChunkingConfiguration();

        return hierarchicalChunkingConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceHierarchicalChunkingConfigurationFactoryExtensions
{
}
