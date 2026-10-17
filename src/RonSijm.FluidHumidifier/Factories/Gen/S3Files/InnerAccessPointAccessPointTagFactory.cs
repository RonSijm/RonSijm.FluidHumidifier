// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Files;

public class InnerAccessPointAccessPointTagFactory(Action<Humidifier.S3Files.AccessPointTypes.AccessPointTag> factoryAction = null) : SubResourceFactory<Humidifier.S3Files.AccessPointTypes.AccessPointTag>
{

    protected override Humidifier.S3Files.AccessPointTypes.AccessPointTag Create()
    {
        var accessPointTagResult = CreateAccessPointTag();
        factoryAction?.Invoke(accessPointTagResult);

        return accessPointTagResult;
    }

    private Humidifier.S3Files.AccessPointTypes.AccessPointTag CreateAccessPointTag()
    {
        var accessPointTagResult = new Humidifier.S3Files.AccessPointTypes.AccessPointTag();

        return accessPointTagResult;
    }

} // End Of Class

public static class InnerAccessPointAccessPointTagFactoryExtensions
{
}
