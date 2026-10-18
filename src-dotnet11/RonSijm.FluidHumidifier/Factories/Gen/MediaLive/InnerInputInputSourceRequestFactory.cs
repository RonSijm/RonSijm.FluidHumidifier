// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputInputSourceRequestFactory(Action<Humidifier.MediaLive.InputTypes.InputSourceRequest> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.InputSourceRequest>
{

    protected override Humidifier.MediaLive.InputTypes.InputSourceRequest Create()
    {
        var inputSourceRequestResult = CreateInputSourceRequest();
        factoryAction?.Invoke(inputSourceRequestResult);

        return inputSourceRequestResult;
    }

    private Humidifier.MediaLive.InputTypes.InputSourceRequest CreateInputSourceRequest()
    {
        var inputSourceRequestResult = new Humidifier.MediaLive.InputTypes.InputSourceRequest();

        return inputSourceRequestResult;
    }

} // End Of Class

public static class InnerInputInputSourceRequestFactoryExtensions
{
}
