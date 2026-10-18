// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerDataCellsFilterRowFilterFactory(Action<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter>
{

    protected override Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter Create()
    {
        var rowFilterResult = CreateRowFilter();
        factoryAction?.Invoke(rowFilterResult);

        return rowFilterResult;
    }

    private Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter CreateRowFilter()
    {
        var rowFilterResult = new Humidifier.LakeFormation.DataCellsFilterTypes.RowFilter();

        return rowFilterResult;
    }

} // End Of Class

public static class InnerDataCellsFilterRowFilterFactoryExtensions
{
}
