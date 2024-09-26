// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ControlTower;

public class InnerEnabledBaselineParameterFactory(Action<Humidifier.ControlTower.EnabledBaselineTypes.Parameter> factoryAction = null) : SubResourceFactory<Humidifier.ControlTower.EnabledBaselineTypes.Parameter>
{

    protected override Humidifier.ControlTower.EnabledBaselineTypes.Parameter Create()
    {
        var parameterResult = CreateParameter();
        factoryAction?.Invoke(parameterResult);

        return parameterResult;
    }

    private Humidifier.ControlTower.EnabledBaselineTypes.Parameter CreateParameter()
    {
        var parameterResult = new Humidifier.ControlTower.EnabledBaselineTypes.Parameter();

        return parameterResult;
    }

} // End Of Class

public static class InnerEnabledBaselineParameterFactoryExtensions
{
}
