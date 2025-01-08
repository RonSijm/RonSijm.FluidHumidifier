// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerCommandCommandParameterValueFactory(Action<Humidifier.IoT.CommandTypes.CommandParameterValue> factoryAction = null) : SubResourceFactory<Humidifier.IoT.CommandTypes.CommandParameterValue>
{

    protected override Humidifier.IoT.CommandTypes.CommandParameterValue Create()
    {
        var commandParameterValueResult = CreateCommandParameterValue();
        factoryAction?.Invoke(commandParameterValueResult);

        return commandParameterValueResult;
    }

    private Humidifier.IoT.CommandTypes.CommandParameterValue CreateCommandParameterValue()
    {
        var commandParameterValueResult = new Humidifier.IoT.CommandTypes.CommandParameterValue();

        return commandParameterValueResult;
    }

} // End Of Class

public static class InnerCommandCommandParameterValueFactoryExtensions
{
}
