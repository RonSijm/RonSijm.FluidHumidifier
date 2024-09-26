// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerDatasetExcelOptionsFactory(Action<Humidifier.DataBrew.DatasetTypes.ExcelOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.DatasetTypes.ExcelOptions>
{

    protected override Humidifier.DataBrew.DatasetTypes.ExcelOptions Create()
    {
        var excelOptionsResult = CreateExcelOptions();
        factoryAction?.Invoke(excelOptionsResult);

        return excelOptionsResult;
    }

    private Humidifier.DataBrew.DatasetTypes.ExcelOptions CreateExcelOptions()
    {
        var excelOptionsResult = new Humidifier.DataBrew.DatasetTypes.ExcelOptions();

        return excelOptionsResult;
    }

} // End Of Class

public static class InnerDatasetExcelOptionsFactoryExtensions
{
}
