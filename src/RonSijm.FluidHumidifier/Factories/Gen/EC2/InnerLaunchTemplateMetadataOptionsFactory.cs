// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerLaunchTemplateMetadataOptionsFactory(Action<Humidifier.EC2.LaunchTemplateTypes.MetadataOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.LaunchTemplateTypes.MetadataOptions>
{

    protected override Humidifier.EC2.LaunchTemplateTypes.MetadataOptions Create()
    {
        var metadataOptionsResult = CreateMetadataOptions();
        factoryAction?.Invoke(metadataOptionsResult);

        return metadataOptionsResult;
    }

    private Humidifier.EC2.LaunchTemplateTypes.MetadataOptions CreateMetadataOptions()
    {
        var metadataOptionsResult = new Humidifier.EC2.LaunchTemplateTypes.MetadataOptions();

        return metadataOptionsResult;
    }

} // End Of Class

public static class InnerLaunchTemplateMetadataOptionsFactoryExtensions
{
}
