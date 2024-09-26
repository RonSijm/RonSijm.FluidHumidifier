// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactory(Action<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest> factoryAction = null) : SubResourceFactory<Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest>
{

    protected override Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest Create()
    {
        var fleetLaunchTemplateSpecificationRequestResult = CreateFleetLaunchTemplateSpecificationRequest();
        factoryAction?.Invoke(fleetLaunchTemplateSpecificationRequestResult);

        return fleetLaunchTemplateSpecificationRequestResult;
    }

    private Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest CreateFleetLaunchTemplateSpecificationRequest()
    {
        var fleetLaunchTemplateSpecificationRequestResult = new Humidifier.EC2.EC2FleetTypes.FleetLaunchTemplateSpecificationRequest();

        return fleetLaunchTemplateSpecificationRequestResult;
    }

} // End Of Class

public static class InnerEC2FleetFleetLaunchTemplateSpecificationRequestFactoryExtensions
{
}
