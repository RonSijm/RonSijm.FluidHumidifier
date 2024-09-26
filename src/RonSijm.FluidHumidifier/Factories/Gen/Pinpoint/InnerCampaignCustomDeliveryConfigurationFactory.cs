// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignCustomDeliveryConfigurationFactory(Action<Humidifier.Pinpoint.CampaignTypes.CustomDeliveryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.CustomDeliveryConfiguration>
{

    protected override Humidifier.Pinpoint.CampaignTypes.CustomDeliveryConfiguration Create()
    {
        var customDeliveryConfigurationResult = CreateCustomDeliveryConfiguration();
        factoryAction?.Invoke(customDeliveryConfigurationResult);

        return customDeliveryConfigurationResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.CustomDeliveryConfiguration CreateCustomDeliveryConfiguration()
    {
        var customDeliveryConfigurationResult = new Humidifier.Pinpoint.CampaignTypes.CustomDeliveryConfiguration();

        return customDeliveryConfigurationResult;
    }

} // End Of Class

public static class InnerCampaignCustomDeliveryConfigurationFactoryExtensions
{
}
