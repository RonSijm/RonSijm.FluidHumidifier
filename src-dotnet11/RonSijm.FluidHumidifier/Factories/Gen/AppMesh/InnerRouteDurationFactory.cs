// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteDurationFactory(Action<Humidifier.AppMesh.RouteTypes.Duration> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.Duration>
{

    protected override Humidifier.AppMesh.RouteTypes.Duration Create()
    {
        var durationResult = CreateDuration();
        factoryAction?.Invoke(durationResult);

        return durationResult;
    }

    private Humidifier.AppMesh.RouteTypes.Duration CreateDuration()
    {
        var durationResult = new Humidifier.AppMesh.RouteTypes.Duration();

        return durationResult;
    }

} // End Of Class

public static class InnerRouteDurationFactoryExtensions
{
}
