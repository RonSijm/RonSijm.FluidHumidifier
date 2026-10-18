// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ControlTower;

public class BaselineFactory(string resourceName = null, Action<Humidifier.ControlTower.Baseline> factoryAction = null) : ResourceFactory<Humidifier.ControlTower.Baseline>(resourceName)
{

    protected override Humidifier.ControlTower.Baseline Create()
    {
        var baselineResult = CreateBaseline();
        factoryAction?.Invoke(baselineResult);

        return baselineResult;
    }

    private Humidifier.ControlTower.Baseline CreateBaseline()
    {
        var baselineResult = new Humidifier.ControlTower.Baseline
        {
            GivenName = InputResourceName,
        };

        return baselineResult;
    }

} // End Of Class

public static class BaselineFactoryExtensions
{
}
