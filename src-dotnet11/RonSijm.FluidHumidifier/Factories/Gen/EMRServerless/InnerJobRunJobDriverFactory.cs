// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerJobRunJobDriverFactory(Action<Humidifier.EMRServerless.JobRunTypes.JobDriver> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.JobRunTypes.JobDriver>
{

    internal InnerJobRunSparkSubmitFactory SparkSubmitFactory { get; set; }

    internal InnerJobRunHiveFactory HiveFactory { get; set; }

    protected override Humidifier.EMRServerless.JobRunTypes.JobDriver Create()
    {
        var jobDriverResult = CreateJobDriver();
        factoryAction?.Invoke(jobDriverResult);

        return jobDriverResult;
    }

    private Humidifier.EMRServerless.JobRunTypes.JobDriver CreateJobDriver()
    {
        var jobDriverResult = new Humidifier.EMRServerless.JobRunTypes.JobDriver();

        return jobDriverResult;
    }
    public override void CreateChildren(Humidifier.EMRServerless.JobRunTypes.JobDriver result)
    {
        base.CreateChildren(result);

        result.SparkSubmit ??= SparkSubmitFactory?.Build();
        result.Hive ??= HiveFactory?.Build();
    }

} // End Of Class

public static class InnerJobRunJobDriverFactoryExtensions
{
    public static CombinedResult<InnerJobRunJobDriverFactory, InnerJobRunSparkSubmitFactory> WithSparkSubmit(this InnerJobRunJobDriverFactory parentFactory, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null)
    {
        parentFactory.SparkSubmitFactory = new InnerJobRunSparkSubmitFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SparkSubmitFactory);
    }

    public static CombinedResult<InnerJobRunJobDriverFactory, InnerJobRunHiveFactory> WithHive(this InnerJobRunJobDriverFactory parentFactory, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null)
    {
        parentFactory.HiveFactory = new InnerJobRunHiveFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HiveFactory);
    }

    public static CombinedResult<InnerJobRunJobDriverFactory, T1, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1>(this CombinedResult<InnerJobRunJobDriverFactory, T1> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, WithSparkSubmit(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1>(this CombinedResult<T1, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, WithSparkSubmit(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, T2, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1, T2>(this CombinedResult<InnerJobRunJobDriverFactory, T1, T2> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSubmit(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, T2, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1, T2>(this CombinedResult<T1, InnerJobRunJobDriverFactory, T2> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSubmit(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunJobDriverFactory, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1, T2>(this CombinedResult<T1, T2, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSparkSubmit(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1, T2, T3>(this CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmit(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1, T2, T3>(this CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmit(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmit(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmit(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3, T4, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1, T2, T3, T4>(this CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmit(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3, T4, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmit(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3, T4, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmit(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory, T4, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmit(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobRunJobDriverFactory, InnerJobRunSparkSubmitFactory> WithSparkSubmit<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.SparkSubmit> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSparkSubmit(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, InnerJobRunHiveFactory> WithHive<T1>(this CombinedResult<InnerJobRunJobDriverFactory, T1> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, WithHive(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, InnerJobRunHiveFactory> WithHive<T1>(this CombinedResult<T1, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, WithHive(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, T2, InnerJobRunHiveFactory> WithHive<T1, T2>(this CombinedResult<InnerJobRunJobDriverFactory, T1, T2> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHive(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, T2, InnerJobRunHiveFactory> WithHive<T1, T2>(this CombinedResult<T1, InnerJobRunJobDriverFactory, T2> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHive(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunJobDriverFactory, InnerJobRunHiveFactory> WithHive<T1, T2>(this CombinedResult<T1, T2, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHive(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3, InnerJobRunHiveFactory> WithHive<T1, T2, T3>(this CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHive(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3, InnerJobRunHiveFactory> WithHive<T1, T2, T3>(this CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHive(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3, InnerJobRunHiveFactory> WithHive<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHive(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory, InnerJobRunHiveFactory> WithHive<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHive(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3, T4, InnerJobRunHiveFactory> WithHive<T1, T2, T3, T4>(this CombinedResult<InnerJobRunJobDriverFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHive(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3, T4, InnerJobRunHiveFactory> WithHive<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobRunJobDriverFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHive(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3, T4, InnerJobRunHiveFactory> WithHive<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobRunJobDriverFactory, T3, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHive(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory, T4, InnerJobRunHiveFactory> WithHive<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobRunJobDriverFactory, T4> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHive(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobRunJobDriverFactory, InnerJobRunHiveFactory> WithHive<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobRunJobDriverFactory> combinedResult, Action<Humidifier.EMRServerless.JobRunTypes.Hive> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHive(combinedResult.T5, subFactoryAction).T2);
}
