// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputInputVpcRequestFactory(Action<Humidifier.MediaLive.InputTypes.InputVpcRequest> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.InputVpcRequest>
{

    protected override Humidifier.MediaLive.InputTypes.InputVpcRequest Create()
    {
        var inputVpcRequestResult = CreateInputVpcRequest();
        factoryAction?.Invoke(inputVpcRequestResult);

        return inputVpcRequestResult;
    }

    private Humidifier.MediaLive.InputTypes.InputVpcRequest CreateInputVpcRequest()
    {
        var inputVpcRequestResult = new Humidifier.MediaLive.InputTypes.InputVpcRequest();

        return inputVpcRequestResult;
    }

} // End Of Class

public static class InnerInputInputVpcRequestFactoryExtensions
{
}
