// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerRecordSetGroupAliasTargetFactory(Action<Humidifier.Route53.RecordSetGroupTypes.AliasTarget> factoryAction = null) : SubResourceFactory<Humidifier.Route53.RecordSetGroupTypes.AliasTarget>
{

    protected override Humidifier.Route53.RecordSetGroupTypes.AliasTarget Create()
    {
        var aliasTargetResult = CreateAliasTarget();
        factoryAction?.Invoke(aliasTargetResult);

        return aliasTargetResult;
    }

    private Humidifier.Route53.RecordSetGroupTypes.AliasTarget CreateAliasTarget()
    {
        var aliasTargetResult = new Humidifier.Route53.RecordSetGroupTypes.AliasTarget();

        return aliasTargetResult;
    }

} // End Of Class

public static class InnerRecordSetGroupAliasTargetFactoryExtensions
{
}
