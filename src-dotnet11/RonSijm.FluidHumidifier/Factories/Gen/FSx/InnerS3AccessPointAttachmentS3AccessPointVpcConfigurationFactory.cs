// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactory(Action<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration>
{

    protected override Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration Create()
    {
        var s3AccessPointVpcConfigurationResult = CreateS3AccessPointVpcConfiguration();
        factoryAction?.Invoke(s3AccessPointVpcConfigurationResult);

        return s3AccessPointVpcConfigurationResult;
    }

    private Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration CreateS3AccessPointVpcConfiguration()
    {
        var s3AccessPointVpcConfigurationResult = new Humidifier.FSx.S3AccessPointAttachmentTypes.S3AccessPointVpcConfiguration();

        return s3AccessPointVpcConfigurationResult;
    }

} // End Of Class

public static class InnerS3AccessPointAttachmentS3AccessPointVpcConfigurationFactoryExtensions
{
}
