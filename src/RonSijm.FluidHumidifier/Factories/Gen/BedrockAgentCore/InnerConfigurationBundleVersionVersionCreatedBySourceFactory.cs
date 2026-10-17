// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerConfigurationBundleVersionVersionCreatedBySourceFactory(Action<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource>
{

    protected override Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource Create()
    {
        var versionCreatedBySourceResult = CreateVersionCreatedBySource();
        factoryAction?.Invoke(versionCreatedBySourceResult);

        return versionCreatedBySourceResult;
    }

    private Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource CreateVersionCreatedBySource()
    {
        var versionCreatedBySourceResult = new Humidifier.BedrockAgentCore.ConfigurationBundleVersionTypes.VersionCreatedBySource();

        return versionCreatedBySourceResult;
    }

} // End Of Class

public static class InnerConfigurationBundleVersionVersionCreatedBySourceFactoryExtensions
{
}
