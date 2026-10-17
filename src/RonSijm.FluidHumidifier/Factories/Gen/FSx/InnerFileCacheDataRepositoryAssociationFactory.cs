// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileCacheDataRepositoryAssociationFactory(Action<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation>
{

    protected override Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation Create()
    {
        var dataRepositoryAssociationResult = CreateDataRepositoryAssociation();
        factoryAction?.Invoke(dataRepositoryAssociationResult);

        return dataRepositoryAssociationResult;
    }

    private Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation CreateDataRepositoryAssociation()
    {
        var dataRepositoryAssociationResult = new Humidifier.FSx.FileCacheTypes.DataRepositoryAssociation();

        return dataRepositoryAssociationResult;
    }

} // End Of Class

public static class InnerFileCacheDataRepositoryAssociationFactoryExtensions
{
}
