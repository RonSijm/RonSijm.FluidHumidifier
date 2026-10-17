// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionAwsLocationFactory(Action<Humidifier.DataZone.ConnectionTypes.AwsLocation> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.AwsLocation>
{

    protected override Humidifier.DataZone.ConnectionTypes.AwsLocation Create()
    {
        var awsLocationResult = CreateAwsLocation();
        factoryAction?.Invoke(awsLocationResult);

        return awsLocationResult;
    }

    private Humidifier.DataZone.ConnectionTypes.AwsLocation CreateAwsLocation()
    {
        var awsLocationResult = new Humidifier.DataZone.ConnectionTypes.AwsLocation();

        return awsLocationResult;
    }

} // End Of Class

public static class InnerConnectionAwsLocationFactoryExtensions
{
}
