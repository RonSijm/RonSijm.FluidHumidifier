// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveWindowFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Window> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Window>
{

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Window Create()
    {
        var windowResult = CreateWindow();
        factoryAction?.Invoke(windowResult);

        return windowResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Window CreateWindow()
    {
        var windowResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Window();

        return windowResult;
    }

} // End Of Class

public static class InnerServiceLevelObjectiveWindowFactoryExtensions
{
}
