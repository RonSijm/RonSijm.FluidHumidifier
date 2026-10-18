// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisVideo;

public class StreamFactory(string resourceName = null, Action<Humidifier.KinesisVideo.Stream> factoryAction = null) : ResourceFactory<Humidifier.KinesisVideo.Stream>(resourceName)
{

    internal InnerStreamStreamStorageConfigurationFactory StreamStorageConfigurationFactory { get; set; }

    protected override Humidifier.KinesisVideo.Stream Create()
    {
        var streamResult = CreateStream();
        factoryAction?.Invoke(streamResult);

        return streamResult;
    }

    private Humidifier.KinesisVideo.Stream CreateStream()
    {
        var streamResult = new Humidifier.KinesisVideo.Stream
        {
            GivenName = InputResourceName,
        };

        return streamResult;
    }
    public override void CreateChildren(Humidifier.KinesisVideo.Stream result)
    {
        base.CreateChildren(result);

        result.StreamStorageConfiguration ??= StreamStorageConfigurationFactory?.Build();
    }

} // End Of Class

public static class StreamFactoryExtensions
{
    public static CombinedResult<StreamFactory, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration(this StreamFactory parentFactory, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null)
    {
        parentFactory.StreamStorageConfigurationFactory = new InnerStreamStreamStorageConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StreamStorageConfigurationFactory);
    }

    public static CombinedResult<StreamFactory, T1, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1>(this CombinedResult<StreamFactory, T1> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, StreamFactory, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1>(this CombinedResult<T1, StreamFactory> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<StreamFactory, T1, T2, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1, T2>(this CombinedResult<StreamFactory, T1, T2> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, StreamFactory, T2, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1, T2>(this CombinedResult<T1, StreamFactory, T2> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, StreamFactory, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1, T2>(this CombinedResult<T1, T2, StreamFactory> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<StreamFactory, T1, T2, T3, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1, T2, T3>(this CombinedResult<StreamFactory, T1, T2, T3> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, StreamFactory, T2, T3, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1, T2, T3>(this CombinedResult<T1, StreamFactory, T2, T3> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, StreamFactory, T3, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, StreamFactory, T3> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, StreamFactory, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, StreamFactory> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<StreamFactory, T1, T2, T3, T4, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<StreamFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, StreamFactory, T2, T3, T4, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, StreamFactory, T2, T3, T4> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, StreamFactory, T3, T4, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, StreamFactory, T3, T4> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, StreamFactory, T4, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StreamFactory, T4> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, StreamFactory, InnerStreamStreamStorageConfigurationFactory> WithStreamStorageConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StreamFactory> combinedResult, Action<Humidifier.KinesisVideo.StreamTypes.StreamStorageConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamStorageConfiguration(combinedResult.T5, subFactoryAction).T2);
}
