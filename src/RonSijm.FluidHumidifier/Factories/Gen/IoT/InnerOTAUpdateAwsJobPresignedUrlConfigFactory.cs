// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateAwsJobPresignedUrlConfigFactory(Action<Humidifier.IoT.OTAUpdateTypes.AwsJobPresignedUrlConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.AwsJobPresignedUrlConfig>
{

    protected override Humidifier.IoT.OTAUpdateTypes.AwsJobPresignedUrlConfig Create()
    {
        var awsJobPresignedUrlConfigResult = CreateAwsJobPresignedUrlConfig();
        factoryAction?.Invoke(awsJobPresignedUrlConfigResult);

        return awsJobPresignedUrlConfigResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.AwsJobPresignedUrlConfig CreateAwsJobPresignedUrlConfig()
    {
        var awsJobPresignedUrlConfigResult = new Humidifier.IoT.OTAUpdateTypes.AwsJobPresignedUrlConfig();

        return awsJobPresignedUrlConfigResult;
    }

} // End Of Class

public static class InnerOTAUpdateAwsJobPresignedUrlConfigFactoryExtensions
{
}
