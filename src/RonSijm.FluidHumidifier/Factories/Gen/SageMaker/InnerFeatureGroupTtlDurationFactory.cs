// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerFeatureGroupTtlDurationFactory(Action<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.FeatureGroupTypes.TtlDuration>
{

    protected override Humidifier.SageMaker.FeatureGroupTypes.TtlDuration Create()
    {
        var ttlDurationResult = CreateTtlDuration();
        factoryAction?.Invoke(ttlDurationResult);

        return ttlDurationResult;
    }

    private Humidifier.SageMaker.FeatureGroupTypes.TtlDuration CreateTtlDuration()
    {
        var ttlDurationResult = new Humidifier.SageMaker.FeatureGroupTypes.TtlDuration();

        return ttlDurationResult;
    }

} // End Of Class

public static class InnerFeatureGroupTtlDurationFactoryExtensions
{
}
