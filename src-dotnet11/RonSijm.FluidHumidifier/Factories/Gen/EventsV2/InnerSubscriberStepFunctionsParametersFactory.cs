// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class InnerSubscriberStepFunctionsParametersFactory(Action<Humidifier.EventsV2.SubscriberTypes.StepFunctionsParameters> factoryAction = null) : SubResourceFactory<Humidifier.EventsV2.SubscriberTypes.StepFunctionsParameters>
{

    protected override Humidifier.EventsV2.SubscriberTypes.StepFunctionsParameters Create()
    {
        var stepFunctionsParametersResult = CreateStepFunctionsParameters();
        factoryAction?.Invoke(stepFunctionsParametersResult);

        return stepFunctionsParametersResult;
    }

    private Humidifier.EventsV2.SubscriberTypes.StepFunctionsParameters CreateStepFunctionsParameters()
    {
        var stepFunctionsParametersResult = new Humidifier.EventsV2.SubscriberTypes.StepFunctionsParameters();

        return stepFunctionsParametersResult;
    }

} // End Of Class

public static class InnerSubscriberStepFunctionsParametersFactoryExtensions
{
}
