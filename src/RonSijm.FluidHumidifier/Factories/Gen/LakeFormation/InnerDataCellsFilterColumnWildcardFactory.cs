// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerDataCellsFilterColumnWildcardFactory(Action<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard>
{

    protected override Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard Create()
    {
        var columnWildcardResult = CreateColumnWildcard();
        factoryAction?.Invoke(columnWildcardResult);

        return columnWildcardResult;
    }

    private Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard CreateColumnWildcard()
    {
        var columnWildcardResult = new Humidifier.LakeFormation.DataCellsFilterTypes.ColumnWildcard();

        return columnWildcardResult;
    }

} // End Of Class

public static class InnerDataCellsFilterColumnWildcardFactoryExtensions
{
}
