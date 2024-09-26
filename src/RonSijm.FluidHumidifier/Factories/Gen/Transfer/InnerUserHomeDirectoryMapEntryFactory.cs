// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerUserHomeDirectoryMapEntryFactory(Action<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry>
{

    protected override Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry Create()
    {
        var homeDirectoryMapEntryResult = CreateHomeDirectoryMapEntry();
        factoryAction?.Invoke(homeDirectoryMapEntryResult);

        return homeDirectoryMapEntryResult;
    }

    private Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry CreateHomeDirectoryMapEntry()
    {
        var homeDirectoryMapEntryResult = new Humidifier.Transfer.UserTypes.HomeDirectoryMapEntry();

        return homeDirectoryMapEntryResult;
    }

} // End Of Class

public static class InnerUserHomeDirectoryMapEntryFactoryExtensions
{
}
