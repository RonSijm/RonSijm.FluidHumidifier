// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobOutputFactory(Action<Humidifier.DataBrew.JobTypes.Output> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.Output>
{

    internal InnerJobOutputFormatOptionsFactory FormatOptionsFactory { get; set; }

    internal InnerJobS3LocationFactory LocationFactory { get; set; }

    protected override Humidifier.DataBrew.JobTypes.Output Create()
    {
        var outputResult = CreateOutput();
        factoryAction?.Invoke(outputResult);

        return outputResult;
    }

    private Humidifier.DataBrew.JobTypes.Output CreateOutput()
    {
        var outputResult = new Humidifier.DataBrew.JobTypes.Output();

        return outputResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.JobTypes.Output result)
    {
        base.CreateChildren(result);

        result.FormatOptions ??= FormatOptionsFactory?.Build();
        result.Location ??= LocationFactory?.Build();
    }

} // End Of Class

public static class InnerJobOutputFactoryExtensions
{
    public static CombinedResult<InnerJobOutputFactory, InnerJobOutputFormatOptionsFactory> WithFormatOptions(this InnerJobOutputFactory parentFactory, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null)
    {
        parentFactory.FormatOptionsFactory = new InnerJobOutputFormatOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FormatOptionsFactory);
    }

    public static CombinedResult<InnerJobOutputFactory, InnerJobS3LocationFactory> WithLocation(this InnerJobOutputFactory parentFactory, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.LocationFactory = new InnerJobS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationFactory);
    }

    public static CombinedResult<InnerJobOutputFactory, T1, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1>(this CombinedResult<InnerJobOutputFactory, T1> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobOutputFactory, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1>(this CombinedResult<T1, InnerJobOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobOutputFactory, T1, T2, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1, T2>(this CombinedResult<InnerJobOutputFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobOutputFactory, T2, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1, T2>(this CombinedResult<T1, InnerJobOutputFactory, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobOutputFactory, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1, T2>(this CombinedResult<T1, T2, InnerJobOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobOutputFactory, T1, T2, T3, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<InnerJobOutputFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobOutputFactory, T2, T3, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<T1, InnerJobOutputFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobOutputFactory, T3, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobOutputFactory, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobOutputFactory, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobOutputFactory, T1, T2, T3, T4, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<InnerJobOutputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobOutputFactory, T2, T3, T4, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobOutputFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobOutputFactory, T3, T4, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobOutputFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobOutputFactory, T4, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobOutputFactory, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobOutputFactory, InnerJobOutputFormatOptionsFactory> WithFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.OutputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormatOptions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerJobOutputFactory, T1, InnerJobS3LocationFactory> WithLocation<T1>(this CombinedResult<InnerJobOutputFactory, T1> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobOutputFactory, InnerJobS3LocationFactory> WithLocation<T1>(this CombinedResult<T1, InnerJobOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobOutputFactory, T1, T2, InnerJobS3LocationFactory> WithLocation<T1, T2>(this CombinedResult<InnerJobOutputFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobOutputFactory, T2, InnerJobS3LocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, InnerJobOutputFactory, T2> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobOutputFactory, InnerJobS3LocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, T2, InnerJobOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobOutputFactory, T1, T2, T3, InnerJobS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<InnerJobOutputFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobOutputFactory, T2, T3, InnerJobS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, InnerJobOutputFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobOutputFactory, T3, InnerJobS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobOutputFactory, T3> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobOutputFactory, InnerJobS3LocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobOutputFactory, T1, T2, T3, T4, InnerJobS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<InnerJobOutputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobOutputFactory, T2, T3, T4, InnerJobS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobOutputFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobOutputFactory, T3, T4, InnerJobS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobOutputFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobOutputFactory, T4, InnerJobS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobOutputFactory, T4> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobOutputFactory, InnerJobS3LocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobOutputFactory> combinedResult, Action<Humidifier.DataBrew.JobTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T5, subFactoryAction));
}
