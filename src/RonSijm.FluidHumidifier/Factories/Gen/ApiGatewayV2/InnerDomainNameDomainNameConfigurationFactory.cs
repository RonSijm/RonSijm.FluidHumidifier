// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerDomainNameDomainNameConfigurationFactory(Action<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration>
{

    protected override Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration Create()
    {
        var domainNameConfigurationResult = CreateDomainNameConfiguration();
        factoryAction?.Invoke(domainNameConfigurationResult);

        return domainNameConfigurationResult;
    }

    private Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration CreateDomainNameConfiguration()
    {
        var domainNameConfigurationResult = new Humidifier.ApiGatewayV2.DomainNameTypes.DomainNameConfiguration();

        return domainNameConfigurationResult;
    }

} // End Of Class

public static class InnerDomainNameDomainNameConfigurationFactoryExtensions
{
}
