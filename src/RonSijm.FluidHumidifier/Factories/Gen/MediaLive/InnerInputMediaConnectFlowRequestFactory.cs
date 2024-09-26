// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputMediaConnectFlowRequestFactory(Action<Humidifier.MediaLive.InputTypes.MediaConnectFlowRequest> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.MediaConnectFlowRequest>
{

    protected override Humidifier.MediaLive.InputTypes.MediaConnectFlowRequest Create()
    {
        var mediaConnectFlowRequestResult = CreateMediaConnectFlowRequest();
        factoryAction?.Invoke(mediaConnectFlowRequestResult);

        return mediaConnectFlowRequestResult;
    }

    private Humidifier.MediaLive.InputTypes.MediaConnectFlowRequest CreateMediaConnectFlowRequest()
    {
        var mediaConnectFlowRequestResult = new Humidifier.MediaLive.InputTypes.MediaConnectFlowRequest();

        return mediaConnectFlowRequestResult;
    }

} // End Of Class

public static class InnerInputMediaConnectFlowRequestFactoryExtensions
{
}
