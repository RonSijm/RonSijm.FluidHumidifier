// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerTagAssociationTableResourceFactory(Action<Humidifier.LakeFormation.TagAssociationTypes.TableResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.TagAssociationTypes.TableResource>
{

    protected override Humidifier.LakeFormation.TagAssociationTypes.TableResource Create()
    {
        var tableResourceResult = CreateTableResource();
        factoryAction?.Invoke(tableResourceResult);

        return tableResourceResult;
    }

    private Humidifier.LakeFormation.TagAssociationTypes.TableResource CreateTableResource()
    {
        var tableResourceResult = new Humidifier.LakeFormation.TagAssociationTypes.TableResource();

        return tableResourceResult;
    }

} // End Of Class

public static class InnerTagAssociationTableResourceFactoryExtensions
{
}
