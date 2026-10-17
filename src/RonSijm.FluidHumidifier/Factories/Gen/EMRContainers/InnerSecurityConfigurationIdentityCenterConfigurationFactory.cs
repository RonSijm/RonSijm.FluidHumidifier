// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerSecurityConfigurationIdentityCenterConfigurationFactory(Action<Humidifier.EMRContainers.SecurityConfigurationTypes.IdentityCenterConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.SecurityConfigurationTypes.IdentityCenterConfiguration>
{

    protected override Humidifier.EMRContainers.SecurityConfigurationTypes.IdentityCenterConfiguration Create()
    {
        var identityCenterConfigurationResult = CreateIdentityCenterConfiguration();
        factoryAction?.Invoke(identityCenterConfigurationResult);

        return identityCenterConfigurationResult;
    }

    private Humidifier.EMRContainers.SecurityConfigurationTypes.IdentityCenterConfiguration CreateIdentityCenterConfiguration()
    {
        var identityCenterConfigurationResult = new Humidifier.EMRContainers.SecurityConfigurationTypes.IdentityCenterConfiguration();

        return identityCenterConfigurationResult;
    }

} // End Of Class

public static class InnerSecurityConfigurationIdentityCenterConfigurationFactoryExtensions
{
}
