// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT1Click;

public class PlacementFactory(string resourceName = null, Action<Humidifier.IoT1Click.Placement> factoryAction = null) : ResourceFactory<Humidifier.IoT1Click.Placement>(resourceName)
{

    protected override Humidifier.IoT1Click.Placement Create()
    {
        var placementResult = CreatePlacement();
        factoryAction?.Invoke(placementResult);

        return placementResult;
    }

    private Humidifier.IoT1Click.Placement CreatePlacement()
    {
        var placementResult = new Humidifier.IoT1Click.Placement
        {
            GivenName = InputResourceName,
        };

        return placementResult;
    }

} // End Of Class

public static class PlacementFactoryExtensions
{
}
