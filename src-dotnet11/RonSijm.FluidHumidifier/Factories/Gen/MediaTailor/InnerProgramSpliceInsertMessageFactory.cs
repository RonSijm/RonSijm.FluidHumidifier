// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerProgramSpliceInsertMessageFactory(Action<Humidifier.MediaTailor.ProgramTypes.SpliceInsertMessage> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.ProgramTypes.SpliceInsertMessage>
{

    protected override Humidifier.MediaTailor.ProgramTypes.SpliceInsertMessage Create()
    {
        var spliceInsertMessageResult = CreateSpliceInsertMessage();
        factoryAction?.Invoke(spliceInsertMessageResult);

        return spliceInsertMessageResult;
    }

    private Humidifier.MediaTailor.ProgramTypes.SpliceInsertMessage CreateSpliceInsertMessage()
    {
        var spliceInsertMessageResult = new Humidifier.MediaTailor.ProgramTypes.SpliceInsertMessage();

        return spliceInsertMessageResult;
    }

} // End Of Class

public static class InnerProgramSpliceInsertMessageFactoryExtensions
{
}
