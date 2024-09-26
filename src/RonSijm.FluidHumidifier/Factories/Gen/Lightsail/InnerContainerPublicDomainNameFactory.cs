// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerContainerPublicDomainNameFactory(Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.ContainerTypes.PublicDomainName>
{

    protected override Humidifier.Lightsail.ContainerTypes.PublicDomainName Create()
    {
        var publicDomainNameResult = CreatePublicDomainName();
        factoryAction?.Invoke(publicDomainNameResult);

        return publicDomainNameResult;
    }

    private Humidifier.Lightsail.ContainerTypes.PublicDomainName CreatePublicDomainName()
    {
        var publicDomainNameResult = new Humidifier.Lightsail.ContainerTypes.PublicDomainName();

        return publicDomainNameResult;
    }

} // End Of Class

public static class InnerContainerPublicDomainNameFactoryExtensions
{
}
