// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class InnerRegistryScanningConfigurationScanningRuleFactory(Action<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule> factoryAction = null) : SubResourceFactory<Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule>
{

    protected override Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule Create()
    {
        var scanningRuleResult = CreateScanningRule();
        factoryAction?.Invoke(scanningRuleResult);

        return scanningRuleResult;
    }

    private Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule CreateScanningRule()
    {
        var scanningRuleResult = new Humidifier.ECR.RegistryScanningConfigurationTypes.ScanningRule();

        return scanningRuleResult;
    }

} // End Of Class

public static class InnerRegistryScanningConfigurationScanningRuleFactoryExtensions
{
}
