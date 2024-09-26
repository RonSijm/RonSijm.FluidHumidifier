// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutEquipment;

public class InnerInferenceSchedulerS3OutputConfigurationFactory(Action<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration>
{

    protected override Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration Create()
    {
        var s3OutputConfigurationResult = CreateS3OutputConfiguration();
        factoryAction?.Invoke(s3OutputConfigurationResult);

        return s3OutputConfigurationResult;
    }

    private Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration CreateS3OutputConfiguration()
    {
        var s3OutputConfigurationResult = new Humidifier.LookoutEquipment.InferenceSchedulerTypes.S3OutputConfiguration();

        return s3OutputConfigurationResult;
    }

} // End Of Class

public static class InnerInferenceSchedulerS3OutputConfigurationFactoryExtensions
{
}
