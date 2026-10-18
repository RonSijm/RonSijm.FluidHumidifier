// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerRecordSetAliasTargetFactory(Action<Humidifier.Route53.RecordSetTypes.AliasTarget> factoryAction = null) : SubResourceFactory<Humidifier.Route53.RecordSetTypes.AliasTarget>
{

    protected override Humidifier.Route53.RecordSetTypes.AliasTarget Create()
    {
        var aliasTargetResult = CreateAliasTarget();
        factoryAction?.Invoke(aliasTargetResult);

        return aliasTargetResult;
    }

    private Humidifier.Route53.RecordSetTypes.AliasTarget CreateAliasTarget()
    {
        var aliasTargetResult = new Humidifier.Route53.RecordSetTypes.AliasTarget();

        return aliasTargetResult;
    }

} // End Of Class

public static class InnerRecordSetAliasTargetFactoryExtensions
{
}
