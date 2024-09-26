// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class InnerTableImportSourceSpecificationFactory(Action<Humidifier.DynamoDB.TableTypes.ImportSourceSpecification> factoryAction = null) : SubResourceFactory<Humidifier.DynamoDB.TableTypes.ImportSourceSpecification>
{

    internal InnerTableS3BucketSourceFactory S3BucketSourceFactory { get; set; }

    internal InnerTableInputFormatOptionsFactory InputFormatOptionsFactory { get; set; }

    protected override Humidifier.DynamoDB.TableTypes.ImportSourceSpecification Create()
    {
        var importSourceSpecificationResult = CreateImportSourceSpecification();
        factoryAction?.Invoke(importSourceSpecificationResult);

        return importSourceSpecificationResult;
    }

    private Humidifier.DynamoDB.TableTypes.ImportSourceSpecification CreateImportSourceSpecification()
    {
        var importSourceSpecificationResult = new Humidifier.DynamoDB.TableTypes.ImportSourceSpecification();

        return importSourceSpecificationResult;
    }
    public override void CreateChildren(Humidifier.DynamoDB.TableTypes.ImportSourceSpecification result)
    {
        base.CreateChildren(result);

        result.S3BucketSource ??= S3BucketSourceFactory?.Build();
        result.InputFormatOptions ??= InputFormatOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerTableImportSourceSpecificationFactoryExtensions
{
    public static CombinedResult<InnerTableImportSourceSpecificationFactory, InnerTableS3BucketSourceFactory> WithS3BucketSource(this InnerTableImportSourceSpecificationFactory parentFactory, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null)
    {
        parentFactory.S3BucketSourceFactory = new InnerTableS3BucketSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3BucketSourceFactory);
    }

    public static CombinedResult<InnerTableImportSourceSpecificationFactory, InnerTableInputFormatOptionsFactory> WithInputFormatOptions(this InnerTableImportSourceSpecificationFactory parentFactory, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null)
    {
        parentFactory.InputFormatOptionsFactory = new InnerTableInputFormatOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputFormatOptionsFactory);
    }

    public static CombinedResult<InnerTableImportSourceSpecificationFactory, T1, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1>(this CombinedResult<InnerTableImportSourceSpecificationFactory, T1> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3BucketSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableImportSourceSpecificationFactory, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1>(this CombinedResult<T1, InnerTableImportSourceSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3BucketSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableImportSourceSpecificationFactory, T1, T2, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1, T2>(this CombinedResult<InnerTableImportSourceSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableImportSourceSpecificationFactory, T2, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1, T2>(this CombinedResult<T1, InnerTableImportSourceSpecificationFactory, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableImportSourceSpecificationFactory, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1, T2>(this CombinedResult<T1, T2, InnerTableImportSourceSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableImportSourceSpecificationFactory, T1, T2, T3, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3>(this CombinedResult<InnerTableImportSourceSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableImportSourceSpecificationFactory, T2, T3, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3>(this CombinedResult<T1, InnerTableImportSourceSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableImportSourceSpecificationFactory, T3, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableImportSourceSpecificationFactory, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableImportSourceSpecificationFactory, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableImportSourceSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableImportSourceSpecificationFactory, T1, T2, T3, T4, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3, T4>(this CombinedResult<InnerTableImportSourceSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableImportSourceSpecificationFactory, T2, T3, T4, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableImportSourceSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableImportSourceSpecificationFactory, T3, T4, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableImportSourceSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableImportSourceSpecificationFactory, T4, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableImportSourceSpecificationFactory, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableImportSourceSpecificationFactory, InnerTableS3BucketSourceFactory> WithS3BucketSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableImportSourceSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.S3BucketSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSource(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTableImportSourceSpecificationFactory, T1, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1>(this CombinedResult<InnerTableImportSourceSpecificationFactory, T1> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableImportSourceSpecificationFactory, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1>(this CombinedResult<T1, InnerTableImportSourceSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTableImportSourceSpecificationFactory, T1, T2, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1, T2>(this CombinedResult<InnerTableImportSourceSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableImportSourceSpecificationFactory, T2, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1, T2>(this CombinedResult<T1, InnerTableImportSourceSpecificationFactory, T2> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableImportSourceSpecificationFactory, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1, T2>(this CombinedResult<T1, T2, InnerTableImportSourceSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTableImportSourceSpecificationFactory, T1, T2, T3, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1, T2, T3>(this CombinedResult<InnerTableImportSourceSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableImportSourceSpecificationFactory, T2, T3, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1, T2, T3>(this CombinedResult<T1, InnerTableImportSourceSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableImportSourceSpecificationFactory, T3, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerTableImportSourceSpecificationFactory, T3> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableImportSourceSpecificationFactory, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTableImportSourceSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTableImportSourceSpecificationFactory, T1, T2, T3, T4, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1, T2, T3, T4>(this CombinedResult<InnerTableImportSourceSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTableImportSourceSpecificationFactory, T2, T3, T4, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerTableImportSourceSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTableImportSourceSpecificationFactory, T3, T4, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTableImportSourceSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTableImportSourceSpecificationFactory, T4, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTableImportSourceSpecificationFactory, T4> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTableImportSourceSpecificationFactory, InnerTableInputFormatOptionsFactory> WithInputFormatOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTableImportSourceSpecificationFactory> combinedResult, Action<Humidifier.DynamoDB.TableTypes.InputFormatOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputFormatOptions(combinedResult.T5, subFactoryAction));
}
