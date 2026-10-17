// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssetAssetFileFactory(Action<Humidifier.DevOpsAgent.AssetTypes.AssetFile> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssetTypes.AssetFile>
{

    protected override Humidifier.DevOpsAgent.AssetTypes.AssetFile Create()
    {
        var assetFileResult = CreateAssetFile();
        factoryAction?.Invoke(assetFileResult);

        return assetFileResult;
    }

    private Humidifier.DevOpsAgent.AssetTypes.AssetFile CreateAssetFile()
    {
        var assetFileResult = new Humidifier.DevOpsAgent.AssetTypes.AssetFile();

        return assetFileResult;
    }

} // End Of Class

public static class InnerAssetAssetFileFactoryExtensions
{
}
