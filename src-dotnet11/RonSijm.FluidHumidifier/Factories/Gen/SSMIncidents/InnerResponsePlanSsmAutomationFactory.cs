// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMIncidents;

public class InnerResponsePlanSsmAutomationFactory(Action<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation> factoryAction = null) : SubResourceFactory<Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation>
{

    protected override Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation Create()
    {
        var ssmAutomationResult = CreateSsmAutomation();
        factoryAction?.Invoke(ssmAutomationResult);

        return ssmAutomationResult;
    }

    private Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation CreateSsmAutomation()
    {
        var ssmAutomationResult = new Humidifier.SSMIncidents.ResponsePlanTypes.SsmAutomation();

        return ssmAutomationResult;
    }

} // End Of Class

public static class InnerResponsePlanSsmAutomationFactoryExtensions
{
}
