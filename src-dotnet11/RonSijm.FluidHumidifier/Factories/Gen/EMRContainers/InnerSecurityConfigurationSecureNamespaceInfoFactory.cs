// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerSecurityConfigurationSecureNamespaceInfoFactory(Action<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo>
{

    protected override Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo Create()
    {
        var secureNamespaceInfoResult = CreateSecureNamespaceInfo();
        factoryAction?.Invoke(secureNamespaceInfoResult);

        return secureNamespaceInfoResult;
    }

    private Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo CreateSecureNamespaceInfo()
    {
        var secureNamespaceInfoResult = new Humidifier.EMRContainers.SecurityConfigurationTypes.SecureNamespaceInfo();

        return secureNamespaceInfoResult;
    }

} // End Of Class

public static class InnerSecurityConfigurationSecureNamespaceInfoFactoryExtensions
{
}
