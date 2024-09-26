// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class InnerStudioComponentSharedFileSystemConfigurationFactory(Action<Humidifier.NimbleStudio.StudioComponentTypes.SharedFileSystemConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NimbleStudio.StudioComponentTypes.SharedFileSystemConfiguration>
{

    protected override Humidifier.NimbleStudio.StudioComponentTypes.SharedFileSystemConfiguration Create()
    {
        var sharedFileSystemConfigurationResult = CreateSharedFileSystemConfiguration();
        factoryAction?.Invoke(sharedFileSystemConfigurationResult);

        return sharedFileSystemConfigurationResult;
    }

    private Humidifier.NimbleStudio.StudioComponentTypes.SharedFileSystemConfiguration CreateSharedFileSystemConfiguration()
    {
        var sharedFileSystemConfigurationResult = new Humidifier.NimbleStudio.StudioComponentTypes.SharedFileSystemConfiguration();

        return sharedFileSystemConfigurationResult;
    }

} // End Of Class

public static class InnerStudioComponentSharedFileSystemConfigurationFactoryExtensions
{
}
