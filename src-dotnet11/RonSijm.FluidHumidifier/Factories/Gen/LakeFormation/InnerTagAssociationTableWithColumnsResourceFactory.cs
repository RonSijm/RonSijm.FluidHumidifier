// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerTagAssociationTableWithColumnsResourceFactory(Action<Humidifier.LakeFormation.TagAssociationTypes.TableWithColumnsResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.TagAssociationTypes.TableWithColumnsResource>
{

    protected override Humidifier.LakeFormation.TagAssociationTypes.TableWithColumnsResource Create()
    {
        var tableWithColumnsResourceResult = CreateTableWithColumnsResource();
        factoryAction?.Invoke(tableWithColumnsResourceResult);

        return tableWithColumnsResourceResult;
    }

    private Humidifier.LakeFormation.TagAssociationTypes.TableWithColumnsResource CreateTableWithColumnsResource()
    {
        var tableWithColumnsResourceResult = new Humidifier.LakeFormation.TagAssociationTypes.TableWithColumnsResource();

        return tableWithColumnsResourceResult;
    }

} // End Of Class

public static class InnerTagAssociationTableWithColumnsResourceFactoryExtensions
{
}
