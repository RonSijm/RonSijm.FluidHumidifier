// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConvert;

public class InnerJobHopDestinationFactory(Action<Humidifier.MediaConvert.JobTypes.HopDestination> factoryAction = null) : SubResourceFactory<Humidifier.MediaConvert.JobTypes.HopDestination>
{

    protected override Humidifier.MediaConvert.JobTypes.HopDestination Create()
    {
        var hopDestinationResult = CreateHopDestination();
        factoryAction?.Invoke(hopDestinationResult);

        return hopDestinationResult;
    }

    private Humidifier.MediaConvert.JobTypes.HopDestination CreateHopDestination()
    {
        var hopDestinationResult = new Humidifier.MediaConvert.JobTypes.HopDestination();

        return hopDestinationResult;
    }

} // End Of Class

public static class InnerJobHopDestinationFactoryExtensions
{
}
