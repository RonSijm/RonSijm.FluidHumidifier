// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class TableBucketFactory(string resourceName = null, Action<Humidifier.S3Tables.TableBucket> factoryAction = null) : ResourceFactory<Humidifier.S3Tables.TableBucket>(resourceName)
{

    internal InnerTableBucketUnreferencedFileRemovalFactory UnreferencedFileRemovalFactory { get; set; }

    protected override Humidifier.S3Tables.TableBucket Create()
    {
        var tableBucketResult = CreateTableBucket();
        factoryAction?.Invoke(tableBucketResult);

        return tableBucketResult;
    }

    private Humidifier.S3Tables.TableBucket CreateTableBucket()
    {
        var tableBucketResult = new Humidifier.S3Tables.TableBucket
        {
            GivenName = InputResourceName,
        };

        return tableBucketResult;
    }
    public override void CreateChildren(Humidifier.S3Tables.TableBucket result)
    {
        base.CreateChildren(result);

        result.UnreferencedFileRemoval ??= UnreferencedFileRemovalFactory?.Build();
    }

} // End Of Class

public static class TableBucketFactoryExtensions
{
    public static CombinedResult<TableBucketFactory, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval(this TableBucketFactory parentFactory, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null)
    {
        parentFactory.UnreferencedFileRemovalFactory = new InnerTableBucketUnreferencedFileRemovalFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UnreferencedFileRemovalFactory);
    }

    public static CombinedResult<TableBucketFactory, T1, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1>(this CombinedResult<TableBucketFactory, T1> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableBucketFactory, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1>(this CombinedResult<T1, TableBucketFactory> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TableBucketFactory, T1, T2, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1, T2>(this CombinedResult<TableBucketFactory, T1, T2> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableBucketFactory, T2, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1, T2>(this CombinedResult<T1, TableBucketFactory, T2> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableBucketFactory, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1, T2>(this CombinedResult<T1, T2, TableBucketFactory> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TableBucketFactory, T1, T2, T3, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1, T2, T3>(this CombinedResult<TableBucketFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableBucketFactory, T2, T3, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1, T2, T3>(this CombinedResult<T1, TableBucketFactory, T2, T3> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableBucketFactory, T3, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1, T2, T3>(this CombinedResult<T1, T2, TableBucketFactory, T3> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableBucketFactory, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1, T2, T3>(this CombinedResult<T1, T2, T3, TableBucketFactory> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TableBucketFactory, T1, T2, T3, T4, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1, T2, T3, T4>(this CombinedResult<TableBucketFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TableBucketFactory, T2, T3, T4, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1, T2, T3, T4>(this CombinedResult<T1, TableBucketFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TableBucketFactory, T3, T4, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1, T2, T3, T4>(this CombinedResult<T1, T2, TableBucketFactory, T3, T4> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TableBucketFactory, T4, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TableBucketFactory, T4> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TableBucketFactory, InnerTableBucketUnreferencedFileRemovalFactory> WithUnreferencedFileRemoval<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TableBucketFactory> combinedResult, Action<Humidifier.S3Tables.TableBucketTypes.UnreferencedFileRemoval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUnreferencedFileRemoval(combinedResult.T5, subFactoryAction));
}
