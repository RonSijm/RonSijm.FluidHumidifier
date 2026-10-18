// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerConfigurationBundleVersionCreatedBySourceFactory(Action<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource>
{

    protected override Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource Create()
    {
        var versionCreatedBySourceResult = CreateVersionCreatedBySource();
        factoryAction?.Invoke(versionCreatedBySourceResult);

        return versionCreatedBySourceResult;
    }

    private Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource CreateVersionCreatedBySource()
    {
        var versionCreatedBySourceResult = new Humidifier.BedrockAgentCore.ConfigurationBundleTypes.VersionCreatedBySource();

        return versionCreatedBySourceResult;
    }

} // End Of Class

public static class InnerConfigurationBundleVersionCreatedBySourceFactoryExtensions
{
}
