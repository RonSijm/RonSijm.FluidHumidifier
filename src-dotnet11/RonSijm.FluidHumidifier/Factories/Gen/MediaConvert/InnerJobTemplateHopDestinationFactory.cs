// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConvert;

public class InnerJobTemplateHopDestinationFactory(Action<Humidifier.MediaConvert.JobTemplateTypes.HopDestination> factoryAction = null) : SubResourceFactory<Humidifier.MediaConvert.JobTemplateTypes.HopDestination>
{

    protected override Humidifier.MediaConvert.JobTemplateTypes.HopDestination Create()
    {
        var hopDestinationResult = CreateHopDestination();
        factoryAction?.Invoke(hopDestinationResult);

        return hopDestinationResult;
    }

    private Humidifier.MediaConvert.JobTemplateTypes.HopDestination CreateHopDestination()
    {
        var hopDestinationResult = new Humidifier.MediaConvert.JobTemplateTypes.HopDestination();

        return hopDestinationResult;
    }

} // End Of Class

public static class InnerJobTemplateHopDestinationFactoryExtensions
{
}
