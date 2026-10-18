// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerDatasetCsvOptionsFactory(Action<Humidifier.DataBrew.DatasetTypes.CsvOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.DatasetTypes.CsvOptions>
{

    protected override Humidifier.DataBrew.DatasetTypes.CsvOptions Create()
    {
        var csvOptionsResult = CreateCsvOptions();
        factoryAction?.Invoke(csvOptionsResult);

        return csvOptionsResult;
    }

    private Humidifier.DataBrew.DatasetTypes.CsvOptions CreateCsvOptions()
    {
        var csvOptionsResult = new Humidifier.DataBrew.DatasetTypes.CsvOptions();

        return csvOptionsResult;
    }

} // End Of Class

public static class InnerDatasetCsvOptionsFactoryExtensions
{
}
