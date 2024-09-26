// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class InnerTargetGroupTargetFactory(Action<Humidifier.VpcLattice.TargetGroupTypes.Target> factoryAction = null) : SubResourceFactory<Humidifier.VpcLattice.TargetGroupTypes.Target>
{

    protected override Humidifier.VpcLattice.TargetGroupTypes.Target Create()
    {
        var targetResult = CreateTarget();
        factoryAction?.Invoke(targetResult);

        return targetResult;
    }

    private Humidifier.VpcLattice.TargetGroupTypes.Target CreateTarget()
    {
        var targetResult = new Humidifier.VpcLattice.TargetGroupTypes.Target();

        return targetResult;
    }

} // End Of Class

public static class InnerTargetGroupTargetFactoryExtensions
{
}
