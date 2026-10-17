// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTrialComponentTrialComponentStatusFactory(Action<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus>
{

    protected override Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus Create()
    {
        var trialComponentStatusResult = CreateTrialComponentStatus();
        factoryAction?.Invoke(trialComponentStatusResult);

        return trialComponentStatusResult;
    }

    private Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus CreateTrialComponentStatus()
    {
        var trialComponentStatusResult = new Humidifier.SageMaker.TrialComponentTypes.TrialComponentStatus();

        return trialComponentStatusResult;
    }

} // End Of Class

public static class InnerTrialComponentTrialComponentStatusFactoryExtensions
{
}
