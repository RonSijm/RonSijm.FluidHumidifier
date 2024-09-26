// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerTargetGroupTargetDescriptionFactory(Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription>
{

    protected override Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription Create()
    {
        var targetDescriptionResult = CreateTargetDescription();
        factoryAction?.Invoke(targetDescriptionResult);

        return targetDescriptionResult;
    }

    private Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription CreateTargetDescription()
    {
        var targetDescriptionResult = new Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetDescription();

        return targetDescriptionResult;
    }

} // End Of Class

public static class InnerTargetGroupTargetDescriptionFactoryExtensions
{
}
