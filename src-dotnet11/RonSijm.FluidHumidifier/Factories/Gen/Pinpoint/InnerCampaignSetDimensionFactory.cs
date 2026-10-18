// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignSetDimensionFactory(Action<Humidifier.Pinpoint.CampaignTypes.SetDimension> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.SetDimension>
{

    protected override Humidifier.Pinpoint.CampaignTypes.SetDimension Create()
    {
        var setDimensionResult = CreateSetDimension();
        factoryAction?.Invoke(setDimensionResult);

        return setDimensionResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.SetDimension CreateSetDimension()
    {
        var setDimensionResult = new Humidifier.Pinpoint.CampaignTypes.SetDimension();

        return setDimensionResult;
    }

} // End Of Class

public static class InnerCampaignSetDimensionFactoryExtensions
{
}
