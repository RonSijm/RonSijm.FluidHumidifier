// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceIntermediateStorageFactory(Action<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.IntermediateStorage>
{

    internal InnerDataSourceS3LocationFactory S3LocationFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.IntermediateStorage Create()
    {
        var intermediateStorageResult = CreateIntermediateStorage();
        factoryAction?.Invoke(intermediateStorageResult);

        return intermediateStorageResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.IntermediateStorage CreateIntermediateStorage()
    {
        var intermediateStorageResult = new Humidifier.Bedrock.DataSourceTypes.IntermediateStorage();

        return intermediateStorageResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.IntermediateStorage result)
    {
        base.CreateChildren(result);

        result.S3Location ??= S3LocationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceIntermediateStorageFactoryExtensions
{
    public static CombinedResult<InnerDataSourceIntermediateStorageFactory, InnerDataSourceS3LocationFactory> WithS3Location(this InnerDataSourceIntermediateStorageFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null)
    {
        parentFactory.S3LocationFactory = new InnerDataSourceS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3LocationFactory);
    }

    public static CombinedResult<InnerDataSourceIntermediateStorageFactory, T1, InnerDataSourceS3LocationFactory> WithS3Location<T1>(this CombinedResult<InnerDataSourceIntermediateStorageFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceIntermediateStorageFactory, InnerDataSourceS3LocationFactory> WithS3Location<T1>(this CombinedResult<T1, InnerDataSourceIntermediateStorageFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceIntermediateStorageFactory, T1, T2, InnerDataSourceS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<InnerDataSourceIntermediateStorageFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceIntermediateStorageFactory, T2, InnerDataSourceS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, InnerDataSourceIntermediateStorageFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceIntermediateStorageFactory, InnerDataSourceS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceIntermediateStorageFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceIntermediateStorageFactory, T1, T2, T3, InnerDataSourceS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<InnerDataSourceIntermediateStorageFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceIntermediateStorageFactory, T2, T3, InnerDataSourceS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceIntermediateStorageFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceIntermediateStorageFactory, T3, InnerDataSourceS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceIntermediateStorageFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceIntermediateStorageFactory, InnerDataSourceS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceIntermediateStorageFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceIntermediateStorageFactory, T1, T2, T3, T4, InnerDataSourceS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceIntermediateStorageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceIntermediateStorageFactory, T2, T3, T4, InnerDataSourceS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceIntermediateStorageFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceIntermediateStorageFactory, T3, T4, InnerDataSourceS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceIntermediateStorageFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceIntermediateStorageFactory, T4, InnerDataSourceS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceIntermediateStorageFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceIntermediateStorageFactory, InnerDataSourceS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceIntermediateStorageFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T5, subFactoryAction));
}
