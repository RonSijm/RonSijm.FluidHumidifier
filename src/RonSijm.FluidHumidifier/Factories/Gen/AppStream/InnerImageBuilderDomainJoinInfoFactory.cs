// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerImageBuilderDomainJoinInfoFactory(Action<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo>
{

    protected override Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo Create()
    {
        var domainJoinInfoResult = CreateDomainJoinInfo();
        factoryAction?.Invoke(domainJoinInfoResult);

        return domainJoinInfoResult;
    }

    private Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo CreateDomainJoinInfo()
    {
        var domainJoinInfoResult = new Humidifier.AppStream.ImageBuilderTypes.DomainJoinInfo();

        return domainJoinInfoResult;
    }

} // End Of Class

public static class InnerImageBuilderDomainJoinInfoFactoryExtensions
{
}
