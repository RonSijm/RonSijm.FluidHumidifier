// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobTemplateJobDriverFactory(Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobTemplateTypes.JobDriver>
{

    internal InnerJobTemplateSparkSqlJobDriverFactory SparkSqlJobDriverFactory { get; set; }

    internal InnerJobTemplateSparkSubmitJobDriverFactory SparkSubmitJobDriverFactory { get; set; }

    protected override Humidifier.EMRContainers.JobTemplateTypes.JobDriver Create()
    {
        var jobDriverResult = CreateJobDriver();
        factoryAction?.Invoke(jobDriverResult);

        return jobDriverResult;
    }

    private Humidifier.EMRContainers.JobTemplateTypes.JobDriver CreateJobDriver()
    {
        var jobDriverResult = new Humidifier.EMRContainers.JobTemplateTypes.JobDriver();

        return jobDriverResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.JobTemplateTypes.JobDriver result)
    {
        base.CreateChildren(result);

        result.SparkSqlJobDriver ??= SparkSqlJobDriverFactory?.Build();
        result.SparkSubmitJobDriver ??= SparkSubmitJobDriverFactory?.Build();
    }

} // End Of Class

public static class InnerJobTemplateJobDriverFactoryExtensions
{
    public static CombinedResult<InnerJobTemplateJobDriverFactory, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver(this InnerJobTemplateJobDriverFactory parentFactory, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null)
    {
        parentFactory.SparkSqlJobDriverFactory = new InnerJobTemplateSparkSqlJobDriverFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SparkSqlJobDriverFactory);
    }

    public static CombinedResult<InnerJobTemplateJobDriverFactory, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver(this InnerJobTemplateJobDriverFactory parentFactory, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null)
    {
        parentFactory.SparkSubmitJobDriverFactory = new InnerJobTemplateSparkSubmitJobDriverFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SparkSubmitJobDriverFactory);
    }

    public static CombinedResult<InnerJobTemplateJobDriverFactory, T1, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1>(this CombinedResult<InnerJobTemplateJobDriverFactory, T1> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobDriverFactory, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1>(this CombinedResult<T1, InnerJobTemplateJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobDriverFactory, T1, T2, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2>(this CombinedResult<InnerJobTemplateJobDriverFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobDriverFactory, T2, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2>(this CombinedResult<T1, InnerJobTemplateJobDriverFactory, T2> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateJobDriverFactory, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2>(this CombinedResult<T1, T2, InnerJobTemplateJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobDriverFactory, T1, T2, T3, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3>(this CombinedResult<InnerJobTemplateJobDriverFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobDriverFactory, T2, T3, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3>(this CombinedResult<T1, InnerJobTemplateJobDriverFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateJobDriverFactory, T3, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobTemplateJobDriverFactory, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobTemplateJobDriverFactory, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobTemplateJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobDriverFactory, T1, T2, T3, T4, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3, T4>(this CombinedResult<InnerJobTemplateJobDriverFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobDriverFactory, T2, T3, T4, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobTemplateJobDriverFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateJobDriverFactory, T3, T4, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobTemplateJobDriverFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobTemplateJobDriverFactory, T4, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobTemplateJobDriverFactory, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobTemplateJobDriverFactory, InnerJobTemplateSparkSqlJobDriverFactory> WithSparkSqlJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobTemplateJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSqlJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSqlJobDriver(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobDriverFactory, T1, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1>(this CombinedResult<InnerJobTemplateJobDriverFactory, T1> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobDriverFactory, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1>(this CombinedResult<T1, InnerJobTemplateJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobDriverFactory, T1, T2, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2>(this CombinedResult<InnerJobTemplateJobDriverFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobDriverFactory, T2, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2>(this CombinedResult<T1, InnerJobTemplateJobDriverFactory, T2> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateJobDriverFactory, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2>(this CombinedResult<T1, T2, InnerJobTemplateJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobDriverFactory, T1, T2, T3, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3>(this CombinedResult<InnerJobTemplateJobDriverFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobDriverFactory, T2, T3, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3>(this CombinedResult<T1, InnerJobTemplateJobDriverFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateJobDriverFactory, T3, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobTemplateJobDriverFactory, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobTemplateJobDriverFactory, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobTemplateJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobDriverFactory, T1, T2, T3, T4, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3, T4>(this CombinedResult<InnerJobTemplateJobDriverFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobDriverFactory, T2, T3, T4, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobTemplateJobDriverFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateJobDriverFactory, T3, T4, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobTemplateJobDriverFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobTemplateJobDriverFactory, T4, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobTemplateJobDriverFactory, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobTemplateJobDriverFactory, InnerJobTemplateSparkSubmitJobDriverFactory> WithSparkSubmitJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobTemplateJobDriverFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.SparkSubmitJobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmitJobDriver(combinedResult.T5, subFactoryAction).T2);
}
