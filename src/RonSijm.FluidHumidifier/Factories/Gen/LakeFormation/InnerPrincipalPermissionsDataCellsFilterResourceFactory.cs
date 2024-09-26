// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPrincipalPermissionsDataCellsFilterResourceFactory(Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataCellsFilterResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PrincipalPermissionsTypes.DataCellsFilterResource>
{

    protected override Humidifier.LakeFormation.PrincipalPermissionsTypes.DataCellsFilterResource Create()
    {
        var dataCellsFilterResourceResult = CreateDataCellsFilterResource();
        factoryAction?.Invoke(dataCellsFilterResourceResult);

        return dataCellsFilterResourceResult;
    }

    private Humidifier.LakeFormation.PrincipalPermissionsTypes.DataCellsFilterResource CreateDataCellsFilterResource()
    {
        var dataCellsFilterResourceResult = new Humidifier.LakeFormation.PrincipalPermissionsTypes.DataCellsFilterResource();

        return dataCellsFilterResourceResult;
    }

} // End Of Class

public static class InnerPrincipalPermissionsDataCellsFilterResourceFactoryExtensions
{
}
