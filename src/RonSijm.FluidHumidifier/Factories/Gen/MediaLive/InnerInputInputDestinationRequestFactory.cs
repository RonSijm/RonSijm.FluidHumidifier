// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputInputDestinationRequestFactory(Action<Humidifier.MediaLive.InputTypes.InputDestinationRequest> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.InputDestinationRequest>
{

    protected override Humidifier.MediaLive.InputTypes.InputDestinationRequest Create()
    {
        var inputDestinationRequestResult = CreateInputDestinationRequest();
        factoryAction?.Invoke(inputDestinationRequestResult);

        return inputDestinationRequestResult;
    }

    private Humidifier.MediaLive.InputTypes.InputDestinationRequest CreateInputDestinationRequest()
    {
        var inputDestinationRequestResult = new Humidifier.MediaLive.InputTypes.InputDestinationRequest();

        return inputDestinationRequestResult;
    }

} // End Of Class

public static class InnerInputInputDestinationRequestFactoryExtensions
{
}
