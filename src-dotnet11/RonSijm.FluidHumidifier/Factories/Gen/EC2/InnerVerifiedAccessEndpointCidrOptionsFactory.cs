// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVerifiedAccessEndpointCidrOptionsFactory(Action<Humidifier.EC2.VerifiedAccessEndpointTypes.CidrOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VerifiedAccessEndpointTypes.CidrOptions>
{

    protected override Humidifier.EC2.VerifiedAccessEndpointTypes.CidrOptions Create()
    {
        var cidrOptionsResult = CreateCidrOptions();
        factoryAction?.Invoke(cidrOptionsResult);

        return cidrOptionsResult;
    }

    private Humidifier.EC2.VerifiedAccessEndpointTypes.CidrOptions CreateCidrOptions()
    {
        var cidrOptionsResult = new Humidifier.EC2.VerifiedAccessEndpointTypes.CidrOptions();

        return cidrOptionsResult;
    }

} // End Of Class

public static class InnerVerifiedAccessEndpointCidrOptionsFactoryExtensions
{
}
