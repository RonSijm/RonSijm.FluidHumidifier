// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMIncidents;

public class InnerResponsePlanIncidentTemplateFactory(Action<Humidifier.SSMIncidents.ResponsePlanTypes.IncidentTemplate> factoryAction = null) : SubResourceFactory<Humidifier.SSMIncidents.ResponsePlanTypes.IncidentTemplate>
{

    protected override Humidifier.SSMIncidents.ResponsePlanTypes.IncidentTemplate Create()
    {
        var incidentTemplateResult = CreateIncidentTemplate();
        factoryAction?.Invoke(incidentTemplateResult);

        return incidentTemplateResult;
    }

    private Humidifier.SSMIncidents.ResponsePlanTypes.IncidentTemplate CreateIncidentTemplate()
    {
        var incidentTemplateResult = new Humidifier.SSMIncidents.ResponsePlanTypes.IncidentTemplate();

        return incidentTemplateResult;
    }

} // End Of Class

public static class InnerResponsePlanIncidentTemplateFactoryExtensions
{
}
