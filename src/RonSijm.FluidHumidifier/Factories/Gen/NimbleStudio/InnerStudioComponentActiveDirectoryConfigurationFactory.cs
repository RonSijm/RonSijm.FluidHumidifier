// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class InnerStudioComponentActiveDirectoryConfigurationFactory(Action<Humidifier.NimbleStudio.StudioComponentTypes.ActiveDirectoryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NimbleStudio.StudioComponentTypes.ActiveDirectoryConfiguration>
{

    protected override Humidifier.NimbleStudio.StudioComponentTypes.ActiveDirectoryConfiguration Create()
    {
        var activeDirectoryConfigurationResult = CreateActiveDirectoryConfiguration();
        factoryAction?.Invoke(activeDirectoryConfigurationResult);

        return activeDirectoryConfigurationResult;
    }

    private Humidifier.NimbleStudio.StudioComponentTypes.ActiveDirectoryConfiguration CreateActiveDirectoryConfiguration()
    {
        var activeDirectoryConfigurationResult = new Humidifier.NimbleStudio.StudioComponentTypes.ActiveDirectoryConfiguration();

        return activeDirectoryConfigurationResult;
    }

} // End Of Class

public static class InnerStudioComponentActiveDirectoryConfigurationFactoryExtensions
{
}
