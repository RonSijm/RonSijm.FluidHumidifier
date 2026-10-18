// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerLogDeliveryConfigurationS3ConfigurationFactory(Action<Humidifier.Cognito.LogDeliveryConfigurationTypes.S3Configuration> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.LogDeliveryConfigurationTypes.S3Configuration>
{

    protected override Humidifier.Cognito.LogDeliveryConfigurationTypes.S3Configuration Create()
    {
        var s3ConfigurationResult = CreateS3Configuration();
        factoryAction?.Invoke(s3ConfigurationResult);

        return s3ConfigurationResult;
    }

    private Humidifier.Cognito.LogDeliveryConfigurationTypes.S3Configuration CreateS3Configuration()
    {
        var s3ConfigurationResult = new Humidifier.Cognito.LogDeliveryConfigurationTypes.S3Configuration();

        return s3ConfigurationResult;
    }

} // End Of Class

public static class InnerLogDeliveryConfigurationS3ConfigurationFactoryExtensions
{
}
