// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutEquipment;

public class InnerInferenceSchedulerS3InputConfigurationFactory(Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3InputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3InputConfiguration>
{

    protected override Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3InputConfiguration Create()
    {
        var s3InputConfigurationResult = CreateS3InputConfiguration();
        factoryAction?.Invoke(s3InputConfigurationResult);

        return s3InputConfigurationResult;
    }

    private Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3InputConfiguration CreateS3InputConfiguration()
    {
        var s3InputConfigurationResult = new Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3InputConfiguration();

        return s3InputConfigurationResult;
    }

} // End Of Class

public static class InnerInferenceSchedulerS3InputConfigurationFactoryExtensions
{
}
