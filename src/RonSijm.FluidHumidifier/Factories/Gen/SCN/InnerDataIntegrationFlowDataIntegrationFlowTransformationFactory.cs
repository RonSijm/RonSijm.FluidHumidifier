// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory(Action<Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTransformation> factoryAction = null) : SubResourceFactory<Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTransformation>
{

    internal InnerDataIntegrationFlowSqlTransformationConfigurationFactory SqlTransformationFactory { get; set; }

    protected override Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTransformation Create()
    {
        var dataIntegrationFlowTransformationResult = CreateDataIntegrationFlowTransformation();
        factoryAction?.Invoke(dataIntegrationFlowTransformationResult);

        return dataIntegrationFlowTransformationResult;
    }

    private Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTransformation CreateDataIntegrationFlowTransformation()
    {
        var dataIntegrationFlowTransformationResult = new Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTransformation();

        return dataIntegrationFlowTransformationResult;
    }
    public override void CreateChildren(Humidifier.SCN.DataIntegrationFlowTypes.DataIntegrationFlowTransformation result)
    {
        base.CreateChildren(result);

        result.SqlTransformation ??= SqlTransformationFactory?.Build();
    }

} // End Of Class

public static class InnerDataIntegrationFlowDataIntegrationFlowTransformationFactoryExtensions
{
    public static CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation(this InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory parentFactory, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null)
    {
        parentFactory.SqlTransformationFactory = new InnerDataIntegrationFlowSqlTransformationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SqlTransformationFactory);
    }

    public static CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T1, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1>(this CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T1> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSqlTransformation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1>(this CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSqlTransformation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T1, T2, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1, T2>(this CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T1, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSqlTransformation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T2, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1, T2>(this CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T2> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSqlTransformation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1, T2>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSqlTransformation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T1, T2, T3, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1, T2, T3>(this CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSqlTransformation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T2, T3, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1, T2, T3>(this CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T2, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSqlTransformation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T3, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T3> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSqlTransformation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSqlTransformation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T1, T2, T3, T4, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1, T2, T3, T4>(this CombinedResult<InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlTransformation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T2, T3, T4, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlTransformation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T3, T4, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T3, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlTransformation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T4, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, T4> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlTransformation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory, InnerDataIntegrationFlowSqlTransformationConfigurationFactory> WithSqlTransformation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataIntegrationFlowDataIntegrationFlowTransformationFactory> combinedResult, Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSqlTransformation(combinedResult.T5, subFactoryAction).T2);
}
