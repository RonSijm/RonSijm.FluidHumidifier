// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerCsvFactory(Action<Humidifier.Logs.TransformerTypes.Csv> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.Csv>
{

    protected override Humidifier.Logs.TransformerTypes.Csv Create()
    {
        var csvResult = CreateCsv();
        factoryAction?.Invoke(csvResult);

        return csvResult;
    }

    private Humidifier.Logs.TransformerTypes.Csv CreateCsv()
    {
        var csvResult = new Humidifier.Logs.TransformerTypes.Csv();

        return csvResult;
    }

} // End Of Class

public static class InnerTransformerCsvFactoryExtensions
{
}
