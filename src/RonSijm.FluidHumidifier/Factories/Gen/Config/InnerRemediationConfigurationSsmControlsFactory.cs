// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerRemediationConfigurationSsmControlsFactory(Action<Humidifier.Config.RemediationConfigurationTypes.SsmControls> factoryAction = null) : SubResourceFactory<Humidifier.Config.RemediationConfigurationTypes.SsmControls>
{

    protected override Humidifier.Config.RemediationConfigurationTypes.SsmControls Create()
    {
        var ssmControlsResult = CreateSsmControls();
        factoryAction?.Invoke(ssmControlsResult);

        return ssmControlsResult;
    }

    private Humidifier.Config.RemediationConfigurationTypes.SsmControls CreateSsmControls()
    {
        var ssmControlsResult = new Humidifier.Config.RemediationConfigurationTypes.SsmControls();

        return ssmControlsResult;
    }

} // End Of Class

public static class InnerRemediationConfigurationSsmControlsFactoryExtensions
{
}
