// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerSignalCatalogAttributeFactory(Action<Humidifier.IoTFleetWise.SignalCatalogTypes.Attribute> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.SignalCatalogTypes.Attribute>
{

    protected override Humidifier.IoTFleetWise.SignalCatalogTypes.Attribute Create()
    {
        var attributeResult = CreateAttribute();
        factoryAction?.Invoke(attributeResult);

        return attributeResult;
    }

    private Humidifier.IoTFleetWise.SignalCatalogTypes.Attribute CreateAttribute()
    {
        var attributeResult = new Humidifier.IoTFleetWise.SignalCatalogTypes.Attribute();

        return attributeResult;
    }

} // End Of Class

public static class InnerSignalCatalogAttributeFactoryExtensions
{
}
