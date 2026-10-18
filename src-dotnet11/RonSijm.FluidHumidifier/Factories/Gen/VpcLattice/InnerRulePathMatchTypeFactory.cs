// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerRulePathMatchTypeFactory(Action<Humidifier.VpcLattice.RuleTypes.PathMatchType> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.RuleTypes.PathMatchType>
{

    protected override Humidifier.VpcLattice.RuleTypes.PathMatchType Create()
    {
        var pathMatchTypeResult = CreatePathMatchType();
        factoryAction?.Invoke(pathMatchTypeResult);

        return pathMatchTypeResult;
    }

    private Humidifier.VpcLattice.RuleTypes.PathMatchType CreatePathMatchType()
    {
        var pathMatchTypeResult = new Humidifier.VpcLattice.RuleTypes.PathMatchType();

        return pathMatchTypeResult;
    }

} // End Of Class

public static class InnerRulePathMatchTypeFactoryExtensions
{
}
