// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerBillingGroupBillingGroupPropertiesFactory(Action<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties> factoryAction = null) : SubResourceFactory<Humidifier.IoT.BillingGroupTypes.BillingGroupProperties>
{

    protected override Humidifier.IoT.BillingGroupTypes.BillingGroupProperties Create()
    {
        var billingGroupPropertiesResult = CreateBillingGroupProperties();
        factoryAction?.Invoke(billingGroupPropertiesResult);

        return billingGroupPropertiesResult;
    }

    private Humidifier.IoT.BillingGroupTypes.BillingGroupProperties CreateBillingGroupProperties()
    {
        var billingGroupPropertiesResult = new Humidifier.IoT.BillingGroupTypes.BillingGroupProperties();

        return billingGroupPropertiesResult;
    }

} // End Of Class

public static class InnerBillingGroupBillingGroupPropertiesFactoryExtensions
{
}
