// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerSecurityConfigurationIAMConfigurationFactory(Action<Humidifier.EMRContainers.SecurityConfigurationTypes.IAMConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.SecurityConfigurationTypes.IAMConfiguration>
{

    protected override Humidifier.EMRContainers.SecurityConfigurationTypes.IAMConfiguration Create()
    {
        var iAMConfigurationResult = CreateIAMConfiguration();
        factoryAction?.Invoke(iAMConfigurationResult);

        return iAMConfigurationResult;
    }

    private Humidifier.EMRContainers.SecurityConfigurationTypes.IAMConfiguration CreateIAMConfiguration()
    {
        var iAMConfigurationResult = new Humidifier.EMRContainers.SecurityConfigurationTypes.IAMConfiguration();

        return iAMConfigurationResult;
    }

} // End Of Class

public static class InnerSecurityConfigurationIAMConfigurationFactoryExtensions
{
}
