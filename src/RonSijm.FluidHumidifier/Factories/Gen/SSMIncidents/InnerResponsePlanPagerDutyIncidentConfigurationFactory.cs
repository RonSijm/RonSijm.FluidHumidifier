// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMIncidents;

public class InnerResponsePlanPagerDutyIncidentConfigurationFactory(Action<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration>
{

    protected override Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration Create()
    {
        var pagerDutyIncidentConfigurationResult = CreatePagerDutyIncidentConfiguration();
        factoryAction?.Invoke(pagerDutyIncidentConfigurationResult);

        return pagerDutyIncidentConfigurationResult;
    }

    private Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration CreatePagerDutyIncidentConfiguration()
    {
        var pagerDutyIncidentConfigurationResult = new Humidifier.SSMIncidents.ResponsePlanTypes.PagerDutyIncidentConfiguration();

        return pagerDutyIncidentConfigurationResult;
    }

} // End Of Class

public static class InnerResponsePlanPagerDutyIncidentConfigurationFactoryExtensions
{
}
