// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceElasticInferenceAcceleratorFactory(Action<Humidifier.EC2.InstanceTypes.ElasticInferenceAccelerator> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.ElasticInferenceAccelerator>
{

    protected override Humidifier.EC2.InstanceTypes.ElasticInferenceAccelerator Create()
    {
        var elasticInferenceAcceleratorResult = CreateElasticInferenceAccelerator();
        factoryAction?.Invoke(elasticInferenceAcceleratorResult);

        return elasticInferenceAcceleratorResult;
    }

    private Humidifier.EC2.InstanceTypes.ElasticInferenceAccelerator CreateElasticInferenceAccelerator()
    {
        var elasticInferenceAcceleratorResult = new Humidifier.EC2.InstanceTypes.ElasticInferenceAccelerator();

        return elasticInferenceAcceleratorResult;
    }

} // End Of Class

public static class InnerInstanceElasticInferenceAcceleratorFactoryExtensions
{
}
