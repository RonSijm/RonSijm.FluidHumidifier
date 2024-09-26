// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerStackApplicationSettingsFactory(Action<Humidifier.AppStream.StackTypes.ApplicationSettings> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.StackTypes.ApplicationSettings>
{

    protected override Humidifier.AppStream.StackTypes.ApplicationSettings Create()
    {
        var applicationSettingsResult = CreateApplicationSettings();
        factoryAction?.Invoke(applicationSettingsResult);

        return applicationSettingsResult;
    }

    private Humidifier.AppStream.StackTypes.ApplicationSettings CreateApplicationSettings()
    {
        var applicationSettingsResult = new Humidifier.AppStream.StackTypes.ApplicationSettings();

        return applicationSettingsResult;
    }

} // End Of Class

public static class InnerStackApplicationSettingsFactoryExtensions
{
}
