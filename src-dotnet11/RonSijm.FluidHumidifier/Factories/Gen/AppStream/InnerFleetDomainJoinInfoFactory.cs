// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerFleetDomainJoinInfoFactory(Action<Humidifier.AppStream.FleetTypes.DomainJoinInfo> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.FleetTypes.DomainJoinInfo>
{

    protected override Humidifier.AppStream.FleetTypes.DomainJoinInfo Create()
    {
        var domainJoinInfoResult = CreateDomainJoinInfo();
        factoryAction?.Invoke(domainJoinInfoResult);

        return domainJoinInfoResult;
    }

    private Humidifier.AppStream.FleetTypes.DomainJoinInfo CreateDomainJoinInfo()
    {
        var domainJoinInfoResult = new Humidifier.AppStream.FleetTypes.DomainJoinInfo();

        return domainJoinInfoResult;
    }

} // End Of Class

public static class InnerFleetDomainJoinInfoFactoryExtensions
{
}
