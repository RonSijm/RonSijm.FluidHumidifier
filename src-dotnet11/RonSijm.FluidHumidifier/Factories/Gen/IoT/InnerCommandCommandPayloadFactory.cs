// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerCommandCommandPayloadFactory(Action<Humidifier.IoT.CommandTypes.CommandPayload> factoryAction = null) : SubResourceFactory<Humidifier.IoT.CommandTypes.CommandPayload>
{

    protected override Humidifier.IoT.CommandTypes.CommandPayload Create()
    {
        var commandPayloadResult = CreateCommandPayload();
        factoryAction?.Invoke(commandPayloadResult);

        return commandPayloadResult;
    }

    private Humidifier.IoT.CommandTypes.CommandPayload CreateCommandPayload()
    {
        var commandPayloadResult = new Humidifier.IoT.CommandTypes.CommandPayload();

        return commandPayloadResult;
    }

} // End Of Class

public static class InnerCommandCommandPayloadFactoryExtensions
{
}
