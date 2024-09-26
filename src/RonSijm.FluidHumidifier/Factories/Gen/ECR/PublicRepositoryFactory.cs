// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class PublicRepositoryFactory(string resourceName = null, Action<Humidifier.ECR.PublicRepository> factoryAction = null) : ResourceFactory<Humidifier.ECR.PublicRepository>(resourceName)
{

    internal InnerPublicRepositoryRepositoryCatalogDataFactory RepositoryCatalogDataFactory { get; set; }

    protected override Humidifier.ECR.PublicRepository Create()
    {
        var publicRepositoryResult = CreatePublicRepository();
        factoryAction?.Invoke(publicRepositoryResult);

        return publicRepositoryResult;
    }

    private Humidifier.ECR.PublicRepository CreatePublicRepository()
    {
        var publicRepositoryResult = new Humidifier.ECR.PublicRepository
        {
            GivenName = InputResourceName,
        };

        return publicRepositoryResult;
    }
    public override void CreateChildren(Humidifier.ECR.PublicRepository result)
    {
        base.CreateChildren(result);

        result.RepositoryCatalogData ??= RepositoryCatalogDataFactory?.Build();
    }

} // End Of Class

public static class PublicRepositoryFactoryExtensions
{
    public static CombinedResult<PublicRepositoryFactory, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData(this PublicRepositoryFactory parentFactory, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null)
    {
        parentFactory.RepositoryCatalogDataFactory = new InnerPublicRepositoryRepositoryCatalogDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RepositoryCatalogDataFactory);
    }

    public static CombinedResult<PublicRepositoryFactory, T1, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1>(this CombinedResult<PublicRepositoryFactory, T1> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PublicRepositoryFactory, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1>(this CombinedResult<T1, PublicRepositoryFactory> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PublicRepositoryFactory, T1, T2, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1, T2>(this CombinedResult<PublicRepositoryFactory, T1, T2> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PublicRepositoryFactory, T2, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1, T2>(this CombinedResult<T1, PublicRepositoryFactory, T2> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PublicRepositoryFactory, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1, T2>(this CombinedResult<T1, T2, PublicRepositoryFactory> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PublicRepositoryFactory, T1, T2, T3, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1, T2, T3>(this CombinedResult<PublicRepositoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PublicRepositoryFactory, T2, T3, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1, T2, T3>(this CombinedResult<T1, PublicRepositoryFactory, T2, T3> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PublicRepositoryFactory, T3, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1, T2, T3>(this CombinedResult<T1, T2, PublicRepositoryFactory, T3> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PublicRepositoryFactory, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1, T2, T3>(this CombinedResult<T1, T2, T3, PublicRepositoryFactory> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PublicRepositoryFactory, T1, T2, T3, T4, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1, T2, T3, T4>(this CombinedResult<PublicRepositoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PublicRepositoryFactory, T2, T3, T4, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1, T2, T3, T4>(this CombinedResult<T1, PublicRepositoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PublicRepositoryFactory, T3, T4, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1, T2, T3, T4>(this CombinedResult<T1, T2, PublicRepositoryFactory, T3, T4> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PublicRepositoryFactory, T4, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PublicRepositoryFactory, T4> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PublicRepositoryFactory, InnerPublicRepositoryRepositoryCatalogDataFactory> WithRepositoryCatalogData<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PublicRepositoryFactory> combinedResult, Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositoryCatalogData(combinedResult.T5, subFactoryAction));
}
