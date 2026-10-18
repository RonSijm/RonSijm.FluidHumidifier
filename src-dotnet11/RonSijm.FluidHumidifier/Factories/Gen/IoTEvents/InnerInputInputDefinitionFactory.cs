// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTEvents;

public class InnerInputInputDefinitionFactory(Action<Humidifier.IoTEvents.InputTypes.InputDefinition> factoryAction = null) : SubResourceFactory<Humidifier.IoTEvents.InputTypes.InputDefinition>
{

    protected override Humidifier.IoTEvents.InputTypes.InputDefinition Create()
    {
        var inputDefinitionResult = CreateInputDefinition();
        factoryAction?.Invoke(inputDefinitionResult);

        return inputDefinitionResult;
    }

    private Humidifier.IoTEvents.InputTypes.InputDefinition CreateInputDefinition()
    {
        var inputDefinitionResult = new Humidifier.IoTEvents.InputTypes.InputDefinition();

        return inputDefinitionResult;
    }

} // End Of Class

public static class InnerInputInputDefinitionFactoryExtensions
{
}
