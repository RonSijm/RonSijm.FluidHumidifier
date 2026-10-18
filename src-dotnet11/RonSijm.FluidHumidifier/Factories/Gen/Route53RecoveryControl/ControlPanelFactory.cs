// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryControl;

public class ControlPanelFactory(string resourceName = null, Action<Humidifier.Route53RecoveryControl.ControlPanel> factoryAction = null) : ResourceFactory<Humidifier.Route53RecoveryControl.ControlPanel>(resourceName)
{

    protected override Humidifier.Route53RecoveryControl.ControlPanel Create()
    {
        var controlPanelResult = CreateControlPanel();
        factoryAction?.Invoke(controlPanelResult);

        return controlPanelResult;
    }

    private Humidifier.Route53RecoveryControl.ControlPanel CreateControlPanel()
    {
        var controlPanelResult = new Humidifier.Route53RecoveryControl.ControlPanel
        {
            GivenName = InputResourceName,
        };

        return controlPanelResult;
    }

} // End Of Class

public static class ControlPanelFactoryExtensions
{
}
