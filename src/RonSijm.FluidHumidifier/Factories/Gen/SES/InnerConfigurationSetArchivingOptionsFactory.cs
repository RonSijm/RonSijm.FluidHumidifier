// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetArchivingOptionsFactory(Action<Humidifier.SES.ConfigurationSetTypes.ArchivingOptions> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetTypes.ArchivingOptions>
{

    protected override Humidifier.SES.ConfigurationSetTypes.ArchivingOptions Create()
    {
        var archivingOptionsResult = CreateArchivingOptions();
        factoryAction?.Invoke(archivingOptionsResult);

        return archivingOptionsResult;
    }

    private Humidifier.SES.ConfigurationSetTypes.ArchivingOptions CreateArchivingOptions()
    {
        var archivingOptionsResult = new Humidifier.SES.ConfigurationSetTypes.ArchivingOptions();

        return archivingOptionsResult;
    }

} // End Of Class

public static class InnerConfigurationSetArchivingOptionsFactoryExtensions
{
}
