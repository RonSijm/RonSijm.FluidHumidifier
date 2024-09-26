// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointSegmentFactory(Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Segment> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointTypes.Segment>
{

    internal InnerOriginEndpointScteFactory ScteFactory { get; set; }

    internal InnerOriginEndpointEncryptionFactory EncryptionFactory { get; set; }

    protected override Humidifier.MediaPackageV2.OriginEndpointTypes.Segment Create()
    {
        var segmentResult = CreateSegment();
        factoryAction?.Invoke(segmentResult);

        return segmentResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointTypes.Segment CreateSegment()
    {
        var segmentResult = new Humidifier.MediaPackageV2.OriginEndpointTypes.Segment();

        return segmentResult;
    }
    public override void CreateChildren(Humidifier.MediaPackageV2.OriginEndpointTypes.Segment result)
    {
        base.CreateChildren(result);

        result.Scte ??= ScteFactory?.Build();
        result.Encryption ??= EncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointSegmentFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointSegmentFactory, InnerOriginEndpointScteFactory> WithScte(this InnerOriginEndpointSegmentFactory parentFactory, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null)
    {
        parentFactory.ScteFactory = new InnerOriginEndpointScteFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScteFactory);
    }

    public static CombinedResult<InnerOriginEndpointSegmentFactory, InnerOriginEndpointEncryptionFactory> WithEncryption(this InnerOriginEndpointSegmentFactory parentFactory, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null)
    {
        parentFactory.EncryptionFactory = new InnerOriginEndpointEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionFactory);
    }

    public static CombinedResult<InnerOriginEndpointSegmentFactory, T1, InnerOriginEndpointScteFactory> WithScte<T1>(this CombinedResult<InnerOriginEndpointSegmentFactory, T1> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, WithScte(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointSegmentFactory, InnerOriginEndpointScteFactory> WithScte<T1>(this CombinedResult<T1, InnerOriginEndpointSegmentFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, WithScte(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointSegmentFactory, T1, T2, InnerOriginEndpointScteFactory> WithScte<T1, T2>(this CombinedResult<InnerOriginEndpointSegmentFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScte(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointSegmentFactory, T2, InnerOriginEndpointScteFactory> WithScte<T1, T2>(this CombinedResult<T1, InnerOriginEndpointSegmentFactory, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScte(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointSegmentFactory, InnerOriginEndpointScteFactory> WithScte<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointSegmentFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScte(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointSegmentFactory, T1, T2, T3, InnerOriginEndpointScteFactory> WithScte<T1, T2, T3>(this CombinedResult<InnerOriginEndpointSegmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScte(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointSegmentFactory, T2, T3, InnerOriginEndpointScteFactory> WithScte<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointSegmentFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScte(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointSegmentFactory, T3, InnerOriginEndpointScteFactory> WithScte<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointSegmentFactory, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScte(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointSegmentFactory, InnerOriginEndpointScteFactory> WithScte<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointSegmentFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScte(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointSegmentFactory, T1, T2, T3, T4, InnerOriginEndpointScteFactory> WithScte<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointSegmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScte(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointSegmentFactory, T2, T3, T4, InnerOriginEndpointScteFactory> WithScte<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointSegmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScte(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointSegmentFactory, T3, T4, InnerOriginEndpointScteFactory> WithScte<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointSegmentFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScte(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointSegmentFactory, T4, InnerOriginEndpointScteFactory> WithScte<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointSegmentFactory, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScte(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointSegmentFactory, InnerOriginEndpointScteFactory> WithScte<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointSegmentFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Scte> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScte(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointSegmentFactory, T1, InnerOriginEndpointEncryptionFactory> WithEncryption<T1>(this CombinedResult<InnerOriginEndpointSegmentFactory, T1> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointSegmentFactory, InnerOriginEndpointEncryptionFactory> WithEncryption<T1>(this CombinedResult<T1, InnerOriginEndpointSegmentFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointSegmentFactory, T1, T2, InnerOriginEndpointEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<InnerOriginEndpointSegmentFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointSegmentFactory, T2, InnerOriginEndpointEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, InnerOriginEndpointSegmentFactory, T2> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointSegmentFactory, InnerOriginEndpointEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointSegmentFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointSegmentFactory, T1, T2, T3, InnerOriginEndpointEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<InnerOriginEndpointSegmentFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointSegmentFactory, T2, T3, InnerOriginEndpointEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointSegmentFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointSegmentFactory, T3, InnerOriginEndpointEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointSegmentFactory, T3> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointSegmentFactory, InnerOriginEndpointEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointSegmentFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointSegmentFactory, T1, T2, T3, T4, InnerOriginEndpointEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointSegmentFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointSegmentFactory, T2, T3, T4, InnerOriginEndpointEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointSegmentFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointSegmentFactory, T3, T4, InnerOriginEndpointEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointSegmentFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointSegmentFactory, T4, InnerOriginEndpointEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointSegmentFactory, T4> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointSegmentFactory, InnerOriginEndpointEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointSegmentFactory> combinedResult, Action<Humidifier.MediaPackageV2.OriginEndpointTypes.Encryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T5, subFactoryAction));
}
