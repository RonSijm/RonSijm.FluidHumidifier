// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerMessageTemplateSystemEndpointAttributesFactory(Action<Humidifier.Wisdom.MessageTemplateTypes.SystemEndpointAttributes> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.MessageTemplateTypes.SystemEndpointAttributes>
{

    protected override Humidifier.Wisdom.MessageTemplateTypes.SystemEndpointAttributes Create()
    {
        var systemEndpointAttributesResult = CreateSystemEndpointAttributes();
        factoryAction?.Invoke(systemEndpointAttributesResult);

        return systemEndpointAttributesResult;
    }

    private Humidifier.Wisdom.MessageTemplateTypes.SystemEndpointAttributes CreateSystemEndpointAttributes()
    {
        var systemEndpointAttributesResult = new Humidifier.Wisdom.MessageTemplateTypes.SystemEndpointAttributes();

        return systemEndpointAttributesResult;
    }

} // End Of Class

public static class InnerMessageTemplateSystemEndpointAttributesFactoryExtensions
{
}
