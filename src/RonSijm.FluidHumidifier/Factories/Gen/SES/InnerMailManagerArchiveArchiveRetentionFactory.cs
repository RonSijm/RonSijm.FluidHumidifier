// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerMailManagerArchiveArchiveRetentionFactory(Action<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention> factoryAction = null) : SubResourceFactory<Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention>
{

    protected override Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention Create()
    {
        var archiveRetentionResult = CreateArchiveRetention();
        factoryAction?.Invoke(archiveRetentionResult);

        return archiveRetentionResult;
    }

    private Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention CreateArchiveRetention()
    {
        var archiveRetentionResult = new Humidifier.SES.MailManagerArchiveTypes.ArchiveRetention();

        return archiveRetentionResult;
    }

} // End Of Class

public static class InnerMailManagerArchiveArchiveRetentionFactoryExtensions
{
}
