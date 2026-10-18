// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RoboMaker;

public class InnerSimulationApplicationRenderingEngineFactory(Action<Humidifier.RoboMaker.SimulationApplicationTypes.RenderingEngine> factoryAction = null) : SubResourceFactory<Humidifier.RoboMaker.SimulationApplicationTypes.RenderingEngine>
{

    protected override Humidifier.RoboMaker.SimulationApplicationTypes.RenderingEngine Create()
    {
        var renderingEngineResult = CreateRenderingEngine();
        factoryAction?.Invoke(renderingEngineResult);

        return renderingEngineResult;
    }

    private Humidifier.RoboMaker.SimulationApplicationTypes.RenderingEngine CreateRenderingEngine()
    {
        var renderingEngineResult = new Humidifier.RoboMaker.SimulationApplicationTypes.RenderingEngine();

        return renderingEngineResult;
    }

} // End Of Class

public static class InnerSimulationApplicationRenderingEngineFactoryExtensions
{
}
