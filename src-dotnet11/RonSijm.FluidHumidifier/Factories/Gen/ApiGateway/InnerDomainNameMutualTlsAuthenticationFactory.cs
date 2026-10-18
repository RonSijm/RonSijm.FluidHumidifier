// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGateway;

public class InnerDomainNameMutualTlsAuthenticationFactory(Action<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication> factoryAction = null) : SubResourceFactory<Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication>
{

    protected override Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication Create()
    {
        var mutualTlsAuthenticationResult = CreateMutualTlsAuthentication();
        factoryAction?.Invoke(mutualTlsAuthenticationResult);

        return mutualTlsAuthenticationResult;
    }

    private Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication CreateMutualTlsAuthentication()
    {
        var mutualTlsAuthenticationResult = new Humidifier.ApiGateway.DomainNameTypes.MutualTlsAuthentication();

        return mutualTlsAuthenticationResult;
    }

} // End Of Class

public static class InnerDomainNameMutualTlsAuthenticationFactoryExtensions
{
}
