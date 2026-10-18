// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisResourcePermissionFactory(Action<Humidifier.QuickSight.AnalysisTypes.ResourcePermission> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.ResourcePermission>
{

    protected override Humidifier.QuickSight.AnalysisTypes.ResourcePermission Create()
    {
        var resourcePermissionResult = CreateResourcePermission();
        factoryAction?.Invoke(resourcePermissionResult);

        return resourcePermissionResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.ResourcePermission CreateResourcePermission()
    {
        var resourcePermissionResult = new Humidifier.QuickSight.AnalysisTypes.ResourcePermission();

        return resourcePermissionResult;
    }

} // End Of Class

public static class InnerAnalysisResourcePermissionFactoryExtensions
{
}
