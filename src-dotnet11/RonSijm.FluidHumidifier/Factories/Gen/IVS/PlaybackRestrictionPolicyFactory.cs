// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class PlaybackRestrictionPolicyFactory(string resourceName = null, Action<Humidifier.IVS.PlaybackRestrictionPolicy> factoryAction = null) : ResourceFactory<Humidifier.IVS.PlaybackRestrictionPolicy>(resourceName)
{

    protected override Humidifier.IVS.PlaybackRestrictionPolicy Create()
    {
        var playbackRestrictionPolicyResult = CreatePlaybackRestrictionPolicy();
        factoryAction?.Invoke(playbackRestrictionPolicyResult);

        return playbackRestrictionPolicyResult;
    }

    private Humidifier.IVS.PlaybackRestrictionPolicy CreatePlaybackRestrictionPolicy()
    {
        var playbackRestrictionPolicyResult = new Humidifier.IVS.PlaybackRestrictionPolicy
        {
            GivenName = InputResourceName,
        };

        return playbackRestrictionPolicyResult;
    }

} // End Of Class

public static class PlaybackRestrictionPolicyFactoryExtensions
{
}
