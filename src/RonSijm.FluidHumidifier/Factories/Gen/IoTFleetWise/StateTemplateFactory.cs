// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTFleetWise;

public class StateTemplateFactory(string resourceName = null, Action<Humidifier.IoTFleetWise.StateTemplate> factoryAction = null) : ResourceFactory<Humidifier.IoTFleetWise.StateTemplate>(resourceName)
{

    protected override Humidifier.IoTFleetWise.StateTemplate Create()
    {
        var stateTemplateResult = CreateStateTemplate();
        factoryAction?.Invoke(stateTemplateResult);

        return stateTemplateResult;
    }

    private Humidifier.IoTFleetWise.StateTemplate CreateStateTemplate()
    {
        var stateTemplateResult = new Humidifier.IoTFleetWise.StateTemplate
        {
            GivenName = InputResourceName,
        };

        return stateTemplateResult;
    }

} // End Of Class

public static class StateTemplateFactoryExtensions
{
}
