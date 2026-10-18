// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerJobCsvOutputOptionsFactory(Action<Humidifier.DataBrew.JobTypes.CsvOutputOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.JobTypes.CsvOutputOptions>
{

    protected override Humidifier.DataBrew.JobTypes.CsvOutputOptions Create()
    {
        var csvOutputOptionsResult = CreateCsvOutputOptions();
        factoryAction?.Invoke(csvOutputOptionsResult);

        return csvOutputOptionsResult;
    }

    private Humidifier.DataBrew.JobTypes.CsvOutputOptions CreateCsvOutputOptions()
    {
        var csvOutputOptionsResult = new Humidifier.DataBrew.JobTypes.CsvOutputOptions();

        return csvOutputOptionsResult;
    }

} // End Of Class

public static class InnerJobCsvOutputOptionsFactoryExtensions
{
}
