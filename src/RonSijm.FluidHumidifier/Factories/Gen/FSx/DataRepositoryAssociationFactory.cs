// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class DataRepositoryAssociationFactory(string resourceName = null, Action<Humidifier.FSx.DataRepositoryAssociation> factoryAction = null) : ResourceFactory<Humidifier.FSx.DataRepositoryAssociation>(resourceName)
{

    internal InnerDataRepositoryAssociationS3Factory S3Factory { get; set; }

    protected override Humidifier.FSx.DataRepositoryAssociation Create()
    {
        var dataRepositoryAssociationResult = CreateDataRepositoryAssociation();
        factoryAction?.Invoke(dataRepositoryAssociationResult);

        return dataRepositoryAssociationResult;
    }

    private Humidifier.FSx.DataRepositoryAssociation CreateDataRepositoryAssociation()
    {
        var dataRepositoryAssociationResult = new Humidifier.FSx.DataRepositoryAssociation
        {
            GivenName = InputResourceName,
        };

        return dataRepositoryAssociationResult;
    }
    public override void CreateChildren(Humidifier.FSx.DataRepositoryAssociation result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class DataRepositoryAssociationFactoryExtensions
{
    public static CombinedResult<DataRepositoryAssociationFactory, InnerDataRepositoryAssociationS3Factory> WithS3(this DataRepositoryAssociationFactory parentFactory, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerDataRepositoryAssociationS3Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<DataRepositoryAssociationFactory, T1, InnerDataRepositoryAssociationS3Factory> WithS3<T1>(this CombinedResult<DataRepositoryAssociationFactory, T1> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataRepositoryAssociationFactory, InnerDataRepositoryAssociationS3Factory> WithS3<T1>(this CombinedResult<T1, DataRepositoryAssociationFactory> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataRepositoryAssociationFactory, T1, T2, InnerDataRepositoryAssociationS3Factory> WithS3<T1, T2>(this CombinedResult<DataRepositoryAssociationFactory, T1, T2> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataRepositoryAssociationFactory, T2, InnerDataRepositoryAssociationS3Factory> WithS3<T1, T2>(this CombinedResult<T1, DataRepositoryAssociationFactory, T2> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataRepositoryAssociationFactory, InnerDataRepositoryAssociationS3Factory> WithS3<T1, T2>(this CombinedResult<T1, T2, DataRepositoryAssociationFactory> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataRepositoryAssociationFactory, T1, T2, T3, InnerDataRepositoryAssociationS3Factory> WithS3<T1, T2, T3>(this CombinedResult<DataRepositoryAssociationFactory, T1, T2, T3> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataRepositoryAssociationFactory, T2, T3, InnerDataRepositoryAssociationS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, DataRepositoryAssociationFactory, T2, T3> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataRepositoryAssociationFactory, T3, InnerDataRepositoryAssociationS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, DataRepositoryAssociationFactory, T3> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataRepositoryAssociationFactory, InnerDataRepositoryAssociationS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataRepositoryAssociationFactory> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataRepositoryAssociationFactory, T1, T2, T3, T4, InnerDataRepositoryAssociationS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<DataRepositoryAssociationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataRepositoryAssociationFactory, T2, T3, T4, InnerDataRepositoryAssociationS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, DataRepositoryAssociationFactory, T2, T3, T4> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataRepositoryAssociationFactory, T3, T4, InnerDataRepositoryAssociationS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataRepositoryAssociationFactory, T3, T4> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataRepositoryAssociationFactory, T4, InnerDataRepositoryAssociationS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataRepositoryAssociationFactory, T4> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataRepositoryAssociationFactory, InnerDataRepositoryAssociationS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataRepositoryAssociationFactory> combinedResult, Action<Humidifier.FSx.DataRepositoryAssociationTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction));
}
