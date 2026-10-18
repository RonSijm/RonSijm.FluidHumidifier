// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobJobReportFactory(Action<Humidifier.S3.JobTypes.JobReport> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.JobReport>
{

    protected override Humidifier.S3.JobTypes.JobReport Create()
    {
        var jobReportResult = CreateJobReport();
        factoryAction?.Invoke(jobReportResult);

        return jobReportResult;
    }

    private Humidifier.S3.JobTypes.JobReport CreateJobReport()
    {
        var jobReportResult = new Humidifier.S3.JobTypes.JobReport();

        return jobReportResult;
    }

} // End Of Class

public static class InnerJobJobReportFactoryExtensions
{
}
