// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class InnerRulesetThresholdFactory(Action<Humidifier.DataBrew.RulesetTypes.Threshold> factoryAction = null) : SubResourceFactory<Humidifier.DataBrew.RulesetTypes.Threshold>
{

    protected override Humidifier.DataBrew.RulesetTypes.Threshold Create()
    {
        var thresholdResult = CreateThreshold();
        factoryAction?.Invoke(thresholdResult);

        return thresholdResult;
    }

    private Humidifier.DataBrew.RulesetTypes.Threshold CreateThreshold()
    {
        var thresholdResult = new Humidifier.DataBrew.RulesetTypes.Threshold();

        return thresholdResult;
    }

} // End Of Class

public static class InnerRulesetThresholdFactoryExtensions
{
}
