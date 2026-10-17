// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DynamoDB;

public class ExportFactory(string resourceName = null, Action<Humidifier.DynamoDB.Export> factoryAction = null) : ResourceFactory<Humidifier.DynamoDB.Export>(resourceName)
{

    protected override Humidifier.DynamoDB.Export Create()
    {
        var exportResult = CreateExport();
        factoryAction?.Invoke(exportResult);

        return exportResult;
    }

    private Humidifier.DynamoDB.Export CreateExport()
    {
        var exportResult = new Humidifier.DynamoDB.Export
        {
            GivenName = InputResourceName,
        };

        return exportResult;
    }

} // End Of Class

public static class ExportFactoryExtensions
{
}
