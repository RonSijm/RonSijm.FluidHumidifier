// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerEC2FleetTargetCapacitySpecificationRequestFactory(Action<Humidifier.EC2.EC2FleetTypes.TargetCapacitySpecificationRequest> factoryAction = null) : SubResourceFactory<Humidifier.EC2.EC2FleetTypes.TargetCapacitySpecificationRequest>
{

    protected override Humidifier.EC2.EC2FleetTypes.TargetCapacitySpecificationRequest Create()
    {
        var targetCapacitySpecificationRequestResult = CreateTargetCapacitySpecificationRequest();
        factoryAction?.Invoke(targetCapacitySpecificationRequestResult);

        return targetCapacitySpecificationRequestResult;
    }

    private Humidifier.EC2.EC2FleetTypes.TargetCapacitySpecificationRequest CreateTargetCapacitySpecificationRequest()
    {
        var targetCapacitySpecificationRequestResult = new Humidifier.EC2.EC2FleetTypes.TargetCapacitySpecificationRequest();

        return targetCapacitySpecificationRequestResult;
    }

} // End Of Class

public static class InnerEC2FleetTargetCapacitySpecificationRequestFactoryExtensions
{
}
