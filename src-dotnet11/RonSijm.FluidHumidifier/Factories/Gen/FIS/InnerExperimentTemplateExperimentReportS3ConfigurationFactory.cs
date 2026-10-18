// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FIS;

public class InnerExperimentTemplateExperimentReportS3ConfigurationFactory(Action<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration> factoryAction = null) : SubResourceFactory<Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration>
{

    protected override Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration Create()
    {
        var experimentReportS3ConfigurationResult = CreateExperimentReportS3Configuration();
        factoryAction?.Invoke(experimentReportS3ConfigurationResult);

        return experimentReportS3ConfigurationResult;
    }

    private Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration CreateExperimentReportS3Configuration()
    {
        var experimentReportS3ConfigurationResult = new Humidifier.FIS.ExperimentTemplateTypes.ExperimentReportS3Configuration();

        return experimentReportS3ConfigurationResult;
    }

} // End Of Class

public static class InnerExperimentTemplateExperimentReportS3ConfigurationFactoryExtensions
{
}
