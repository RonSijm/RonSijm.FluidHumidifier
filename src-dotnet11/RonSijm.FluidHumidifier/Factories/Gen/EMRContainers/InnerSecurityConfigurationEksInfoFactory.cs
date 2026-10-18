// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerSecurityConfigurationEksInfoFactory(Action<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo>
{

    protected override Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo Create()
    {
        var eksInfoResult = CreateEksInfo();
        factoryAction?.Invoke(eksInfoResult);

        return eksInfoResult;
    }

    private Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo CreateEksInfo()
    {
        var eksInfoResult = new Humidifier.EMRContainers.SecurityConfigurationTypes.EksInfo();

        return eksInfoResult;
    }

} // End Of Class

public static class InnerSecurityConfigurationEksInfoFactoryExtensions
{
}
