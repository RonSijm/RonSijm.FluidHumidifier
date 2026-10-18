// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerVdmAttributesDashboardAttributesFactory(Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> factoryAction = null) : SubResourceFactory<Humidifier.SES.VdmAttributesTypes.DashboardAttributes>
{

    protected override Humidifier.SES.VdmAttributesTypes.DashboardAttributes Create()
    {
        var dashboardAttributesResult = CreateDashboardAttributes();
        factoryAction?.Invoke(dashboardAttributesResult);

        return dashboardAttributesResult;
    }

    private Humidifier.SES.VdmAttributesTypes.DashboardAttributes CreateDashboardAttributes()
    {
        var dashboardAttributesResult = new Humidifier.SES.VdmAttributesTypes.DashboardAttributes();

        return dashboardAttributesResult;
    }

} // End Of Class

public static class InnerVdmAttributesDashboardAttributesFactoryExtensions
{
}
