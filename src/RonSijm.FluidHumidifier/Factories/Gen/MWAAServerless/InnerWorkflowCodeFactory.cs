// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MWAAServerless;

public class InnerWorkflowCodeFactory(Action<Humidifier.MWAAServerless.WorkflowTypes.Code> factoryAction = null) : SubResourceFactory<Humidifier.MWAAServerless.WorkflowTypes.Code>
{

    internal InnerWorkflowCodeS3LocationFactory S3LocationFactory { get; set; }

    protected override Humidifier.MWAAServerless.WorkflowTypes.Code Create()
    {
        var codeResult = CreateCode();
        factoryAction?.Invoke(codeResult);

        return codeResult;
    }

    private Humidifier.MWAAServerless.WorkflowTypes.Code CreateCode()
    {
        var codeResult = new Humidifier.MWAAServerless.WorkflowTypes.Code();

        return codeResult;
    }
    public override void CreateChildren(Humidifier.MWAAServerless.WorkflowTypes.Code result)
    {
        base.CreateChildren(result);

        result.S3Location ??= S3LocationFactory?.Build();
    }

} // End Of Class

public static class InnerWorkflowCodeFactoryExtensions
{
    public static CombinedResult<InnerWorkflowCodeFactory, InnerWorkflowCodeS3LocationFactory> WithS3Location(this InnerWorkflowCodeFactory parentFactory, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null)
    {
        parentFactory.S3LocationFactory = new InnerWorkflowCodeS3LocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3LocationFactory);
    }

    public static CombinedResult<InnerWorkflowCodeFactory, T1, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1>(this CombinedResult<InnerWorkflowCodeFactory, T1> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkflowCodeFactory, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1>(this CombinedResult<T1, InnerWorkflowCodeFactory> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWorkflowCodeFactory, T1, T2, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<InnerWorkflowCodeFactory, T1, T2> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkflowCodeFactory, T2, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, InnerWorkflowCodeFactory, T2> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkflowCodeFactory, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1, T2>(this CombinedResult<T1, T2, InnerWorkflowCodeFactory> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWorkflowCodeFactory, T1, T2, T3, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<InnerWorkflowCodeFactory, T1, T2, T3> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkflowCodeFactory, T2, T3, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, InnerWorkflowCodeFactory, T2, T3> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkflowCodeFactory, T3, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkflowCodeFactory, T3> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkflowCodeFactory, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkflowCodeFactory> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWorkflowCodeFactory, T1, T2, T3, T4, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<InnerWorkflowCodeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWorkflowCodeFactory, T2, T3, T4, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkflowCodeFactory, T2, T3, T4> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWorkflowCodeFactory, T3, T4, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkflowCodeFactory, T3, T4> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWorkflowCodeFactory, T4, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkflowCodeFactory, T4> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWorkflowCodeFactory, InnerWorkflowCodeS3LocationFactory> WithS3Location<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkflowCodeFactory> combinedResult, Action<Humidifier.MWAAServerless.WorkflowTypes.CodeS3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3Location(combinedResult.T5, subFactoryAction).T2);
}
