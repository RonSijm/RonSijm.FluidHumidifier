// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAssetModelEnforcedAssetModelInterfaceRelationshipFactory(Action<Humidifier.IoTSiteWise.AssetModelTypes.EnforcedAssetModelInterfaceRelationship> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AssetModelTypes.EnforcedAssetModelInterfaceRelationship>
{

    protected override Humidifier.IoTSiteWise.AssetModelTypes.EnforcedAssetModelInterfaceRelationship Create()
    {
        var enforcedAssetModelInterfaceRelationshipResult = CreateEnforcedAssetModelInterfaceRelationship();
        factoryAction?.Invoke(enforcedAssetModelInterfaceRelationshipResult);

        return enforcedAssetModelInterfaceRelationshipResult;
    }

    private Humidifier.IoTSiteWise.AssetModelTypes.EnforcedAssetModelInterfaceRelationship CreateEnforcedAssetModelInterfaceRelationship()
    {
        var enforcedAssetModelInterfaceRelationshipResult = new Humidifier.IoTSiteWise.AssetModelTypes.EnforcedAssetModelInterfaceRelationship();

        return enforcedAssetModelInterfaceRelationshipResult;
    }

} // End Of Class

public static class InnerAssetModelEnforcedAssetModelInterfaceRelationshipFactoryExtensions
{
}
