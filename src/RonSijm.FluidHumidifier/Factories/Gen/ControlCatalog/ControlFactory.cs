// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ControlCatalog;

public class ControlFactory(string resourceName = null, Action<Humidifier.ControlCatalog.Control> factoryAction = null) : ResourceFactory<Humidifier.ControlCatalog.Control>(resourceName)
{

    protected override Humidifier.ControlCatalog.Control Create()
    {
        var controlResult = CreateControl();
        factoryAction?.Invoke(controlResult);

        return controlResult;
    }

    private Humidifier.ControlCatalog.Control CreateControl()
    {
        var controlResult = new Humidifier.ControlCatalog.Control
        {
            GivenName = InputResourceName,
        };

        return controlResult;
    }

} // End Of Class

public static class ControlFactoryExtensions
{
}
