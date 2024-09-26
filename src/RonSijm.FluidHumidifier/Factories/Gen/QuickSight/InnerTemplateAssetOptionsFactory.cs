// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerTemplateAssetOptionsFactory(Action<Humidifier.QuickSight.TemplateTypes.AssetOptions> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.TemplateTypes.AssetOptions>
{

    protected override Humidifier.QuickSight.TemplateTypes.AssetOptions Create()
    {
        var assetOptionsResult = CreateAssetOptions();
        factoryAction?.Invoke(assetOptionsResult);

        return assetOptionsResult;
    }

    private Humidifier.QuickSight.TemplateTypes.AssetOptions CreateAssetOptions()
    {
        var assetOptionsResult = new Humidifier.QuickSight.TemplateTypes.AssetOptions();

        return assetOptionsResult;
    }

} // End Of Class

public static class InnerTemplateAssetOptionsFactoryExtensions
{
}
