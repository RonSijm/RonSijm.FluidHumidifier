// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerNotebookInstanceLifecycleConfigNotebookInstanceLifecycleHookFactory(Action<Humidifier.SageMaker.NotebookInstanceLifecycleConfigTypes.NotebookInstanceLifecycleHook> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.NotebookInstanceLifecycleConfigTypes.NotebookInstanceLifecycleHook>
{

    protected override Humidifier.SageMaker.NotebookInstanceLifecycleConfigTypes.NotebookInstanceLifecycleHook Create()
    {
        var notebookInstanceLifecycleHookResult = CreateNotebookInstanceLifecycleHook();
        factoryAction?.Invoke(notebookInstanceLifecycleHookResult);

        return notebookInstanceLifecycleHookResult;
    }

    private Humidifier.SageMaker.NotebookInstanceLifecycleConfigTypes.NotebookInstanceLifecycleHook CreateNotebookInstanceLifecycleHook()
    {
        var notebookInstanceLifecycleHookResult = new Humidifier.SageMaker.NotebookInstanceLifecycleConfigTypes.NotebookInstanceLifecycleHook();

        return notebookInstanceLifecycleHookResult;
    }

} // End Of Class

public static class InnerNotebookInstanceLifecycleConfigNotebookInstanceLifecycleHookFactoryExtensions
{
}
