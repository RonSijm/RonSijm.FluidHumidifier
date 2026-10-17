// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerProgramTimeSignalMessageFactory(Action<Humidifier.MediaTailor.ProgramTypes.TimeSignalMessage> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.ProgramTypes.TimeSignalMessage>
{

    protected override Humidifier.MediaTailor.ProgramTypes.TimeSignalMessage Create()
    {
        var timeSignalMessageResult = CreateTimeSignalMessage();
        factoryAction?.Invoke(timeSignalMessageResult);

        return timeSignalMessageResult;
    }

    private Humidifier.MediaTailor.ProgramTypes.TimeSignalMessage CreateTimeSignalMessage()
    {
        var timeSignalMessageResult = new Humidifier.MediaTailor.ProgramTypes.TimeSignalMessage();

        return timeSignalMessageResult;
    }

} // End Of Class

public static class InnerProgramTimeSignalMessageFactoryExtensions
{
}
