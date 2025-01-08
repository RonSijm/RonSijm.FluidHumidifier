// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVPNConnectionCloudwatchLogOptionsSpecificationFactory(Action<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification>
{

    protected override Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification Create()
    {
        var cloudwatchLogOptionsSpecificationResult = CreateCloudwatchLogOptionsSpecification();
        factoryAction?.Invoke(cloudwatchLogOptionsSpecificationResult);

        return cloudwatchLogOptionsSpecificationResult;
    }

    private Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification CreateCloudwatchLogOptionsSpecification()
    {
        var cloudwatchLogOptionsSpecificationResult = new Humidifier.EC2.VPNConnectionTypes.CloudwatchLogOptionsSpecification();

        return cloudwatchLogOptionsSpecificationResult;
    }

} // End Of Class

public static class InnerVPNConnectionCloudwatchLogOptionsSpecificationFactoryExtensions
{
}
