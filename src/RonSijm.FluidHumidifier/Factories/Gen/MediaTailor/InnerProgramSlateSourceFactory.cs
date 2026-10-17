// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerProgramSlateSourceFactory(Action<Humidifier.MediaTailor.ProgramTypes.SlateSource> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.ProgramTypes.SlateSource>
{

    protected override Humidifier.MediaTailor.ProgramTypes.SlateSource Create()
    {
        var slateSourceResult = CreateSlateSource();
        factoryAction?.Invoke(slateSourceResult);

        return slateSourceResult;
    }

    private Humidifier.MediaTailor.ProgramTypes.SlateSource CreateSlateSource()
    {
        var slateSourceResult = new Humidifier.MediaTailor.ProgramTypes.SlateSource();

        return slateSourceResult;
    }

} // End Of Class

public static class InnerProgramSlateSourceFactoryExtensions
{
}
