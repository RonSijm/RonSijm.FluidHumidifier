// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputMediaConnectFlowFactory(Action<Humidifier.MediaLive.InputTypes.MediaConnectFlow> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.MediaConnectFlow>
{

    protected override Humidifier.MediaLive.InputTypes.MediaConnectFlow Create()
    {
        var mediaConnectFlowResult = CreateMediaConnectFlow();
        factoryAction?.Invoke(mediaConnectFlowResult);

        return mediaConnectFlowResult;
    }

    private Humidifier.MediaLive.InputTypes.MediaConnectFlow CreateMediaConnectFlow()
    {
        var mediaConnectFlowResult = new Humidifier.MediaLive.InputTypes.MediaConnectFlow();

        return mediaConnectFlowResult;
    }

} // End Of Class

public static class InnerInputMediaConnectFlowFactoryExtensions
{
}
