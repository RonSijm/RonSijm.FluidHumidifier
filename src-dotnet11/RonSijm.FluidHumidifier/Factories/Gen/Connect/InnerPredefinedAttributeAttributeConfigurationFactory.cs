// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerPredefinedAttributeAttributeConfigurationFactory(Action<Humidifier.Connect.PredefinedAttributeTypes.AttributeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Connect.PredefinedAttributeTypes.AttributeConfiguration>
{

    protected override Humidifier.Connect.PredefinedAttributeTypes.AttributeConfiguration Create()
    {
        var attributeConfigurationResult = CreateAttributeConfiguration();
        factoryAction?.Invoke(attributeConfigurationResult);

        return attributeConfigurationResult;
    }

    private Humidifier.Connect.PredefinedAttributeTypes.AttributeConfiguration CreateAttributeConfiguration()
    {
        var attributeConfigurationResult = new Humidifier.Connect.PredefinedAttributeTypes.AttributeConfiguration();

        return attributeConfigurationResult;
    }

} // End Of Class

public static class InnerPredefinedAttributeAttributeConfigurationFactoryExtensions
{
}
