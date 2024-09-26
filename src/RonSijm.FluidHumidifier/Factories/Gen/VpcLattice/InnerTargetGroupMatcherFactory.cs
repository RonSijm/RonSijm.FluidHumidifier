// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerTargetGroupMatcherFactory(Action<Humidifier.VpcLattice.TargetGroupTypes.Matcher> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.TargetGroupTypes.Matcher>
{

    protected override Humidifier.VpcLattice.TargetGroupTypes.Matcher Create()
    {
        var matcherResult = CreateMatcher();
        factoryAction?.Invoke(matcherResult);

        return matcherResult;
    }

    private Humidifier.VpcLattice.TargetGroupTypes.Matcher CreateMatcher()
    {
        var matcherResult = new Humidifier.VpcLattice.TargetGroupTypes.Matcher();

        return matcherResult;
    }

} // End Of Class

public static class InnerTargetGroupMatcherFactoryExtensions
{
}
