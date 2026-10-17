// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerSpotInstancesRequestIamInstanceProfileSpecificationFactory(Action<Humidifier.EC2.SpotInstancesRequestTypes.IamInstanceProfileSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.SpotInstancesRequestTypes.IamInstanceProfileSpecification>
{

    protected override Humidifier.EC2.SpotInstancesRequestTypes.IamInstanceProfileSpecification Create()
    {
        var iamInstanceProfileSpecificationResult = CreateIamInstanceProfileSpecification();
        factoryAction?.Invoke(iamInstanceProfileSpecificationResult);

        return iamInstanceProfileSpecificationResult;
    }

    private Humidifier.EC2.SpotInstancesRequestTypes.IamInstanceProfileSpecification CreateIamInstanceProfileSpecification()
    {
        var iamInstanceProfileSpecificationResult = new Humidifier.EC2.SpotInstancesRequestTypes.IamInstanceProfileSpecification();

        return iamInstanceProfileSpecificationResult;
    }

} // End Of Class

public static class InnerSpotInstancesRequestIamInstanceProfileSpecificationFactoryExtensions
{
}
