// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kinesis;

public class StreamFactory(string resourceName = null, Action<Humidifier.Kinesis.Stream> factoryAction = null) : ResourceFactory<Humidifier.Kinesis.Stream>(resourceName)
{

    internal InnerStreamStreamModeDetailsFactory StreamModeDetailsFactory { get; set; }

    internal InnerStreamStreamEncryptionFactory StreamEncryptionFactory { get; set; }

    protected override Humidifier.Kinesis.Stream Create()
    {
        var streamResult = CreateStream();
        factoryAction?.Invoke(streamResult);

        return streamResult;
    }

    private Humidifier.Kinesis.Stream CreateStream()
    {
        var streamResult = new Humidifier.Kinesis.Stream
        {
            GivenName = InputResourceName,
        };

        return streamResult;
    }
    public override void CreateChildren(Humidifier.Kinesis.Stream result)
    {
        base.CreateChildren(result);

        result.StreamModeDetails ??= StreamModeDetailsFactory?.Build();
        result.StreamEncryption ??= StreamEncryptionFactory?.Build();
    }

} // End Of Class

public static class StreamFactoryExtensions
{
    public static CombinedResult<StreamFactory, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails(this StreamFactory parentFactory, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null)
    {
        parentFactory.StreamModeDetailsFactory = new InnerStreamStreamModeDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StreamModeDetailsFactory);
    }

    public static CombinedResult<StreamFactory, InnerStreamStreamEncryptionFactory> WithStreamEncryption(this StreamFactory parentFactory, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null)
    {
        parentFactory.StreamEncryptionFactory = new InnerStreamStreamEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StreamEncryptionFactory);
    }

    public static CombinedResult<StreamFactory, T1, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1>(this CombinedResult<StreamFactory, T1> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamFactory, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1>(this CombinedResult<T1, StreamFactory> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StreamFactory, T1, T2, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1, T2>(this CombinedResult<StreamFactory, T1, T2> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamFactory, T2, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1, T2>(this CombinedResult<T1, StreamFactory, T2> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StreamFactory, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1, T2>(this CombinedResult<T1, T2, StreamFactory> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StreamFactory, T1, T2, T3, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1, T2, T3>(this CombinedResult<StreamFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamFactory, T2, T3, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1, T2, T3>(this CombinedResult<T1, StreamFactory, T2, T3> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StreamFactory, T3, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1, T2, T3>(this CombinedResult<T1, T2, StreamFactory, T3> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StreamFactory, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, StreamFactory> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StreamFactory, T1, T2, T3, T4, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1, T2, T3, T4>(this CombinedResult<StreamFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamFactory, T2, T3, T4, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1, T2, T3, T4>(this CombinedResult<T1, StreamFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StreamFactory, T3, T4, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, StreamFactory, T3, T4> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StreamFactory, T4, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StreamFactory, T4> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StreamFactory, InnerStreamStreamModeDetailsFactory> WithStreamModeDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StreamFactory> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamModeDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamModeDetails(combinedResult.T5, subFactoryAction));
    public static CombinedResult<StreamFactory, T1, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1>(this CombinedResult<StreamFactory, T1> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamFactory, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1>(this CombinedResult<T1, StreamFactory> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StreamFactory, T1, T2, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1, T2>(this CombinedResult<StreamFactory, T1, T2> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamFactory, T2, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1, T2>(this CombinedResult<T1, StreamFactory, T2> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StreamFactory, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1, T2>(this CombinedResult<T1, T2, StreamFactory> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StreamFactory, T1, T2, T3, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1, T2, T3>(this CombinedResult<StreamFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamFactory, T2, T3, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1, T2, T3>(this CombinedResult<T1, StreamFactory, T2, T3> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StreamFactory, T3, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1, T2, T3>(this CombinedResult<T1, T2, StreamFactory, T3> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StreamFactory, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, StreamFactory> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StreamFactory, T1, T2, T3, T4, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1, T2, T3, T4>(this CombinedResult<StreamFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamFactory, T2, T3, T4, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1, T2, T3, T4>(this CombinedResult<T1, StreamFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StreamFactory, T3, T4, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, StreamFactory, T3, T4> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StreamFactory, T4, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StreamFactory, T4> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StreamFactory, InnerStreamStreamEncryptionFactory> WithStreamEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StreamFactory> combinedResult, Action<Humidifier.Kinesis.StreamTypes.StreamEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamEncryption(combinedResult.T5, subFactoryAction));
}
