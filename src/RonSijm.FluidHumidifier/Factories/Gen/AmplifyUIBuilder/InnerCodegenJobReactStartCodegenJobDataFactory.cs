// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerCodegenJobReactStartCodegenJobDataFactory(Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData>
{

    internal InnerCodegenJobApiConfigurationFactory ApiConfigurationFactory { get; set; }

    protected override Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData Create()
    {
        var reactStartCodegenJobDataResult = CreateReactStartCodegenJobData();
        factoryAction?.Invoke(reactStartCodegenJobDataResult);

        return reactStartCodegenJobDataResult;
    }

    private Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData CreateReactStartCodegenJobData()
    {
        var reactStartCodegenJobDataResult = new Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData();

        return reactStartCodegenJobDataResult;
    }
    public override void CreateChildren(Humidifier.AmplifyUIBuilder.CodegenJobTypes.ReactStartCodegenJobData result)
    {
        base.CreateChildren(result);

        result.ApiConfiguration ??= ApiConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerCodegenJobReactStartCodegenJobDataFactoryExtensions
{
    public static CombinedResult<InnerCodegenJobReactStartCodegenJobDataFactory, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration(this InnerCodegenJobReactStartCodegenJobDataFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null)
    {
        parentFactory.ApiConfigurationFactory = new InnerCodegenJobApiConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApiConfigurationFactory);
    }

    public static CombinedResult<InnerCodegenJobReactStartCodegenJobDataFactory, T1, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1>(this CombinedResult<InnerCodegenJobReactStartCodegenJobDataFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodegenJobReactStartCodegenJobDataFactory, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1>(this CombinedResult<T1, InnerCodegenJobReactStartCodegenJobDataFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCodegenJobReactStartCodegenJobDataFactory, T1, T2, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1, T2>(this CombinedResult<InnerCodegenJobReactStartCodegenJobDataFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodegenJobReactStartCodegenJobDataFactory, T2, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1, T2>(this CombinedResult<T1, InnerCodegenJobReactStartCodegenJobDataFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodegenJobReactStartCodegenJobDataFactory, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerCodegenJobReactStartCodegenJobDataFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCodegenJobReactStartCodegenJobDataFactory, T1, T2, T3, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1, T2, T3>(this CombinedResult<InnerCodegenJobReactStartCodegenJobDataFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodegenJobReactStartCodegenJobDataFactory, T2, T3, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerCodegenJobReactStartCodegenJobDataFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodegenJobReactStartCodegenJobDataFactory, T3, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerCodegenJobReactStartCodegenJobDataFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCodegenJobReactStartCodegenJobDataFactory, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCodegenJobReactStartCodegenJobDataFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCodegenJobReactStartCodegenJobDataFactory, T1, T2, T3, T4, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerCodegenJobReactStartCodegenJobDataFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCodegenJobReactStartCodegenJobDataFactory, T2, T3, T4, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerCodegenJobReactStartCodegenJobDataFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCodegenJobReactStartCodegenJobDataFactory, T3, T4, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCodegenJobReactStartCodegenJobDataFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCodegenJobReactStartCodegenJobDataFactory, T4, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCodegenJobReactStartCodegenJobDataFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCodegenJobReactStartCodegenJobDataFactory, InnerCodegenJobApiConfigurationFactory> WithApiConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCodegenJobReactStartCodegenJobDataFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.CodegenJobTypes.ApiConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiConfiguration(combinedResult.T5, subFactoryAction).T2);
}
