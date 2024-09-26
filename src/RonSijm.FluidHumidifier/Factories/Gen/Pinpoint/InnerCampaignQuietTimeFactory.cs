// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignQuietTimeFactory(Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.QuietTime>
{

    protected override Humidifier.Pinpoint.CampaignTypes.QuietTime Create()
    {
        var quietTimeResult = CreateQuietTime();
        factoryAction?.Invoke(quietTimeResult);

        return quietTimeResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.QuietTime CreateQuietTime()
    {
        var quietTimeResult = new Humidifier.Pinpoint.CampaignTypes.QuietTime();

        return quietTimeResult;
    }

} // End Of Class

public static class InnerCampaignQuietTimeFactoryExtensions
{
}
