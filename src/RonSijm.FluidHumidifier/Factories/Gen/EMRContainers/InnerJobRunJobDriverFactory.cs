// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobRunJobDriverFactory(Action<Humidifier.EMRContainers.JobRunTypes.JobDriver> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobRunTypes.JobDriver>
{

    internal InnerJobRunSparkSqlJobDriverFactory SparkSqlJobDriverFactory { get; set; }

    internal InnerJobRunSparkSubmitJobDriverFactory SparkSubmitJobDriverFactory { get; set; }

    protected override Humidifier.EMRContainers.JobRunTypes.JobDriver Create()
    {
        var jobDriverResult = CreateJobDriver();
        factoryAction?.Invoke(jobDriverResult);

        return jobDriverResult;
    }

    private Humidifier.EMRContainers.JobRunTypes.JobDriver CreateJobDriver()
    {
        var jobDriverResult = new Humidifier.EMRContainers.JobRunTypes.JobDriver();

        return jobDriverResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.JobRunTypes.JobDriver result)
    {
        base.CreateChildren(result);

        result.SparkSqlJobDriver ??= SparkSqlJobDriverFactory?.Build();
        result.SparkSubmitJobDriver ??= SparkSubmitJobDriverFactory?.Build();
    }

} // End Of Class

public static class InnerJobRunJobDriverFactoryExtensions
{
    public static CombinedResult<InnerJobRunJobDriverFactory, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver(this InnerJobRunJobDriverFactory parentFactory, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null)
    {
        parentFactory.SparkSqlJobDriverFactory = new InnerJobRunSparkSqlJobDriverFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SparkSqlJobDriverFactory);
    }

    public static CombinedResult<InnerJobRunJobDriverFactory, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver(this InnerJobRunJobDriverFactory parentFactory, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null)
    {
        parentFactory.SparkSubmitJobDriverFactory = new InnerJobRunSparkSubmitJobDriverFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SparkSubmitJobDriverFactory);
    }

    public static CombinedResult<InnerJobRunJobDriverFactory, T1, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1>(this CombinedResult<InnerJobRunJobDriverFactory, T1> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1>(this CombinedResult<T1, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, T2, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2>(this CombinedResult<InnerJobRunJobDriverFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, T2, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2>(this CombinedResult<T1, InnerJobRunJobDriverFactory, T2> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunJobDriverFactory, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2>(this CombinedResult<T1, T2, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3>(this CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3>(this CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3, T4, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3, T4>(this CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3, T4, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3, T4, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory, T4, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory, T4> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobRunJobDriverFactory, InnerJobRunSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1>(this CombinedResult<InnerJobRunJobDriverFactory, T1> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1>(this CombinedResult<T1, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, T2, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2>(this CombinedResult<InnerJobRunJobDriverFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, T2, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2>(this CombinedResult<T1, InnerJobRunJobDriverFactory, T2> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunJobDriverFactory, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2>(this CombinedResult<T1, T2, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3>(this CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3>(this CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3, T4, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3, T4>(this CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3, T4, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3, T4, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory, T4, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory, T4> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobRunJobDriverFactory, InnerJobRunSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobRunTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T5, subFactoryAction).T2);
}
