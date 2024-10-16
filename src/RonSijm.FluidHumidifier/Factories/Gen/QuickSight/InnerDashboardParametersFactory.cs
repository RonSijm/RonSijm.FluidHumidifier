// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardParametersFactory(Action<Humidifier.QuickSight.DashboardTypes.Parameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.Parameters>
{

    protected override Humidifier.QuickSight.DashboardTypes.Parameters Create()
    {
        var parametersResult = CreateParameters();
        factoryAction?.Invoke(parametersResult);

        return parametersResult;
    }

    private Humidifier.QuickSight.DashboardTypes.Parameters CreateParameters()
    {
        var parametersResult = new Humidifier.QuickSight.DashboardTypes.Parameters();

        return parametersResult;
    }

} // End Of Class

public static class InnerDashboardParametersFactoryExtensions
{
}
