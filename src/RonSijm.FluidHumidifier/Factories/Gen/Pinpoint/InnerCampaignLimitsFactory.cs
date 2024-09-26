// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignLimitsFactory(Action<Humidifier.Pinpoint.CampaignTypes.Limits> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.Limits>
{

    protected override Humidifier.Pinpoint.CampaignTypes.Limits Create()
    {
        var limitsResult = CreateLimits();
        factoryAction?.Invoke(limitsResult);

        return limitsResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.Limits CreateLimits()
    {
        var limitsResult = new Humidifier.Pinpoint.CampaignTypes.Limits();

        return limitsResult;
    }

} // End Of Class

public static class InnerCampaignLimitsFactoryExtensions
{
}
