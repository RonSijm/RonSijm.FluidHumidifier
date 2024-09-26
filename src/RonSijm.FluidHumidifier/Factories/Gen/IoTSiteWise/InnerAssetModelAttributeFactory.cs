// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAssetModelAttributeFactory(Action<Humidifier.IoTSiteWise.AssetModelTypes.Attribute> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AssetModelTypes.Attribute>
{

    protected override Humidifier.IoTSiteWise.AssetModelTypes.Attribute Create()
    {
        var attributeResult = CreateAttribute();
        factoryAction?.Invoke(attributeResult);

        return attributeResult;
    }

    private Humidifier.IoTSiteWise.AssetModelTypes.Attribute CreateAttribute()
    {
        var attributeResult = new Humidifier.IoTSiteWise.AssetModelTypes.Attribute();

        return attributeResult;
    }

} // End Of Class

public static class InnerAssetModelAttributeFactoryExtensions
{
}
