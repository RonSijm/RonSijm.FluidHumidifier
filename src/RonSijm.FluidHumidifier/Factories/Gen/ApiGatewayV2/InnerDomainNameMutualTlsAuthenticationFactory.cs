// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerDomainNameMutualTlsAuthenticationFactory(Action<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication>
{

    protected override Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication Create()
    {
        var mutualTlsAuthenticationResult = CreateMutualTlsAuthentication();
        factoryAction?.Invoke(mutualTlsAuthenticationResult);

        return mutualTlsAuthenticationResult;
    }

    private Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication CreateMutualTlsAuthentication()
    {
        var mutualTlsAuthenticationResult = new Humidifier.ApiGatewayV2.DomainNameTypes.MutualTlsAuthentication();

        return mutualTlsAuthenticationResult;
    }

} // End Of Class

public static class InnerDomainNameMutualTlsAuthenticationFactoryExtensions
{
}
