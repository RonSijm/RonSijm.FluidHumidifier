// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class InnerCampaignConditionBasedCollectionSchemeFactory(Action<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedCollectionScheme> factoryAction = null) : SubResourceFactory<Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedCollectionScheme>
{

    protected override Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedCollectionScheme Create()
    {
        var conditionBasedCollectionSchemeResult = CreateConditionBasedCollectionScheme();
        factoryAction?.Invoke(conditionBasedCollectionSchemeResult);

        return conditionBasedCollectionSchemeResult;
    }

    private Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedCollectionScheme CreateConditionBasedCollectionScheme()
    {
        var conditionBasedCollectionSchemeResult = new Humidifier.IoTFleetWise.CampaignTypes.ConditionBasedCollectionScheme();

        return conditionBasedCollectionSchemeResult;
    }

} // End Of Class

public static class InnerCampaignConditionBasedCollectionSchemeFactoryExtensions
{
}
