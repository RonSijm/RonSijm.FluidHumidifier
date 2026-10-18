// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class JobFactory(string resourceName = null, Action<Humidifier.S3.Job> factoryAction = null) : ResourceFactory<Humidifier.S3.Job>(resourceName)
{

    internal InnerJobJobManifestGeneratorFactory ManifestGeneratorFactory { get; set; }

    internal InnerJobJobReportFactory ReportFactory { get; set; }

    internal InnerJobJobOperationFactory OperationFactory { get; set; }

    internal InnerJobJobManifestFactory ManifestFactory { get; set; }

    protected override Humidifier.S3.Job Create()
    {
        var jobResult = CreateJob();
        factoryAction?.Invoke(jobResult);

        return jobResult;
    }

    private Humidifier.S3.Job CreateJob()
    {
        var jobResult = new Humidifier.S3.Job
        {
            GivenName = InputResourceName,
        };

        return jobResult;
    }
    public override void CreateChildren(Humidifier.S3.Job result)
    {
        base.CreateChildren(result);

        result.ManifestGenerator ??= ManifestGeneratorFactory?.Build();
        result.Report ??= ReportFactory?.Build();
        result.Operation ??= OperationFactory?.Build();
        result.Manifest ??= ManifestFactory?.Build();
    }

} // End Of Class

public static class JobFactoryExtensions
{
    public static CombinedResult<JobFactory, InnerJobJobManifestGeneratorFactory> WithManifestGenerator(this JobFactory parentFactory, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null)
    {
        parentFactory.ManifestGeneratorFactory = new InnerJobJobManifestGeneratorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ManifestGeneratorFactory);
    }

    public static CombinedResult<JobFactory, InnerJobJobReportFactory> WithReport(this JobFactory parentFactory, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null)
    {
        parentFactory.ReportFactory = new InnerJobJobReportFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReportFactory);
    }

    public static CombinedResult<JobFactory, InnerJobJobOperationFactory> WithOperation(this JobFactory parentFactory, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null)
    {
        parentFactory.OperationFactory = new InnerJobJobOperationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OperationFactory);
    }

    public static CombinedResult<JobFactory, InnerJobJobManifestFactory> WithManifest(this JobFactory parentFactory, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null)
    {
        parentFactory.ManifestFactory = new InnerJobJobManifestFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ManifestFactory);
    }

    public static CombinedResult<JobFactory, T1, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1>(this CombinedResult<JobFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifestGenerator(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1>(this CombinedResult<T1, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifestGenerator(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1, T2>(this CombinedResult<JobFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestGenerator(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1, T2>(this CombinedResult<T1, JobFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestGenerator(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1, T2>(this CombinedResult<T1, T2, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestGenerator(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1, T2, T3>(this CombinedResult<JobFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestGenerator(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1, T2, T3>(this CombinedResult<T1, JobFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestGenerator(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1, T2, T3>(this CombinedResult<T1, T2, JobFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestGenerator(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestGenerator(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, T4, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1, T2, T3, T4>(this CombinedResult<JobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestGenerator(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, T4, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1, T2, T3, T4>(this CombinedResult<T1, JobFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestGenerator(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, T4, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestGenerator(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, T4, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestGenerator(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, JobFactory, InnerJobJobManifestGeneratorFactory> WithManifestGenerator<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestGenerator(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, InnerJobJobReportFactory> WithReport<T1>(this CombinedResult<JobFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, WithReport(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, InnerJobJobReportFactory> WithReport<T1>(this CombinedResult<T1, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, WithReport(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, InnerJobJobReportFactory> WithReport<T1, T2>(this CombinedResult<JobFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, InnerJobJobReportFactory> WithReport<T1, T2>(this CombinedResult<T1, JobFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, InnerJobJobReportFactory> WithReport<T1, T2>(this CombinedResult<T1, T2, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, InnerJobJobReportFactory> WithReport<T1, T2, T3>(this CombinedResult<JobFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, InnerJobJobReportFactory> WithReport<T1, T2, T3>(this CombinedResult<T1, JobFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, InnerJobJobReportFactory> WithReport<T1, T2, T3>(this CombinedResult<T1, T2, JobFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, InnerJobJobReportFactory> WithReport<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, T4, InnerJobJobReportFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<JobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, T4, InnerJobJobReportFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<T1, JobFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, T4, InnerJobJobReportFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, T4, InnerJobJobReportFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, JobFactory, InnerJobJobReportFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobReport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, InnerJobJobOperationFactory> WithOperation<T1>(this CombinedResult<JobFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, WithOperation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, InnerJobJobOperationFactory> WithOperation<T1>(this CombinedResult<T1, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, WithOperation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, InnerJobJobOperationFactory> WithOperation<T1, T2>(this CombinedResult<JobFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, InnerJobJobOperationFactory> WithOperation<T1, T2>(this CombinedResult<T1, JobFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, InnerJobJobOperationFactory> WithOperation<T1, T2>(this CombinedResult<T1, T2, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, InnerJobJobOperationFactory> WithOperation<T1, T2, T3>(this CombinedResult<JobFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, InnerJobJobOperationFactory> WithOperation<T1, T2, T3>(this CombinedResult<T1, JobFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, InnerJobJobOperationFactory> WithOperation<T1, T2, T3>(this CombinedResult<T1, T2, JobFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, InnerJobJobOperationFactory> WithOperation<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, T4, InnerJobJobOperationFactory> WithOperation<T1, T2, T3, T4>(this CombinedResult<JobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, T4, InnerJobJobOperationFactory> WithOperation<T1, T2, T3, T4>(this CombinedResult<T1, JobFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, T4, InnerJobJobOperationFactory> WithOperation<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, T4, InnerJobJobOperationFactory> WithOperation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, JobFactory, InnerJobJobOperationFactory> WithOperation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobOperation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperation(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, InnerJobJobManifestFactory> WithManifest<T1>(this CombinedResult<JobFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifest(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, InnerJobJobManifestFactory> WithManifest<T1>(this CombinedResult<T1, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifest(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, InnerJobJobManifestFactory> WithManifest<T1, T2>(this CombinedResult<JobFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifest(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, InnerJobJobManifestFactory> WithManifest<T1, T2>(this CombinedResult<T1, JobFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifest(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, InnerJobJobManifestFactory> WithManifest<T1, T2>(this CombinedResult<T1, T2, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifest(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, InnerJobJobManifestFactory> WithManifest<T1, T2, T3>(this CombinedResult<JobFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifest(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, InnerJobJobManifestFactory> WithManifest<T1, T2, T3>(this CombinedResult<T1, JobFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifest(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, InnerJobJobManifestFactory> WithManifest<T1, T2, T3>(this CombinedResult<T1, T2, JobFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifest(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, InnerJobJobManifestFactory> WithManifest<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifest(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, T4, InnerJobJobManifestFactory> WithManifest<T1, T2, T3, T4>(this CombinedResult<JobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifest(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, T4, InnerJobJobManifestFactory> WithManifest<T1, T2, T3, T4>(this CombinedResult<T1, JobFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifest(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, T4, InnerJobJobManifestFactory> WithManifest<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifest(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, T4, InnerJobJobManifestFactory> WithManifest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifest(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, JobFactory, InnerJobJobManifestFactory> WithManifest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifest> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifest(combinedResult.T5, subFactoryAction).T2);
}
