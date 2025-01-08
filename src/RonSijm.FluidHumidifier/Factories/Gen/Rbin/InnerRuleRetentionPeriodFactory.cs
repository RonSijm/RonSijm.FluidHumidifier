// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rbin;

public class InnerRuleRetentionPeriodFactory(Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> factoryAction = null) : SubResourceFactory<Humidifier.Rbin.RuleTypes.RetentionPeriod>
{

    protected override Humidifier.Rbin.RuleTypes.RetentionPeriod Create()
    {
        var retentionPeriodResult = CreateRetentionPeriod();
        factoryAction?.Invoke(retentionPeriodResult);

        return retentionPeriodResult;
    }

    private Humidifier.Rbin.RuleTypes.RetentionPeriod CreateRetentionPeriod()
    {
        var retentionPeriodResult = new Humidifier.Rbin.RuleTypes.RetentionPeriod();

        return retentionPeriodResult;
    }

} // End Of Class

public static class InnerRuleRetentionPeriodFactoryExtensions
{
}
