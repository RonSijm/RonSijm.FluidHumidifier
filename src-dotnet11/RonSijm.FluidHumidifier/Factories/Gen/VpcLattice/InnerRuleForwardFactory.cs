// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerRuleForwardFactory(Action<Humidifier.VpcLattice.RuleTypes.Forward> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.RuleTypes.Forward>
{

    protected override Humidifier.VpcLattice.RuleTypes.Forward Create()
    {
        var forwardResult = CreateForward();
        factoryAction?.Invoke(forwardResult);

        return forwardResult;
    }

    private Humidifier.VpcLattice.RuleTypes.Forward CreateForward()
    {
        var forwardResult = new Humidifier.VpcLattice.RuleTypes.Forward();

        return forwardResult;
    }

} // End Of Class

public static class InnerRuleForwardFactoryExtensions
{
}
