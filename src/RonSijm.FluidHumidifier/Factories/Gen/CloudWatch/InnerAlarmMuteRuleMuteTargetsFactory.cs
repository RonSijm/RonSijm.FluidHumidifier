// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmMuteRuleMuteTargetsFactory(Action<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets>
{

    protected override Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets Create()
    {
        var muteTargetsResult = CreateMuteTargets();
        factoryAction?.Invoke(muteTargetsResult);

        return muteTargetsResult;
    }

    private Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets CreateMuteTargets()
    {
        var muteTargetsResult = new Humidifier.CloudWatch.AlarmMuteRuleTypes.MuteTargets();

        return muteTargetsResult;
    }

} // End Of Class

public static class InnerAlarmMuteRuleMuteTargetsFactoryExtensions
{
}
