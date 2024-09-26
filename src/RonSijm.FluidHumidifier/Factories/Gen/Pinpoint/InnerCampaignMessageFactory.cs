// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignMessageFactory(Action<Humidifier.Pinpoint.CampaignTypes.Message> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.Message>
{

    protected override Humidifier.Pinpoint.CampaignTypes.Message Create()
    {
        var messageResult = CreateMessage();
        factoryAction?.Invoke(messageResult);

        return messageResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.Message CreateMessage()
    {
        var messageResult = new Humidifier.Pinpoint.CampaignTypes.Message();

        return messageResult;
    }

} // End Of Class

public static class InnerCampaignMessageFactoryExtensions
{
}
