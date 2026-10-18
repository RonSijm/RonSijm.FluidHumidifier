// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeGuruReviewer;

public class RepositoryAssociationFactory(string resourceName = null, Action<Humidifier.CodeGuruReviewer.RepositoryAssociation> factoryAction = null) : ResourceFactory<Humidifier.CodeGuruReviewer.RepositoryAssociation>(resourceName)
{

    protected override Humidifier.CodeGuruReviewer.RepositoryAssociation Create()
    {
        var repositoryAssociationResult = CreateRepositoryAssociation();
        factoryAction?.Invoke(repositoryAssociationResult);

        return repositoryAssociationResult;
    }

    private Humidifier.CodeGuruReviewer.RepositoryAssociation CreateRepositoryAssociation()
    {
        var repositoryAssociationResult = new Humidifier.CodeGuruReviewer.RepositoryAssociation
        {
            GivenName = InputResourceName,
        };

        return repositoryAssociationResult;
    }

} // End Of Class

public static class RepositoryAssociationFactoryExtensions
{
}
