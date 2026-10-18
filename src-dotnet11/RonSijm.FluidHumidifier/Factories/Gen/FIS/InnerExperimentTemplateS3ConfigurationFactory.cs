// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FIS;

public class InnerExperimentTemplateS3ConfigurationFactory(Action<Humidifier.FIS.ExperimentTemplateTypes.S3Configuration> factoryAction = null) : SubResourceFactory<Humidifier.FIS.ExperimentTemplateTypes.S3Configuration>
{

    protected override Humidifier.FIS.ExperimentTemplateTypes.S3Configuration Create()
    {
        var s3ConfigurationResult = CreateS3Configuration();
        factoryAction?.Invoke(s3ConfigurationResult);

        return s3ConfigurationResult;
    }

    private Humidifier.FIS.ExperimentTemplateTypes.S3Configuration CreateS3Configuration()
    {
        var s3ConfigurationResult = new Humidifier.FIS.ExperimentTemplateTypes.S3Configuration();

        return s3ConfigurationResult;
    }

} // End Of Class

public static class InnerExperimentTemplateS3ConfigurationFactoryExtensions
{
}
