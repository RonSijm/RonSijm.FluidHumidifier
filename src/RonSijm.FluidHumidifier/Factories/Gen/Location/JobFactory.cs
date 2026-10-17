// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class JobFactory(string resourceName = null, Action<Humidifier.Location.Job> factoryAction = null) : ResourceFactory<Humidifier.Location.Job>(resourceName)
{

    internal InnerJobJobInputOptionsFactory InputOptionsFactory { get; set; }

    internal InnerJobJobActionOptionsFactory ActionOptionsFactory { get; set; }

    internal InnerJobJobOutputOptionsFactory OutputOptionsFactory { get; set; }

    protected override Humidifier.Location.Job Create()
    {
        var jobResult = CreateJob();
        factoryAction?.Invoke(jobResult);

        return jobResult;
    }

    private Humidifier.Location.Job CreateJob()
    {
        var jobResult = new Humidifier.Location.Job
        {
            GivenName = InputResourceName,
        };

        return jobResult;
    }
    public override void CreateChildren(Humidifier.Location.Job result)
    {
        base.CreateChildren(result);

        result.InputOptions ??= InputOptionsFactory?.Build();
        result.ActionOptions ??= ActionOptionsFactory?.Build();
        result.OutputOptions ??= OutputOptionsFactory?.Build();
    }

} // End Of Class

public static class JobFactoryExtensions
{
    public static CombinedResult<JobFactory, InnerJobJobInputOptionsFactory> WithInputOptions(this JobFactory parentFactory, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null)
    {
        parentFactory.InputOptionsFactory = new InnerJobJobInputOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputOptionsFactory);
    }

    public static CombinedResult<JobFactory, InnerJobJobActionOptionsFactory> WithActionOptions(this JobFactory parentFactory, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null)
    {
        parentFactory.ActionOptionsFactory = new InnerJobJobActionOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionOptionsFactory);
    }

    public static CombinedResult<JobFactory, InnerJobJobOutputOptionsFactory> WithOutputOptions(this JobFactory parentFactory, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null)
    {
        parentFactory.OutputOptionsFactory = new InnerJobJobOutputOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutputOptionsFactory);
    }

    public static CombinedResult<JobFactory, T1, InnerJobJobInputOptionsFactory> WithInputOptions<T1>(this CombinedResult<JobFactory, T1> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, InnerJobJobInputOptionsFactory> WithInputOptions<T1>(this CombinedResult<T1, JobFactory> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, InnerJobJobInputOptionsFactory> WithInputOptions<T1, T2>(this CombinedResult<JobFactory, T1, T2> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, InnerJobJobInputOptionsFactory> WithInputOptions<T1, T2>(this CombinedResult<T1, JobFactory, T2> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, InnerJobJobInputOptionsFactory> WithInputOptions<T1, T2>(this CombinedResult<T1, T2, JobFactory> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, InnerJobJobInputOptionsFactory> WithInputOptions<T1, T2, T3>(this CombinedResult<JobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, InnerJobJobInputOptionsFactory> WithInputOptions<T1, T2, T3>(this CombinedResult<T1, JobFactory, T2, T3> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, InnerJobJobInputOptionsFactory> WithInputOptions<T1, T2, T3>(this CombinedResult<T1, T2, JobFactory, T3> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, InnerJobJobInputOptionsFactory> WithInputOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobFactory> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, T4, InnerJobJobInputOptionsFactory> WithInputOptions<T1, T2, T3, T4>(this CombinedResult<JobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, T4, InnerJobJobInputOptionsFactory> WithInputOptions<T1, T2, T3, T4>(this CombinedResult<T1, JobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, T4, InnerJobJobInputOptionsFactory> WithInputOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobFactory, T3, T4> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, T4, InnerJobJobInputOptionsFactory> WithInputOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobFactory, T4> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, JobFactory, InnerJobJobInputOptionsFactory> WithInputOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobFactory> combinedResult, Action<Humidifier.Location.JobTypes.JobInputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputOptions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, InnerJobJobActionOptionsFactory> WithActionOptions<T1>(this CombinedResult<JobFactory, T1> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithActionOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, InnerJobJobActionOptionsFactory> WithActionOptions<T1>(this CombinedResult<T1, JobFactory> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithActionOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, InnerJobJobActionOptionsFactory> WithActionOptions<T1, T2>(this CombinedResult<JobFactory, T1, T2> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, InnerJobJobActionOptionsFactory> WithActionOptions<T1, T2>(this CombinedResult<T1, JobFactory, T2> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, InnerJobJobActionOptionsFactory> WithActionOptions<T1, T2>(this CombinedResult<T1, T2, JobFactory> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActionOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, InnerJobJobActionOptionsFactory> WithActionOptions<T1, T2, T3>(this CombinedResult<JobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, InnerJobJobActionOptionsFactory> WithActionOptions<T1, T2, T3>(this CombinedResult<T1, JobFactory, T2, T3> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, InnerJobJobActionOptionsFactory> WithActionOptions<T1, T2, T3>(this CombinedResult<T1, T2, JobFactory, T3> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, InnerJobJobActionOptionsFactory> WithActionOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobFactory> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActionOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, T4, InnerJobJobActionOptionsFactory> WithActionOptions<T1, T2, T3, T4>(this CombinedResult<JobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, T4, InnerJobJobActionOptionsFactory> WithActionOptions<T1, T2, T3, T4>(this CombinedResult<T1, JobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, T4, InnerJobJobActionOptionsFactory> WithActionOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobFactory, T3, T4> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, T4, InnerJobJobActionOptionsFactory> WithActionOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobFactory, T4> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, JobFactory, InnerJobJobActionOptionsFactory> WithActionOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobFactory> combinedResult, Action<Humidifier.Location.JobTypes.JobActionOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActionOptions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1>(this CombinedResult<JobFactory, T1> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1>(this CombinedResult<T1, JobFactory> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1, T2>(this CombinedResult<JobFactory, T1, T2> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1, T2>(this CombinedResult<T1, JobFactory, T2> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1, T2>(this CombinedResult<T1, T2, JobFactory> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1, T2, T3>(this CombinedResult<JobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1, T2, T3>(this CombinedResult<T1, JobFactory, T2, T3> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1, T2, T3>(this CombinedResult<T1, T2, JobFactory, T3> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, JobFactory> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<JobFactory, T1, T2, T3, T4, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1, T2, T3, T4>(this CombinedResult<JobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, JobFactory, T2, T3, T4, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1, T2, T3, T4>(this CombinedResult<T1, JobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, JobFactory, T3, T4, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, JobFactory, T3, T4> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, JobFactory, T4, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, JobFactory, T4> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, JobFactory, InnerJobJobOutputOptionsFactory> WithOutputOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, JobFactory> combinedResult, Action<Humidifier.Location.JobTypes.JobOutputOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputOptions(combinedResult.T5, subFactoryAction).T2);
}
