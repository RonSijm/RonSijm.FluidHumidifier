// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class AppBundleFactory(string resourceName = null, Action<Humidifier.AppFabric.AppBundle> factoryAction = null) : ResourceFactory<Humidifier.AppFabric.AppBundle>(resourceName)
{

    protected override Humidifier.AppFabric.AppBundle Create()
    {
        var appBundleResult = CreateAppBundle();
        factoryAction?.Invoke(appBundleResult);

        return appBundleResult;
    }

    private Humidifier.AppFabric.AppBundle CreateAppBundle()
    {
        var appBundleResult = new Humidifier.AppFabric.AppBundle
        {
            GivenName = InputResourceName,
        };

        return appBundleResult;
    }

} // End Of Class

public static class AppBundleFactoryExtensions
{
}
