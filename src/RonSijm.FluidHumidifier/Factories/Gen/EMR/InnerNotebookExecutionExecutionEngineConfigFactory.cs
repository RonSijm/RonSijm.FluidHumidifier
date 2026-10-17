// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerNotebookExecutionExecutionEngineConfigFactory(Action<Humidifier.EMR.NotebookExecutionTypes.ExecutionEngineConfig> factoryAction = null) : SubResourceFactory<Humidifier.EMR.NotebookExecutionTypes.ExecutionEngineConfig>
{

    protected override Humidifier.EMR.NotebookExecutionTypes.ExecutionEngineConfig Create()
    {
        var executionEngineConfigResult = CreateExecutionEngineConfig();
        factoryAction?.Invoke(executionEngineConfigResult);

        return executionEngineConfigResult;
    }

    private Humidifier.EMR.NotebookExecutionTypes.ExecutionEngineConfig CreateExecutionEngineConfig()
    {
        var executionEngineConfigResult = new Humidifier.EMR.NotebookExecutionTypes.ExecutionEngineConfig();

        return executionEngineConfigResult;
    }

} // End Of Class

public static class InnerNotebookExecutionExecutionEngineConfigFactoryExtensions
{
}
