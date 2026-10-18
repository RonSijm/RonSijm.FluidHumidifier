// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAssociationPagerDutyConfigurationFactory(Action<Humidifier.DevOpsAgent.AssociationTypes.PagerDutyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AssociationTypes.PagerDutyConfiguration>
{

    protected override Humidifier.DevOpsAgent.AssociationTypes.PagerDutyConfiguration Create()
    {
        var pagerDutyConfigurationResult = CreatePagerDutyConfiguration();
        factoryAction?.Invoke(pagerDutyConfigurationResult);

        return pagerDutyConfigurationResult;
    }

    private Humidifier.DevOpsAgent.AssociationTypes.PagerDutyConfiguration CreatePagerDutyConfiguration()
    {
        var pagerDutyConfigurationResult = new Humidifier.DevOpsAgent.AssociationTypes.PagerDutyConfiguration();

        return pagerDutyConfigurationResult;
    }

} // End Of Class

public static class InnerAssociationPagerDutyConfigurationFactoryExtensions
{
}
