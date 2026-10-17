// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MGN;

public class ExportFactory(string resourceName = null, Action<Humidifier.MGN.Export> factoryAction = null) : ResourceFactory<Humidifier.MGN.Export>(resourceName)
{

    protected override Humidifier.MGN.Export Create()
    {
        var exportResult = CreateExport();
        factoryAction?.Invoke(exportResult);

        return exportResult;
    }

    private Humidifier.MGN.Export CreateExport()
    {
        var exportResult = new Humidifier.MGN.Export
        {
            GivenName = InputResourceName,
        };

        return exportResult;
    }

} // End Of Class

public static class ExportFactoryExtensions
{
}
