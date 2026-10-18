// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVerifiedAccessEndpointRdsOptionsFactory(Action<Humidifier.EC2.VerifiedAccessEndpointTypes.RdsOptions> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VerifiedAccessEndpointTypes.RdsOptions>
{

    protected override Humidifier.EC2.VerifiedAccessEndpointTypes.RdsOptions Create()
    {
        var rdsOptionsResult = CreateRdsOptions();
        factoryAction?.Invoke(rdsOptionsResult);

        return rdsOptionsResult;
    }

    private Humidifier.EC2.VerifiedAccessEndpointTypes.RdsOptions CreateRdsOptions()
    {
        var rdsOptionsResult = new Humidifier.EC2.VerifiedAccessEndpointTypes.RdsOptions();

        return rdsOptionsResult;
    }

} // End Of Class

public static class InnerVerifiedAccessEndpointRdsOptionsFactoryExtensions
{
}
