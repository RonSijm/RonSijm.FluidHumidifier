// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerAnalysisAssetOptionsFactory(Action<Humidifier.QuickSight.AnalysisTypes.AssetOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.AnalysisTypes.AssetOptions>
{

    protected override Humidifier.QuickSight.AnalysisTypes.AssetOptions Create()
    {
        var assetOptionsResult = CreateAssetOptions();
        factoryAction?.Invoke(assetOptionsResult);

        return assetOptionsResult;
    }

    private Humidifier.QuickSight.AnalysisTypes.AssetOptions CreateAssetOptions()
    {
        var assetOptionsResult = new Humidifier.QuickSight.AnalysisTypes.AssetOptions();

        return assetOptionsResult;
    }

} // End Of Class

public static class InnerAnalysisAssetOptionsFactoryExtensions
{
}
