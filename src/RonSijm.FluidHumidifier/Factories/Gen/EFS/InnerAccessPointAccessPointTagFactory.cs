// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EFS;

public class InnerAccessPointAccessPointTagFactory(Action<Humidifier.EFS.AccessPointTypes.AccessPointTag> factoryAction = null) : SubResourceFactory<Humidifier.EFS.AccessPointTypes.AccessPointTag>
{

    protected override Humidifier.EFS.AccessPointTypes.AccessPointTag Create()
    {
        var accessPointTagResult = CreateAccessPointTag();
        factoryAction?.Invoke(accessPointTagResult);

        return accessPointTagResult;
    }

    private Humidifier.EFS.AccessPointTypes.AccessPointTag CreateAccessPointTag()
    {
        var accessPointTagResult = new Humidifier.EFS.AccessPointTypes.AccessPointTag();

        return accessPointTagResult;
    }

} // End Of Class

public static class InnerAccessPointAccessPointTagFactoryExtensions
{
}
