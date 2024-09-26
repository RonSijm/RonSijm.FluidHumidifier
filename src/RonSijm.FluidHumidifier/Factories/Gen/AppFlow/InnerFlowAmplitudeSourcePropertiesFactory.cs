// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowAmplitudeSourcePropertiesFactory(Action<Humidifier.AppFlow.FlowTypes.AmplitudeSourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.AmplitudeSourceProperties>
{

    protected override Humidifier.AppFlow.FlowTypes.AmplitudeSourceProperties Create()
    {
        var amplitudeSourcePropertiesResult = CreateAmplitudeSourceProperties();
        factoryAction?.Invoke(amplitudeSourcePropertiesResult);

        return amplitudeSourcePropertiesResult;
    }

    private Humidifier.AppFlow.FlowTypes.AmplitudeSourceProperties CreateAmplitudeSourceProperties()
    {
        var amplitudeSourcePropertiesResult = new Humidifier.AppFlow.FlowTypes.AmplitudeSourceProperties();

        return amplitudeSourcePropertiesResult;
    }

} // End Of Class

public static class InnerFlowAmplitudeSourcePropertiesFactoryExtensions
{
}
