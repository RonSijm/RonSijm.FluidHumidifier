// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateAwsJobRateIncreaseCriteriaFactory(Action<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria>
{

    protected override Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria Create()
    {
        var awsJobRateIncreaseCriteriaResult = CreateAwsJobRateIncreaseCriteria();
        factoryAction?.Invoke(awsJobRateIncreaseCriteriaResult);

        return awsJobRateIncreaseCriteriaResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria CreateAwsJobRateIncreaseCriteria()
    {
        var awsJobRateIncreaseCriteriaResult = new Humidifier.IoT.OTAUpdateTypes.AwsJobRateIncreaseCriteria();

        return awsJobRateIncreaseCriteriaResult;
    }

} // End Of Class

public static class InnerOTAUpdateAwsJobRateIncreaseCriteriaFactoryExtensions
{
}
