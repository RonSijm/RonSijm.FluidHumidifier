// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerDomainIdentityCenterConfigurationFactory(Action<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration>
{

    protected override Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration Create()
    {
        var identityCenterConfigurationResult = CreateIdentityCenterConfiguration();
        factoryAction?.Invoke(identityCenterConfigurationResult);

        return identityCenterConfigurationResult;
    }

    private Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration CreateIdentityCenterConfiguration()
    {
        var identityCenterConfigurationResult = new Humidifier.CloudWatch.DomainTypes.IdentityCenterConfiguration();

        return identityCenterConfigurationResult;
    }

} // End Of Class

public static class InnerDomainIdentityCenterConfigurationFactoryExtensions
{
}
