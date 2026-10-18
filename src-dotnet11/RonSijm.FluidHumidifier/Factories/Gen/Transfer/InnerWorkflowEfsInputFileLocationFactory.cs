// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWorkflowEfsInputFileLocationFactory(Action<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation>
{

    protected override Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation Create()
    {
        var efsInputFileLocationResult = CreateEfsInputFileLocation();
        factoryAction?.Invoke(efsInputFileLocationResult);

        return efsInputFileLocationResult;
    }

    private Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation CreateEfsInputFileLocation()
    {
        var efsInputFileLocationResult = new Humidifier.Transfer.WorkflowTypes.EfsInputFileLocation();

        return efsInputFileLocationResult;
    }

} // End Of Class

public static class InnerWorkflowEfsInputFileLocationFactoryExtensions
{
}
