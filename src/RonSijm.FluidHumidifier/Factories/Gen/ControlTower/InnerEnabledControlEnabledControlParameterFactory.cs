// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ControlTower;

public class InnerEnabledControlEnabledControlParameterFactory(Action<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter> factoryAction = null) : SubResourceFactory<Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter>
{

    protected override Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter Create()
    {
        var enabledControlParameterResult = CreateEnabledControlParameter();
        factoryAction?.Invoke(enabledControlParameterResult);

        return enabledControlParameterResult;
    }

    private Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter CreateEnabledControlParameter()
    {
        var enabledControlParameterResult = new Humidifier.ControlTower.EnabledControlTypes.EnabledControlParameter();

        return enabledControlParameterResult;
    }

} // End Of Class

public static class InnerEnabledControlEnabledControlParameterFactoryExtensions
{
}
