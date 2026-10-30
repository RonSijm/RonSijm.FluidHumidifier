// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateAwsJobTimeoutConfigFactory(Action<Humidifier.IoT.OTAUpdateTypes.AwsJobTimeoutConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.AwsJobTimeoutConfig>
{

    protected override Humidifier.IoT.OTAUpdateTypes.AwsJobTimeoutConfig Create()
    {
        var awsJobTimeoutConfigResult = CreateAwsJobTimeoutConfig();
        factoryAction?.Invoke(awsJobTimeoutConfigResult);

        return awsJobTimeoutConfigResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.AwsJobTimeoutConfig CreateAwsJobTimeoutConfig()
    {
        var awsJobTimeoutConfigResult = new Humidifier.IoT.OTAUpdateTypes.AwsJobTimeoutConfig();

        return awsJobTimeoutConfigResult;
    }

} // End Of Class

public static class InnerOTAUpdateAwsJobTimeoutConfigFactoryExtensions
{
}
