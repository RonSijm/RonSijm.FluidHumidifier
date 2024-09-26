// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionFargatePlatformConfigurationFactory(Action<Humidifier.Batch.JobDefinitionTypes.FargatePlatformConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.FargatePlatformConfiguration>
{

    protected override Humidifier.Batch.JobDefinitionTypes.FargatePlatformConfiguration Create()
    {
        var fargatePlatformConfigurationResult = CreateFargatePlatformConfiguration();
        factoryAction?.Invoke(fargatePlatformConfigurationResult);

        return fargatePlatformConfigurationResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.FargatePlatformConfiguration CreateFargatePlatformConfiguration()
    {
        var fargatePlatformConfigurationResult = new Humidifier.Batch.JobDefinitionTypes.FargatePlatformConfiguration();

        return fargatePlatformConfigurationResult;
    }

} // End Of Class

public static class InnerJobDefinitionFargatePlatformConfigurationFactoryExtensions
{
}
