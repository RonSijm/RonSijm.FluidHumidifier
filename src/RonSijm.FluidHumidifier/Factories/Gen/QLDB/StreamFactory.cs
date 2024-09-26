// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QLDB;

public class StreamFactory(string resourceName = null, Action<Humidifier.QLDB.Stream> factoryAction = null) : ResourceFactory<Humidifier.QLDB.Stream>(resourceName)
{

    internal InnerStreamKinesisConfigurationFactory KinesisConfigurationFactory { get; set; }

    protected override Humidifier.QLDB.Stream Create()
    {
        var streamResult = CreateStream();
        factoryAction?.Invoke(streamResult);

        return streamResult;
    }

    private Humidifier.QLDB.Stream CreateStream()
    {
        var streamResult = new Humidifier.QLDB.Stream
        {
            GivenName = InputResourceName,
        };

        return streamResult;
    }
    public override void CreateChildren(Humidifier.QLDB.Stream result)
    {
        base.CreateChildren(result);

        result.KinesisConfiguration ??= KinesisConfigurationFactory?.Build();
    }

} // End Of Class

public static class StreamFactoryExtensions
{
    public static CombinedResult<StreamFactory, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration(this StreamFactory parentFactory, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null)
    {
        parentFactory.KinesisConfigurationFactory = new InnerStreamKinesisConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KinesisConfigurationFactory);
    }

    public static CombinedResult<StreamFactory, T1, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1>(this CombinedResult<StreamFactory, T1> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamFactory, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1>(this CombinedResult<T1, StreamFactory> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StreamFactory, T1, T2, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1, T2>(this CombinedResult<StreamFactory, T1, T2> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamFactory, T2, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1, T2>(this CombinedResult<T1, StreamFactory, T2> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StreamFactory, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1, T2>(this CombinedResult<T1, T2, StreamFactory> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StreamFactory, T1, T2, T3, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1, T2, T3>(this CombinedResult<StreamFactory, T1, T2, T3> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamFactory, T2, T3, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1, T2, T3>(this CombinedResult<T1, StreamFactory, T2, T3> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StreamFactory, T3, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, StreamFactory, T3> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StreamFactory, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, StreamFactory> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StreamFactory, T1, T2, T3, T4, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1, T2, T3, T4>(this CombinedResult<StreamFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamFactory, T2, T3, T4, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, StreamFactory, T2, T3, T4> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StreamFactory, T3, T4, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, StreamFactory, T3, T4> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StreamFactory, T4, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StreamFactory, T4> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StreamFactory, InnerStreamKinesisConfigurationFactory> WithKinesisConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StreamFactory> combinedResult, Action<Humidifier.QLDB.StreamTypes.KinesisConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKinesisConfiguration(combinedResult.T5, subFactoryAction));
}
