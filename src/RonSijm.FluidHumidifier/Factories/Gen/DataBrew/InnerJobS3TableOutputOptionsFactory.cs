// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobS3TableOutputOptionsFactory(Action<Humidifier.DataBrew.JobTypes.S3TableOutputOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.S3TableOutputOptions>
{

    internal InnerJobS3LocationFactory LocationFactory { get; set; }

    protected override Humidifier.DataBrew.JobTypes.S3TableOutputOptions Create()
    {
        var s3TableOutputOptionsResult = CreateS3TableOutputOptions();
        factoryAction?.Invoke(s3TableOutputOptionsResult);

        return s3TableOutputOptionsResult;
    }

    private Humidifier.DataBrew.JobTypes.S3TableOutputOptions CreateS3TableOutputOptions()
    {
        var s3TableOutputOptionsResult = new Humidifier.DataBrew.JobTypes.S3TableOutputOptions();

        return s3TableOutputOptionsResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.JobTypes.S3TableOutputOptions result)
    {
        base.CreateChildren(result);

        result.Location ??= LocationFactory?.Build();
    }

} // End Of Class

public static class InnerJobS3TableOutputOptionsFactoryExtensions
{
    public static CombinedResult<InnerJobS3TableOutputOptionsFactory, InnerJobS3LocationFactory> WithLocation(this InnerJobS3TableOutputOptionsFactory parentFactory, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.LocationFactory = new InnerJobS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationFactory);
    }

    public static CombinedResult<InnerJobS3TableOutputOptionsFactory, T1, InnerJobS3LocationFactory> WithLocation<T1>(this CombinedResult<InnerJobS3TableOutputOptionsFactory, T1> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobS3TableOutputOptionsFactory, InnerJobS3LocationFactory> WithLocation<T1>(this CombinedResult<T1, InnerJobS3TableOutputOptionsFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobS3TableOutputOptionsFactory, T1, T2, InnerJobS3LocationFactory> WithLocation<T1, T2>(this CombinedResult<InnerJobS3TableOutputOptionsFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobS3TableOutputOptionsFactory, T2, InnerJobS3LocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, InnerJobS3TableOutputOptionsFactory, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobS3TableOutputOptionsFactory, InnerJobS3LocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, T2, InnerJobS3TableOutputOptionsFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobS3TableOutputOptionsFactory, T1, T2, T3, InnerJobS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<InnerJobS3TableOutputOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobS3TableOutputOptionsFactory, T2, T3, InnerJobS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, InnerJobS3TableOutputOptionsFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobS3TableOutputOptionsFactory, T3, InnerJobS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobS3TableOutputOptionsFactory, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobS3TableOutputOptionsFactory, InnerJobS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobS3TableOutputOptionsFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobS3TableOutputOptionsFactory, T1, T2, T3, T4, InnerJobS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<InnerJobS3TableOutputOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobS3TableOutputOptionsFactory, T2, T3, T4, InnerJobS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobS3TableOutputOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobS3TableOutputOptionsFactory, T3, T4, InnerJobS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobS3TableOutputOptionsFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobS3TableOutputOptionsFactory, T4, InnerJobS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobS3TableOutputOptionsFactory, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobS3TableOutputOptionsFactory, InnerJobS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobS3TableOutputOptionsFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T5, subFactoryAction));
}
