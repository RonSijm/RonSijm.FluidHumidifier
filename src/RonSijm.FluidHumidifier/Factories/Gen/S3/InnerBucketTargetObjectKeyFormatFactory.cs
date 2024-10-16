// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketTargetObjectKeyFormatFactory(Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.TargetObjectKeyFormat>
{

    internal InnerBucketPartitionedPrefixFactory PartitionedPrefixFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.TargetObjectKeyFormat Create()
    {
        var targetObjectKeyFormatResult = CreateTargetObjectKeyFormat();
        factoryAction?.Invoke(targetObjectKeyFormatResult);

        return targetObjectKeyFormatResult;
    }

    private Humidifier.S3.BucketTypes.TargetObjectKeyFormat CreateTargetObjectKeyFormat()
    {
        var targetObjectKeyFormatResult = new Humidifier.S3.BucketTypes.TargetObjectKeyFormat();

        return targetObjectKeyFormatResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.TargetObjectKeyFormat result)
    {
        base.CreateChildren(result);

        result.PartitionedPrefix ??= PartitionedPrefixFactory?.Build();
    }

} // End Of Class

public static class InnerBucketTargetObjectKeyFormatFactoryExtensions
{
    public static CombinedResult<InnerBucketTargetObjectKeyFormatFactory, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix(this InnerBucketTargetObjectKeyFormatFactory parentFactory, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null)
    {
        parentFactory.PartitionedPrefixFactory = new InnerBucketPartitionedPrefixFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PartitionedPrefixFactory);
    }

    public static CombinedResult<InnerBucketTargetObjectKeyFormatFactory, T1, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1>(this CombinedResult<InnerBucketTargetObjectKeyFormatFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketTargetObjectKeyFormatFactory, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1>(this CombinedResult<T1, InnerBucketTargetObjectKeyFormatFactory> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBucketTargetObjectKeyFormatFactory, T1, T2, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1, T2>(this CombinedResult<InnerBucketTargetObjectKeyFormatFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketTargetObjectKeyFormatFactory, T2, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1, T2>(this CombinedResult<T1, InnerBucketTargetObjectKeyFormatFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketTargetObjectKeyFormatFactory, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1, T2>(this CombinedResult<T1, T2, InnerBucketTargetObjectKeyFormatFactory> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBucketTargetObjectKeyFormatFactory, T1, T2, T3, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1, T2, T3>(this CombinedResult<InnerBucketTargetObjectKeyFormatFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketTargetObjectKeyFormatFactory, T2, T3, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1, T2, T3>(this CombinedResult<T1, InnerBucketTargetObjectKeyFormatFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketTargetObjectKeyFormatFactory, T3, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketTargetObjectKeyFormatFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketTargetObjectKeyFormatFactory, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketTargetObjectKeyFormatFactory> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBucketTargetObjectKeyFormatFactory, T1, T2, T3, T4, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1, T2, T3, T4>(this CombinedResult<InnerBucketTargetObjectKeyFormatFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketTargetObjectKeyFormatFactory, T2, T3, T4, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketTargetObjectKeyFormatFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketTargetObjectKeyFormatFactory, T3, T4, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketTargetObjectKeyFormatFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketTargetObjectKeyFormatFactory, T4, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketTargetObjectKeyFormatFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBucketTargetObjectKeyFormatFactory, InnerBucketPartitionedPrefixFactory> WithPartitionedPrefix<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketTargetObjectKeyFormatFactory> combinedResult, Action<Humidifier.S3.BucketTypes.PartitionedPrefix> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPartitionedPrefix(combinedResult.T5, subFactoryAction));
}
