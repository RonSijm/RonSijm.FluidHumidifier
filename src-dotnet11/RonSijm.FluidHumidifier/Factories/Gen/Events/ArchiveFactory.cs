// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class ArchiveFactory(string resourceName = null, Action<Humidifier.Events.Archive> factoryAction = null) : ResourceFactory<Humidifier.Events.Archive>(resourceName)
{

    protected override Humidifier.Events.Archive Create()
    {
        var archiveResult = CreateArchive();
        factoryAction?.Invoke(archiveResult);

        return archiveResult;
    }

    private Humidifier.Events.Archive CreateArchive()
    {
        var archiveResult = new Humidifier.Events.Archive
        {
            GivenName = InputResourceName,
        };

        return archiveResult;
    }

} // End Of Class

public static class ArchiveFactoryExtensions
{
}
