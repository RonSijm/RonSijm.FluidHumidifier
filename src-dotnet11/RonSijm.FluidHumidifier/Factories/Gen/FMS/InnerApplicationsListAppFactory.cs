// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class InnerApplicationsListAppFactory(Action<Humidifier.FMS.ApplicationsListTypes.App> factoryAction = null) : SubResourceFactory<Humidifier.FMS.ApplicationsListTypes.App>
{

    protected override Humidifier.FMS.ApplicationsListTypes.App Create()
    {
        var appResult = CreateApp();
        factoryAction?.Invoke(appResult);

        return appResult;
    }

    private Humidifier.FMS.ApplicationsListTypes.App CreateApp()
    {
        var appResult = new Humidifier.FMS.ApplicationsListTypes.App();

        return appResult;
    }

} // End Of Class

public static class InnerApplicationsListAppFactoryExtensions
{
}
