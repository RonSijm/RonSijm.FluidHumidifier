// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerOTAUpdateFileLocationFactory(Action<Humidifier.IoT.OTAUpdateTypes.FileLocation> factoryAction = null) : SubResourceFactory<Humidifier.IoT.OTAUpdateTypes.FileLocation>
{

    internal InnerOTAUpdateStreamFactory StreamFactory { get; set; }

    internal InnerOTAUpdateS3LocationFactory S3LocationFactory { get; set; }

    protected override Humidifier.IoT.OTAUpdateTypes.FileLocation Create()
    {
        var fileLocationResult = CreateFileLocation();
        factoryAction?.Invoke(fileLocationResult);

        return fileLocationResult;
    }

    private Humidifier.IoT.OTAUpdateTypes.FileLocation CreateFileLocation()
    {
        var fileLocationResult = new Humidifier.IoT.OTAUpdateTypes.FileLocation();

        return fileLocationResult;
    }
    public override void CreateChildren(Humidifier.IoT.OTAUpdateTypes.FileLocation result)
    {
        base.CreateChildren(result);

        result.Stream ??= StreamFactory?.Build();
        result.S3Location ??= S3LocationFactory?.Build();
    }

} // End Of Class

public static class InnerOTAUpdateFileLocationFactoryExtensions
{
    public static CombinedResult<InnerOTAUpdateFileLocationFactory, InnerOTAUpdateStreamFactory> WithStream(this InnerOTAUpdateFileLocationFactory parentFactory, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null)
    {
        parentFactory.StreamFactory = new InnerOTAUpdateStreamFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StreamFactory);
    }

    public static CombinedResult<InnerOTAUpdateFileLocationFactory, InnerOTAUpdateS3LocationFactory> WithS3Location(this InnerOTAUpdateFileLocationFactory parentFactory, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.S3LocationFactory = new InnerOTAUpdateS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3LocationFactory);
    }

    public static CombinedResult<InnerOTAUpdateFileLocationFactory, T1, InnerOTAUpdateStreamFactory> WithStream<T1>(this CombinedResult<InnerOTAUpdateFileLocationFactory, T1> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, WithStream(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateFileLocationFactory, InnerOTAUpdateStreamFactory> WithStream<T1>(this CombinedResult<T1, InnerOTAUpdateFileLocationFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, WithStream(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateFileLocationFactory, T1, T2, InnerOTAUpdateStreamFactory> WithStream<T1, T2>(this CombinedResult<InnerOTAUpdateFileLocationFactory, T1, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStream(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateFileLocationFactory, T2, InnerOTAUpdateStreamFactory> WithStream<T1, T2>(this CombinedResult<T1, InnerOTAUpdateFileLocationFactory, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStream(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateFileLocationFactory, InnerOTAUpdateStreamFactory> WithStream<T1, T2>(this CombinedResult<T1, T2, InnerOTAUpdateFileLocationFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStream(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateFileLocationFactory, T1, T2, T3, InnerOTAUpdateStreamFactory> WithStream<T1, T2, T3>(this CombinedResult<InnerOTAUpdateFileLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStream(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateFileLocationFactory, T2, T3, InnerOTAUpdateStreamFactory> WithStream<T1, T2, T3>(this CombinedResult<T1, InnerOTAUpdateFileLocationFactory, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStream(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateFileLocationFactory, T3, InnerOTAUpdateStreamFactory> WithStream<T1, T2, T3>(this CombinedResult<T1, T2, InnerOTAUpdateFileLocationFactory, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStream(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateFileLocationFactory, InnerOTAUpdateStreamFactory> WithStream<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOTAUpdateFileLocationFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStream(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateFileLocationFactory, T1, T2, T3, T4, InnerOTAUpdateStreamFactory> WithStream<T1, T2, T3, T4>(this CombinedResult<InnerOTAUpdateFileLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStream(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateFileLocationFactory, T2, T3, T4, InnerOTAUpdateStreamFactory> WithStream<T1, T2, T3, T4>(this CombinedResult<T1, InnerOTAUpdateFileLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStream(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateFileLocationFactory, T3, T4, InnerOTAUpdateStreamFactory> WithStream<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOTAUpdateFileLocationFactory, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStream(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateFileLocationFactory, T4, InnerOTAUpdateStreamFactory> WithStream<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOTAUpdateFileLocationFactory, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStream(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOTAUpdateFileLocationFactory, InnerOTAUpdateStreamFactory> WithStream<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOTAUpdateFileLocationFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.Stream> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStream(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateFileLocationFactory, T1, InnerOTAUpdateS3LocationFactory> WithS3Location<T1>(this CombinedResult<InnerOTAUpdateFileLocationFactory, T1> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateFileLocationFactory, InnerOTAUpdateS3LocationFactory> WithS3Location<T1>(this CombinedResult<T1, InnerOTAUpdateFileLocationFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateFileLocationFactory, T1, T2, InnerOTAUpdateS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<InnerOTAUpdateFileLocationFactory, T1, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateFileLocationFactory, T2, InnerOTAUpdateS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, InnerOTAUpdateFileLocationFactory, T2> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateFileLocationFactory, InnerOTAUpdateS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, T2, InnerOTAUpdateFileLocationFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateFileLocationFactory, T1, T2, T3, InnerOTAUpdateS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<InnerOTAUpdateFileLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateFileLocationFactory, T2, T3, InnerOTAUpdateS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, InnerOTAUpdateFileLocationFactory, T2, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateFileLocationFactory, T3, InnerOTAUpdateS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerOTAUpdateFileLocationFactory, T3> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateFileLocationFactory, InnerOTAUpdateS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOTAUpdateFileLocationFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerOTAUpdateFileLocationFactory, T1, T2, T3, T4, InnerOTAUpdateS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<InnerOTAUpdateFileLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerOTAUpdateFileLocationFactory, T2, T3, T4, InnerOTAUpdateS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerOTAUpdateFileLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerOTAUpdateFileLocationFactory, T3, T4, InnerOTAUpdateS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOTAUpdateFileLocationFactory, T3, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerOTAUpdateFileLocationFactory, T4, InnerOTAUpdateS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOTAUpdateFileLocationFactory, T4> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerOTAUpdateFileLocationFactory, InnerOTAUpdateS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOTAUpdateFileLocationFactory> combinedResult, Action<Humidifier.IoT.OTAUpdateTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T5, subFactoryAction).T2);
}
