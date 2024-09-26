// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class AppFactory(string resourceName = null, Action<Humidifier.Pinpoint.App> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.App>(resourceName)
{

    protected override Humidifier.Pinpoint.App Create()
    {
        var appResult = CreateApp();
        factoryAction?.Invoke(appResult);

        return appResult;
    }

    private Humidifier.Pinpoint.App CreateApp()
    {
        var appResult = new Humidifier.Pinpoint.App
        {
            GivenName = InputResourceName,
        };

        return appResult;
    }

} // End Of Class

public static class AppFactoryExtensions
{
}
