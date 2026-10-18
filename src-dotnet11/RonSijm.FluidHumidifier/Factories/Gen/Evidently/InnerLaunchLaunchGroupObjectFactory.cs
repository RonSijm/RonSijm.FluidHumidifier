// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class InnerLaunchLaunchGroupObjectFactory(Action<Humidifier.Evidently.LaunchTypes.LaunchGroupObject> factoryAction = null) : SubResourceFactory<Humidifier.Evidently.LaunchTypes.LaunchGroupObject>
{

    protected override Humidifier.Evidently.LaunchTypes.LaunchGroupObject Create()
    {
        var launchGroupObjectResult = CreateLaunchGroupObject();
        factoryAction?.Invoke(launchGroupObjectResult);

        return launchGroupObjectResult;
    }

    private Humidifier.Evidently.LaunchTypes.LaunchGroupObject CreateLaunchGroupObject()
    {
        var launchGroupObjectResult = new Humidifier.Evidently.LaunchTypes.LaunchGroupObject();

        return launchGroupObjectResult;
    }

} // End Of Class

public static class InnerLaunchLaunchGroupObjectFactoryExtensions
{
}
