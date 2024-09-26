// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerLaunchConfigurationMetadataOptionsFactory(Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions>
{

    protected override Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions Create()
    {
        var metadataOptionsResult = CreateMetadataOptions();
        factoryAction?.Invoke(metadataOptionsResult);

        return metadataOptionsResult;
    }

    private Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions CreateMetadataOptions()
    {
        var metadataOptionsResult = new Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions();

        return metadataOptionsResult;
    }

} // End Of Class

public static class InnerLaunchConfigurationMetadataOptionsFactoryExtensions
{
}
