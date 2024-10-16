// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class InnerTargetGroupTargetGroupAttributeFactory(Action<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute> factoryAction = null) : SubResourceFactory<Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute>
{

    protected override Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute Create()
    {
        var targetGroupAttributeResult = CreateTargetGroupAttribute();
        factoryAction?.Invoke(targetGroupAttributeResult);

        return targetGroupAttributeResult;
    }

    private Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute CreateTargetGroupAttribute()
    {
        var targetGroupAttributeResult = new Humidifier.ElasticLoadBalancingV2.TargetGroupTypes.TargetGroupAttribute();

        return targetGroupAttributeResult;
    }

} // End Of Class

public static class InnerTargetGroupTargetGroupAttributeFactoryExtensions
{
}
