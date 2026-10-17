// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ControlCatalog;

public class CommonControlFactory(string resourceName = null, Action<Humidifier.ControlCatalog.CommonControl> factoryAction = null) : ResourceFactory<Humidifier.ControlCatalog.CommonControl>(resourceName)
{

    protected override Humidifier.ControlCatalog.CommonControl Create()
    {
        var commonControlResult = CreateCommonControl();
        factoryAction?.Invoke(commonControlResult);

        return commonControlResult;
    }

    private Humidifier.ControlCatalog.CommonControl CreateCommonControl()
    {
        var commonControlResult = new Humidifier.ControlCatalog.CommonControl
        {
            GivenName = InputResourceName,
        };

        return commonControlResult;
    }

} // End Of Class

public static class CommonControlFactoryExtensions
{
}
