// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class JobTemplateFactory(string resourceName = null, Action<Humidifier.EMRContainers.JobTemplate> factoryAction = null) : ResourceFactory<Humidifier.EMRContainers.JobTemplate>(resourceName)
{

    internal InnerJobTemplateJobTemplateDataFactory JobTemplateDataFactory { get; set; }

    protected override Humidifier.EMRContainers.JobTemplate Create()
    {
        var jobTemplateResult = CreateJobTemplate();
        factoryAction?.Invoke(jobTemplateResult);

        return jobTemplateResult;
    }

    private Humidifier.EMRContainers.JobTemplate CreateJobTemplate()
    {
        var jobTemplateResult = new Humidifier.EMRContainers.JobTemplate
        {
            GivenName = InputResourceName,
        };

        return jobTemplateResult;
    }
    public override void CreateChildren(Humidifier.EMRContainers.JobTemplate result)
    {
        base.CreateChildren(result);

        result.JobTemplateData ??= JobTemplateDataFactory?.Build();
    }

} // End Of Class

public static class JobTemplateFactoryExtensions
{
    public static CombinedResult<JobTemplateFactory, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData(this JobTemplateFactory parentFactory, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null)
    {
        parentFactory.JobTemplateDataFactory = new InnerJobTemplateJobTemplateDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.JobTemplateDataFactory);
    }

    public static CombinedResult<JobTemplateFactory, T1, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1>(this CombinedResult<JobTemplateFactory, T1> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobTemplateData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobTemplateFactory, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1>(this CombinedResult<T1, JobTemplateFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, WithJobTemplateData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<JobTemplateFactory, T1, T2, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1, T2>(this CombinedResult<JobTemplateFactory, T1, T2> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobTemplateData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobTemplateFactory, T2, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1, T2>(this CombinedResult<T1, JobTemplateFactory, T2> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobTemplateData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobTemplateFactory, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1, T2>(this CombinedResult<T1, T2, JobTemplateFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithJobTemplateData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<JobTemplateFactory, T1, T2, T3, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1, T2, T3>(this CombinedResult<JobTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobTemplateData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobTemplateFactory, T2, T3, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1, T2, T3>(this CombinedResult<T1, JobTemplateFactory, T2, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobTemplateData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobTemplateFactory, T3, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1, T2, T3>(this CombinedResult<T1, T2, JobTemplateFactory, T3> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobTemplateData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobTemplateFactory, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobTemplateFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithJobTemplateData(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<JobTemplateFactory, T1, T2, T3, T4, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1, T2, T3, T4>(this CombinedResult<JobTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobTemplateData(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobTemplateFactory, T2, T3, T4, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1, T2, T3, T4>(this CombinedResult<T1, JobTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobTemplateData(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobTemplateFactory, T3, T4, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobTemplateFactory, T3, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobTemplateData(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobTemplateFactory, T4, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobTemplateFactory, T4> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobTemplateData(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, JobTemplateFactory, InnerJobTemplateJobTemplateDataFactory> WithJobTemplateData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobTemplateFactory> combinedResult, Action<Humidifier.EMRContainers.JobTemplateTypes.JobTemplateData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithJobTemplateData(combinedResult.T5, subFactoryAction).T2);
}
