// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataExchange;

public class InnerEventActionAutoExportRevisionDestinationEntryFactory(Action<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionDestinationEntry> factoryAction = null) : SubResourceFactory<Humidifier.DataExchange.EventActionTypes.AutoExportRevisionDestinationEntry>
{

    protected override Humidifier.DataExchange.EventActionTypes.AutoExportRevisionDestinationEntry Create()
    {
        var autoExportRevisionDestinationEntryResult = CreateAutoExportRevisionDestinationEntry();
        factoryAction?.Invoke(autoExportRevisionDestinationEntryResult);

        return autoExportRevisionDestinationEntryResult;
    }

    private Humidifier.DataExchange.EventActionTypes.AutoExportRevisionDestinationEntry CreateAutoExportRevisionDestinationEntry()
    {
        var autoExportRevisionDestinationEntryResult = new Humidifier.DataExchange.EventActionTypes.AutoExportRevisionDestinationEntry();

        return autoExportRevisionDestinationEntryResult;
    }

} // End Of Class

public static class InnerEventActionAutoExportRevisionDestinationEntryFactoryExtensions
{
}
