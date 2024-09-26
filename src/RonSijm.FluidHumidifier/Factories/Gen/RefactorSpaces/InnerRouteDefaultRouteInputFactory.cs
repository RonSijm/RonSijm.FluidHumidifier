// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RefactorSpaces;

public class InnerRouteDefaultRouteInputFactory(Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> factoryAction = null) : SubResourceFactory<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput>
{

    protected override Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput Create()
    {
        var defaultRouteInputResult = CreateDefaultRouteInput();
        factoryAction?.Invoke(defaultRouteInputResult);

        return defaultRouteInputResult;
    }

    private Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput CreateDefaultRouteInput()
    {
        var defaultRouteInputResult = new Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput();

        return defaultRouteInputResult;
    }

} // End Of Class

public static class InnerRouteDefaultRouteInputFactoryExtensions
{
}
