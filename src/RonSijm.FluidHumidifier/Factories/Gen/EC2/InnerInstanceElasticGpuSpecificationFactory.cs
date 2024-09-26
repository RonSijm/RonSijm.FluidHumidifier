// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceElasticGpuSpecificationFactory(Action<Humidifier.EC2.InstanceTypes.ElasticGpuSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.ElasticGpuSpecification>
{

    protected override Humidifier.EC2.InstanceTypes.ElasticGpuSpecification Create()
    {
        var elasticGpuSpecificationResult = CreateElasticGpuSpecification();
        factoryAction?.Invoke(elasticGpuSpecificationResult);

        return elasticGpuSpecificationResult;
    }

    private Humidifier.EC2.InstanceTypes.ElasticGpuSpecification CreateElasticGpuSpecification()
    {
        var elasticGpuSpecificationResult = new Humidifier.EC2.InstanceTypes.ElasticGpuSpecification();

        return elasticGpuSpecificationResult;
    }

} // End Of Class

public static class InnerInstanceElasticGpuSpecificationFactoryExtensions
{
}
