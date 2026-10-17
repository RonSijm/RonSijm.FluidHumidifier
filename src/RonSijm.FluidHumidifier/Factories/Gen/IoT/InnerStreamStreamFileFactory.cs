// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerStreamStreamFileFactory(Action<Humidifier.IoT.StreamTypes.StreamFile> factoryAction = null) : SubResourceFactory<Humidifier.IoT.StreamTypes.StreamFile>
{

    internal InnerStreamS3LocationFactory S3LocationFactory { get; set; }

    protected override Humidifier.IoT.StreamTypes.StreamFile Create()
    {
        var streamFileResult = CreateStreamFile();
        factoryAction?.Invoke(streamFileResult);

        return streamFileResult;
    }

    private Humidifier.IoT.StreamTypes.StreamFile CreateStreamFile()
    {
        var streamFileResult = new Humidifier.IoT.StreamTypes.StreamFile();

        return streamFileResult;
    }
    public override void CreateChildren(Humidifier.IoT.StreamTypes.StreamFile result)
    {
        base.CreateChildren(result);

        result.S3Location ??= S3LocationFactory?.Build();
    }

} // End Of Class

public static class InnerStreamStreamFileFactoryExtensions
{
    public static CombinedResult<InnerStreamStreamFileFactory, InnerStreamS3LocationFactory> WithS3Location(this InnerStreamStreamFileFactory parentFactory, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.S3LocationFactory = new InnerStreamS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3LocationFactory);
    }

    public static CombinedResult<InnerStreamStreamFileFactory, T1, InnerStreamS3LocationFactory> WithS3Location<T1>(this CombinedResult<InnerStreamStreamFileFactory, T1> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStreamStreamFileFactory, InnerStreamS3LocationFactory> WithS3Location<T1>(this CombinedResult<T1, InnerStreamStreamFileFactory> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerStreamStreamFileFactory, T1, T2, InnerStreamS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<InnerStreamStreamFileFactory, T1, T2> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStreamStreamFileFactory, T2, InnerStreamS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, InnerStreamStreamFileFactory, T2> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStreamStreamFileFactory, InnerStreamS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, T2, InnerStreamStreamFileFactory> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerStreamStreamFileFactory, T1, T2, T3, InnerStreamS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<InnerStreamStreamFileFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStreamStreamFileFactory, T2, T3, InnerStreamS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, InnerStreamStreamFileFactory, T2, T3> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStreamStreamFileFactory, T3, InnerStreamS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerStreamStreamFileFactory, T3> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerStreamStreamFileFactory, InnerStreamS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStreamStreamFileFactory> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerStreamStreamFileFactory, T1, T2, T3, T4, InnerStreamS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<InnerStreamStreamFileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerStreamStreamFileFactory, T2, T3, T4, InnerStreamS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerStreamStreamFileFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerStreamStreamFileFactory, T3, T4, InnerStreamS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStreamStreamFileFactory, T3, T4> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerStreamStreamFileFactory, T4, InnerStreamS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStreamStreamFileFactory, T4> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerStreamStreamFileFactory, InnerStreamS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStreamStreamFileFactory> combinedResult, Action<Humidifier.IoT.StreamTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T5, subFactoryAction).T2);
}
