// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rbin;

public class InnerRuleUnlockDelayFactory(Action<Humidifier.Rbin.RuleTypes.UnlockDelay> factoryAction = null) : SubResourceFactory<Humidifier.Rbin.RuleTypes.UnlockDelay>
{

    protected override Humidifier.Rbin.RuleTypes.UnlockDelay Create()
    {
        var unlockDelayResult = CreateUnlockDelay();
        factoryAction?.Invoke(unlockDelayResult);

        return unlockDelayResult;
    }

    private Humidifier.Rbin.RuleTypes.UnlockDelay CreateUnlockDelay()
    {
        var unlockDelayResult = new Humidifier.Rbin.RuleTypes.UnlockDelay();

        return unlockDelayResult;
    }

} // End Of Class

public static class InnerRuleUnlockDelayFactoryExtensions
{
}
