// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobTemplateJobTemplateDataFactory(Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData>
{

    internal InnerJobTemplateParametricConfigurationOverridesFactory ConfigurationOverridesFactory { get; set; }

    internal InnerJobTemplateJobDriverFactory JobDriverFactory { get; set; }

    protected override Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData Create()
    {
        var jobTemplateDataResult = CreateJobTemplateData();
        factoryAction?.Invoke(jobTemplateDataResult);

        return jobTemplateDataResult;
    }

    private Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData CreateJobTemplateData()
    {
        var jobTemplateDataResult = new Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData();

        return jobTemplateDataResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData result)
    {
        base.CreateChildren(result);

        result.ConfigurationOverrides ??= ConfigurationOverridesFactory?.Build();
        result.JobDriver ??= JobDriverFactory?.Build();
    }

} // End Of Class

public static class InnerJobTemplateJobTemplateDataFactoryExtensions
{
    public static CombinedResult<InnerJobTemplateJobTemplateDataFactory, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides(this InnerJobTemplateJobTemplateDataFactory parentFactory, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null)
    {
        parentFactory.ConfigurationOverridesFactory = new InnerJobTemplateParametricConfigurationOverridesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationOverridesFactory);
    }

    public static CombinedResult<InnerJobTemplateJobTemplateDataFactory, InnerJobTemplateJobDriverFactory> WithJobDriver(this InnerJobTemplateJobTemplateDataFactory parentFactory, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null)
    {
        parentFactory.JobDriverFactory = new InnerJobTemplateJobDriverFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JobDriverFactory);
    }

    public static CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1>(this CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1>(this CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, T2, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2>(this CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, T2, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2>(this CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, T2> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateJobTemplateDataFactory, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2>(this CombinedResult<T1, T2, InnerJobTemplateJobTemplateDataFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, T2, T3, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, T2, T3, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateJobTemplateDataFactory, T3, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobTemplateJobTemplateDataFactory, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobTemplateJobTemplateDataFactory, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobTemplateJobTemplateDataFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, T2, T3, T4, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, T2, T3, T4, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateJobTemplateDataFactory, T3, T4, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobTemplateJobTemplateDataFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobTemplateJobTemplateDataFactory, T4, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobTemplateJobTemplateDataFactory, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobTemplateJobTemplateDataFactory, InnerJobTemplateParametricConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobTemplateJobTemplateDataFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, InnerJobTemplateJobDriverFactory> WithJobDriver<T1>(this CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, InnerJobTemplateJobDriverFactory> WithJobDriver<T1>(this CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, T2, InnerJobTemplateJobDriverFactory> WithJobDriver<T1, T2>(this CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, T2, InnerJobTemplateJobDriverFactory> WithJobDriver<T1, T2>(this CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, T2> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateJobTemplateDataFactory, InnerJobTemplateJobDriverFactory> WithJobDriver<T1, T2>(this CombinedResult<T1, T2, InnerJobTemplateJobTemplateDataFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, T2, T3, InnerJobTemplateJobDriverFactory> WithJobDriver<T1, T2, T3>(this CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, T2, T3, InnerJobTemplateJobDriverFactory> WithJobDriver<T1, T2, T3>(this CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateJobTemplateDataFactory, T3, InnerJobTemplateJobDriverFactory> WithJobDriver<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobTemplateJobTemplateDataFactory, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobTemplateJobTemplateDataFactory, InnerJobTemplateJobDriverFactory> WithJobDriver<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobTemplateJobTemplateDataFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, T2, T3, T4, InnerJobTemplateJobDriverFactory> WithJobDriver<T1, T2, T3, T4>(this CombinedResult<InnerJobTemplateJobTemplateDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, T2, T3, T4, InnerJobTemplateJobDriverFactory> WithJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobTemplateJobTemplateDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobTemplateJobTemplateDataFactory, T3, T4, InnerJobTemplateJobDriverFactory> WithJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobTemplateJobTemplateDataFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobTemplateJobTemplateDataFactory, T4, InnerJobTemplateJobDriverFactory> WithJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobTemplateJobTemplateDataFactory, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobTemplateJobTemplateDataFactory, InnerJobTemplateJobDriverFactory> WithJobDriver<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobTemplateJobTemplateDataFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobDriver> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobDriver(combinedResult.T5, subFactoryAction).T2);
}
