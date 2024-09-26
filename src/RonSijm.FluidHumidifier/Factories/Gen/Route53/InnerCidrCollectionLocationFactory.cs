// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerCidrCollectionLocationFactory(Action<Humidifier.Route53.CidrCollectionTypes.Location> factoryAction = null) : SubResourceFactory<Humidifier.Route53.CidrCollectionTypes.Location>
{

    protected override Humidifier.Route53.CidrCollectionTypes.Location Create()
    {
        var locationResult = CreateLocation();
        factoryAction?.Invoke(locationResult);

        return locationResult;
    }

    private Humidifier.Route53.CidrCollectionTypes.Location CreateLocation()
    {
        var locationResult = new Humidifier.Route53.CidrCollectionTypes.Location();

        return locationResult;
    }

} // End Of Class

public static class InnerCidrCollectionLocationFactoryExtensions
{
}
