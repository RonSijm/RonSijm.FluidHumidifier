// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RefactorSpaces;

public class InnerRouteUriPathRouteInputFactory(Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> factoryAction = null) : SubResourceFactory<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput>
{

    protected override Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput Create()
    {
        var uriPathRouteInputResult = CreateUriPathRouteInput();
        factoryAction?.Invoke(uriPathRouteInputResult);

        return uriPathRouteInputResult;
    }

    private Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput CreateUriPathRouteInput()
    {
        var uriPathRouteInputResult = new Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput();

        return uriPathRouteInputResult;
    }

} // End Of Class

public static class InnerRouteUriPathRouteInputFactoryExtensions
{
}
