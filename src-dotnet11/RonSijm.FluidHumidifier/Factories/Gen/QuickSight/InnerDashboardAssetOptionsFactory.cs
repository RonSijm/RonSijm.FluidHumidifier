// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardAssetOptionsFactory(Action<Humidifier.QuickSight.DashboardTypes.AssetOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.AssetOptions>
{

    protected override Humidifier.QuickSight.DashboardTypes.AssetOptions Create()
    {
        var assetOptionsResult = CreateAssetOptions();
        factoryAction?.Invoke(assetOptionsResult);

        return assetOptionsResult;
    }

    private Humidifier.QuickSight.DashboardTypes.AssetOptions CreateAssetOptions()
    {
        var assetOptionsResult = new Humidifier.QuickSight.DashboardTypes.AssetOptions();

        return assetOptionsResult;
    }

} // End Of Class

public static class InnerDashboardAssetOptionsFactoryExtensions
{
}
