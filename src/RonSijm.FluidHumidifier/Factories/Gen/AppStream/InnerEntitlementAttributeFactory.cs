// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerEntitlementAttributeFactory(Action<Humidifier.AppStream.EntitlementTypes.Attribute> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.EntitlementTypes.Attribute>
{

    protected override Humidifier.AppStream.EntitlementTypes.Attribute Create()
    {
        var attributeResult = CreateAttribute();
        factoryAction?.Invoke(attributeResult);

        return attributeResult;
    }

    private Humidifier.AppStream.EntitlementTypes.Attribute CreateAttribute()
    {
        var attributeResult = new Humidifier.AppStream.EntitlementTypes.Attribute();

        return attributeResult;
    }

} // End Of Class

public static class InnerEntitlementAttributeFactoryExtensions
{
}
