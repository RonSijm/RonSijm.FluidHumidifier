// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerProgramClipRangeFactory(Action<Humidifier.MediaTailor.ProgramTypes.ClipRange> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.ProgramTypes.ClipRange>
{

    protected override Humidifier.MediaTailor.ProgramTypes.ClipRange Create()
    {
        var clipRangeResult = CreateClipRange();
        factoryAction?.Invoke(clipRangeResult);

        return clipRangeResult;
    }

    private Humidifier.MediaTailor.ProgramTypes.ClipRange CreateClipRange()
    {
        var clipRangeResult = new Humidifier.MediaTailor.ProgramTypes.ClipRange();

        return clipRangeResult;
    }

} // End Of Class

public static class InnerProgramClipRangeFactoryExtensions
{
}
