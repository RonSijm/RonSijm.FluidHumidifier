// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceMetadataOptionsFactory(Action<Humidifier.EC2.InstanceTypes.MetadataOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.MetadataOptions>
{

    protected override Humidifier.EC2.InstanceTypes.MetadataOptions Create()
    {
        var metadataOptionsResult = CreateMetadataOptions();
        factoryAction?.Invoke(metadataOptionsResult);

        return metadataOptionsResult;
    }

    private Humidifier.EC2.InstanceTypes.MetadataOptions CreateMetadataOptions()
    {
        var metadataOptionsResult = new Humidifier.EC2.InstanceTypes.MetadataOptions();

        return metadataOptionsResult;
    }

} // End Of Class

public static class InnerInstanceMetadataOptionsFactoryExtensions
{
}
