// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class ChannelPolicyFactory(string resourceName = null, Action<Humidifier.MediaTailor.ChannelPolicy> factoryAction = null) : ResourceFactory<Humidifier.MediaTailor.ChannelPolicy>(resourceName)
{

    protected override Humidifier.MediaTailor.ChannelPolicy Create()
    {
        var channelPolicyResult = CreateChannelPolicy();
        factoryAction?.Invoke(channelPolicyResult);

        return channelPolicyResult;
    }

    private Humidifier.MediaTailor.ChannelPolicy CreateChannelPolicy()
    {
        var channelPolicyResult = new Humidifier.MediaTailor.ChannelPolicy
        {
            GivenName = InputResourceName,
        };

        return channelPolicyResult;
    }

} // End Of Class

public static class ChannelPolicyFactoryExtensions
{
}
