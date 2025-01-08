// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerInputMulticastSettingsCreateRequestFactory(Action<Humidifier.MediaLive.InputTypes.MulticastSettingsCreateRequest> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.InputTypes.MulticastSettingsCreateRequest>
{

    protected override Humidifier.MediaLive.InputTypes.MulticastSettingsCreateRequest Create()
    {
        var multicastSettingsCreateRequestResult = CreateMulticastSettingsCreateRequest();
        factoryAction?.Invoke(multicastSettingsCreateRequestResult);

        return multicastSettingsCreateRequestResult;
    }

    private Humidifier.MediaLive.InputTypes.MulticastSettingsCreateRequest CreateMulticastSettingsCreateRequest()
    {
        var multicastSettingsCreateRequestResult = new Humidifier.MediaLive.InputTypes.MulticastSettingsCreateRequest();

        return multicastSettingsCreateRequestResult;
    }

} // End Of Class

public static class InnerInputMulticastSettingsCreateRequestFactoryExtensions
{
}
