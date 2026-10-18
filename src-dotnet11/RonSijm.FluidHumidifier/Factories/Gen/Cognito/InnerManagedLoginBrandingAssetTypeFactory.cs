// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cognito;

public class InnerManagedLoginBrandingAssetTypeFactory(Action<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType> factoryAction = null) : SubResourceFactory<Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType>
{

    protected override Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType Create()
    {
        var assetTypeResult = CreateAssetType();
        factoryAction?.Invoke(assetTypeResult);

        return assetTypeResult;
    }

    private Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType CreateAssetType()
    {
        var assetTypeResult = new Humidifier.Cognito.ManagedLoginBrandingTypes.AssetType();

        return assetTypeResult;
    }

} // End Of Class

public static class InnerManagedLoginBrandingAssetTypeFactoryExtensions
{
}
