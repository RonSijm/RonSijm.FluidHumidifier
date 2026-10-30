// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerDomainForOrganizationIdentityCenterConfigurationFactory(Action<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration>
{

    protected override Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration Create()
    {
        var identityCenterConfigurationResult = CreateIdentityCenterConfiguration();
        factoryAction?.Invoke(identityCenterConfigurationResult);

        return identityCenterConfigurationResult;
    }

    private Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration CreateIdentityCenterConfiguration()
    {
        var identityCenterConfigurationResult = new Humidifier.CloudWatch.DomainForOrganizationTypes.IdentityCenterConfiguration();

        return identityCenterConfigurationResult;
    }

} // End Of Class

public static class InnerDomainForOrganizationIdentityCenterConfigurationFactoryExtensions
{
}
