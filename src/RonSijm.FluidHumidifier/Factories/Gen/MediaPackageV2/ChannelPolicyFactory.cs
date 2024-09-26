// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class ChannelPolicyFactory(string resourceName = null, Action<Humidifier.MediaPackageV2.ChannelPolicy> factoryAction = null) : ResourceFactory<Humidifier.MediaPackageV2.ChannelPolicy>(resourceName)
{

    protected override Humidifier.MediaPackageV2.ChannelPolicy Create()
    {
        var channelPolicyResult = CreateChannelPolicy();
        factoryAction?.Invoke(channelPolicyResult);

        return channelPolicyResult;
    }

    private Humidifier.MediaPackageV2.ChannelPolicy CreateChannelPolicy()
    {
        var channelPolicyResult = new Humidifier.MediaPackageV2.ChannelPolicy
        {
            GivenName = InputResourceName,
        };

        return channelPolicyResult;
    }

} // End Of Class

public static class ChannelPolicyFactoryExtensions
{
}
