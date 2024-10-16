// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerWorkflowDecryptStepDetailsFactory(Action<Humidifier.Transfer.WorkflowTypes.DecryptStepDetails> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.WorkflowTypes.DecryptStepDetails>
{

    internal InnerWorkflowInputFileLocationFactory DestinationFileLocationFactory { get; set; }

    protected override Humidifier.Transfer.WorkflowTypes.DecryptStepDetails Create()
    {
        var decryptStepDetailsResult = CreateDecryptStepDetails();
        factoryAction?.Invoke(decryptStepDetailsResult);

        return decryptStepDetailsResult;
    }

    private Humidifier.Transfer.WorkflowTypes.DecryptStepDetails CreateDecryptStepDetails()
    {
        var decryptStepDetailsResult = new Humidifier.Transfer.WorkflowTypes.DecryptStepDetails();

        return decryptStepDetailsResult;
    }
    public override void CreateChildren(Humidifier.Transfer.WorkflowTypes.DecryptStepDetails result)
    {
        base.CreateChildren(result);

        result.DestinationFileLocation ??= DestinationFileLocationFactory?.Build();
    }

} // End Of Class

public static class InnerWorkflowDecryptStepDetailsFactoryExtensions
{
    public static CombinedResult<InnerWorkflowDecryptStepDetailsFactory, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation(this InnerWorkflowDecryptStepDetailsFactory parentFactory, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null)
    {
        parentFactory.DestinationFileLocationFactory = new InnerWorkflowInputFileLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationFileLocationFactory);
    }

    public static CombinedResult<InnerWorkflowDecryptStepDetailsFactory, T1, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1>(this CombinedResult<InnerWorkflowDecryptStepDetailsFactory, T1> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowDecryptStepDetailsFactory, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1>(this CombinedResult<T1, InnerWorkflowDecryptStepDetailsFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWorkflowDecryptStepDetailsFactory, T1, T2, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1, T2>(this CombinedResult<InnerWorkflowDecryptStepDetailsFactory, T1, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowDecryptStepDetailsFactory, T2, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1, T2>(this CombinedResult<T1, InnerWorkflowDecryptStepDetailsFactory, T2> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowDecryptStepDetailsFactory, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1, T2>(this CombinedResult<T1, T2, InnerWorkflowDecryptStepDetailsFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWorkflowDecryptStepDetailsFactory, T1, T2, T3, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1, T2, T3>(this CombinedResult<InnerWorkflowDecryptStepDetailsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowDecryptStepDetailsFactory, T2, T3, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1, T2, T3>(this CombinedResult<T1, InnerWorkflowDecryptStepDetailsFactory, T2, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowDecryptStepDetailsFactory, T3, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkflowDecryptStepDetailsFactory, T3> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkflowDecryptStepDetailsFactory, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkflowDecryptStepDetailsFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWorkflowDecryptStepDetailsFactory, T1, T2, T3, T4, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1, T2, T3, T4>(this CombinedResult<InnerWorkflowDecryptStepDetailsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkflowDecryptStepDetailsFactory, T2, T3, T4, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkflowDecryptStepDetailsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkflowDecryptStepDetailsFactory, T3, T4, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkflowDecryptStepDetailsFactory, T3, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkflowDecryptStepDetailsFactory, T4, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkflowDecryptStepDetailsFactory, T4> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWorkflowDecryptStepDetailsFactory, InnerWorkflowInputFileLocationFactory> WithDestinationFileLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkflowDecryptStepDetailsFactory> combinedResult, Action<Humidifier.Transfer.WorkflowTypes.InputFileLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationFileLocation(combinedResult.T5, subFactoryAction));
}
