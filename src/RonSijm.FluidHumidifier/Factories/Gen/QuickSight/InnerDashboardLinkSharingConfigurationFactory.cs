// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardLinkSharingConfigurationFactory(Action<Humidifier.QuickSight.DashboardTypes.LinkSharingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.LinkSharingConfiguration>
{

    protected override Humidifier.QuickSight.DashboardTypes.LinkSharingConfiguration Create()
    {
        var linkSharingConfigurationResult = CreateLinkSharingConfiguration();
        factoryAction?.Invoke(linkSharingConfigurationResult);

        return linkSharingConfigurationResult;
    }

    private Humidifier.QuickSight.DashboardTypes.LinkSharingConfiguration CreateLinkSharingConfiguration()
    {
        var linkSharingConfigurationResult = new Humidifier.QuickSight.DashboardTypes.LinkSharingConfiguration();

        return linkSharingConfigurationResult;
    }

} // End Of Class

public static class InnerDashboardLinkSharingConfigurationFactoryExtensions
{
}
