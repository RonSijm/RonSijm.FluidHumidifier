// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateAwsJobAbortConfigFactory(Action<Humidifier.IoT.OTAUpdateTypes.AwsJobAbortConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.AwsJobAbortConfig>
{

    protected override Humidifier.IoT.OTAUpdateTypes.AwsJobAbortConfig Create()
    {
        var awsJobAbortConfigResult = CreateAwsJobAbortConfig();
        factoryAction?.Invoke(awsJobAbortConfigResult);

        return awsJobAbortConfigResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.AwsJobAbortConfig CreateAwsJobAbortConfig()
    {
        var awsJobAbortConfigResult = new Humidifier.IoT.OTAUpdateTypes.AwsJobAbortConfig();

        return awsJobAbortConfigResult;
    }

} // End Of Class

public static class InnerOTAUpdateAwsJobAbortConfigFactoryExtensions
{
}
