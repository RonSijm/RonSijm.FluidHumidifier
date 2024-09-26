// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerDistributionConfigurationLaunchPermissionConfigurationFactory(Action<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration>
{

    protected override Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration Create()
    {
        var launchPermissionConfigurationResult = CreateLaunchPermissionConfiguration();
        factoryAction?.Invoke(launchPermissionConfigurationResult);

        return launchPermissionConfigurationResult;
    }

    private Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration CreateLaunchPermissionConfiguration()
    {
        var launchPermissionConfigurationResult = new Humidifier.ImageBuilder.DistributionConfigurationTypes.LaunchPermissionConfiguration();

        return launchPermissionConfigurationResult;
    }

} // End Of Class

public static class InnerDistributionConfigurationLaunchPermissionConfigurationFactoryExtensions
{
}
