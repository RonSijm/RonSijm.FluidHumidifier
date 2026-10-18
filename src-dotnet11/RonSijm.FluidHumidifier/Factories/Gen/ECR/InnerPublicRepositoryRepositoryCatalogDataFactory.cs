// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class InnerPublicRepositoryRepositoryCatalogDataFactory(Action<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData> factoryAction = null) : SubResourceFactory<Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData>
{

    protected override Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData Create()
    {
        var repositoryCatalogDataResult = CreateRepositoryCatalogData();
        factoryAction?.Invoke(repositoryCatalogDataResult);

        return repositoryCatalogDataResult;
    }

    private Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData CreateRepositoryCatalogData()
    {
        var repositoryCatalogDataResult = new Humidifier.ECR.PublicRepositoryTypes.RepositoryCatalogData();

        return repositoryCatalogDataResult;
    }

} // End Of Class

public static class InnerPublicRepositoryRepositoryCatalogDataFactoryExtensions
{
}
