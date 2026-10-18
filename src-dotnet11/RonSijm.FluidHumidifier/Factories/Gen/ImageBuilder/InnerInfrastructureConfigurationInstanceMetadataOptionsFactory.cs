// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerInfrastructureConfigurationInstanceMetadataOptionsFactory(Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions>
{

    protected override Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions Create()
    {
        var instanceMetadataOptionsResult = CreateInstanceMetadataOptions();
        factoryAction?.Invoke(instanceMetadataOptionsResult);

        return instanceMetadataOptionsResult;
    }

    private Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions CreateInstanceMetadataOptions()
    {
        var instanceMetadataOptionsResult = new Humidifier.ImageBuilder.InfrastructureConfigurationTypes.InstanceMetadataOptions();

        return instanceMetadataOptionsResult;
    }

} // End Of Class

public static class InnerInfrastructureConfigurationInstanceMetadataOptionsFactoryExtensions
{
}
