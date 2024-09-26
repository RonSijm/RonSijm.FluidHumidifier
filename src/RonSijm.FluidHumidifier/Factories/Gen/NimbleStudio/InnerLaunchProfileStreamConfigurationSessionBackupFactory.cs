// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class InnerLaunchProfileStreamConfigurationSessionBackupFactory(Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfigurationSessionBackup> factoryAction = null) : SubResourceFactory<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfigurationSessionBackup>
{

    protected override Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfigurationSessionBackup Create()
    {
        var streamConfigurationSessionBackupResult = CreateStreamConfigurationSessionBackup();
        factoryAction?.Invoke(streamConfigurationSessionBackupResult);

        return streamConfigurationSessionBackupResult;
    }

    private Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfigurationSessionBackup CreateStreamConfigurationSessionBackup()
    {
        var streamConfigurationSessionBackupResult = new Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfigurationSessionBackup();

        return streamConfigurationSessionBackupResult;
    }

} // End Of Class

public static class InnerLaunchProfileStreamConfigurationSessionBackupFactoryExtensions
{
}
