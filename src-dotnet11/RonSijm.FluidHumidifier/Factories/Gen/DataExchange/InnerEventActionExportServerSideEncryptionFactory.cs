// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataExchange;

public class InnerEventActionExportServerSideEncryptionFactory(Action<Humidifier.DataExchange.EventActionTypes.ExportServerSideEncryption> factoryAction = null) : SubResourceFactory<Humidifier.DataExchange.EventActionTypes.ExportServerSideEncryption>
{

    protected override Humidifier.DataExchange.EventActionTypes.ExportServerSideEncryption Create()
    {
        var exportServerSideEncryptionResult = CreateExportServerSideEncryption();
        factoryAction?.Invoke(exportServerSideEncryptionResult);

        return exportServerSideEncryptionResult;
    }

    private Humidifier.DataExchange.EventActionTypes.ExportServerSideEncryption CreateExportServerSideEncryption()
    {
        var exportServerSideEncryptionResult = new Humidifier.DataExchange.EventActionTypes.ExportServerSideEncryption();

        return exportServerSideEncryptionResult;
    }

} // End Of Class

public static class InnerEventActionExportServerSideEncryptionFactoryExtensions
{
}
