// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Wisdom;

public class InnerMessageTemplateCustomerProfileAttributesFactory(Action<Humidifier.Wisdom.MessageTemplateTypes.CustomerProfileAttributes> factoryAction = null) : SubResourceFactory<Humidifier.Wisdom.MessageTemplateTypes.CustomerProfileAttributes>
{

    protected override Humidifier.Wisdom.MessageTemplateTypes.CustomerProfileAttributes Create()
    {
        var customerProfileAttributesResult = CreateCustomerProfileAttributes();
        factoryAction?.Invoke(customerProfileAttributesResult);

        return customerProfileAttributesResult;
    }

    private Humidifier.Wisdom.MessageTemplateTypes.CustomerProfileAttributes CreateCustomerProfileAttributes()
    {
        var customerProfileAttributesResult = new Humidifier.Wisdom.MessageTemplateTypes.CustomerProfileAttributes();

        return customerProfileAttributesResult;
    }

} // End Of Class

public static class InnerMessageTemplateCustomerProfileAttributesFactoryExtensions
{
}
