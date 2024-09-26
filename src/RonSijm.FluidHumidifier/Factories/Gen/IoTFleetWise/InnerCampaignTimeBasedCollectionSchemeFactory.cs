// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignTimeBasedCollectionSchemeFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedCollectionScheme> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.TimeBasedCollectionScheme>
{

    protected override Humidifier.IoTFleetWise.CampaignTypes.TimeBasedCollectionScheme Create()
    {
        var timeBasedCollectionSchemeResult = CreateTimeBasedCollectionScheme();
        factoryAction?.Invoke(timeBasedCollectionSchemeResult);

        return timeBasedCollectionSchemeResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.TimeBasedCollectionScheme CreateTimeBasedCollectionScheme()
    {
        var timeBasedCollectionSchemeResult = new Humidifier.IoTFleetWise.CampaignTypes.TimeBasedCollectionScheme();

        return timeBasedCollectionSchemeResult;
    }

} // End Of Class

public static class InnerCampaignTimeBasedCollectionSchemeFactoryExtensions
{
}
