// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerTagAssociationDatabaseResourceFactory(Action<Humidifier.LakeFormation.TagAssociationTypes.DatabaseResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.TagAssociationTypes.DatabaseResource>
{

    protected override Humidifier.LakeFormation.TagAssociationTypes.DatabaseResource Create()
    {
        var databaseResourceResult = CreateDatabaseResource();
        factoryAction?.Invoke(databaseResourceResult);

        return databaseResourceResult;
    }

    private Humidifier.LakeFormation.TagAssociationTypes.DatabaseResource CreateDatabaseResource()
    {
        var databaseResourceResult = new Humidifier.LakeFormation.TagAssociationTypes.DatabaseResource();

        return databaseResourceResult;
    }

} // End Of Class

public static class InnerTagAssociationDatabaseResourceFactoryExtensions
{
}
