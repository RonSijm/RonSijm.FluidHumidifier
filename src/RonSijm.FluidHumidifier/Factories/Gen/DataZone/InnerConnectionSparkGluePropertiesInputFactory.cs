// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionSparkGluePropertiesInputFactory(Action<Humidifier.DataZone.ConnectionTypes.SparkGluePropertiesInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.SparkGluePropertiesInput>
{

    internal InnerConnectionSparkGlueArgsFactory AdditionalArgsFactory { get; set; }

    protected override Humidifier.DataZone.ConnectionTypes.SparkGluePropertiesInput Create()
    {
        var sparkGluePropertiesInputResult = CreateSparkGluePropertiesInput();
        factoryAction?.Invoke(sparkGluePropertiesInputResult);

        return sparkGluePropertiesInputResult;
    }

    private Humidifier.DataZone.ConnectionTypes.SparkGluePropertiesInput CreateSparkGluePropertiesInput()
    {
        var sparkGluePropertiesInputResult = new Humidifier.DataZone.ConnectionTypes.SparkGluePropertiesInput();

        return sparkGluePropertiesInputResult;
    }
    public override void CreateChildren(Humidifier.DataZone.ConnectionTypes.SparkGluePropertiesInput result)
    {
        base.CreateChildren(result);

        result.AdditionalArgs ??= AdditionalArgsFactory?.Build();
    }

} // End Of Class

public static class InnerConnectionSparkGluePropertiesInputFactoryExtensions
{
    public static CombinedResult<InnerConnectionSparkGluePropertiesInputFactory, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs(this InnerConnectionSparkGluePropertiesInputFactory parentFactory, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null)
    {
        parentFactory.AdditionalArgsFactory = new InnerConnectionSparkGlueArgsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AdditionalArgsFactory);
    }

    public static CombinedResult<InnerConnectionSparkGluePropertiesInputFactory, T1, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1>(this CombinedResult<InnerConnectionSparkGluePropertiesInputFactory, T1> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionSparkGluePropertiesInputFactory, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1>(this CombinedResult<T1, InnerConnectionSparkGluePropertiesInputFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionSparkGluePropertiesInputFactory, T1, T2, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1, T2>(this CombinedResult<InnerConnectionSparkGluePropertiesInputFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionSparkGluePropertiesInputFactory, T2, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1, T2>(this CombinedResult<T1, InnerConnectionSparkGluePropertiesInputFactory, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionSparkGluePropertiesInputFactory, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1, T2>(this CombinedResult<T1, T2, InnerConnectionSparkGluePropertiesInputFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionSparkGluePropertiesInputFactory, T1, T2, T3, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1, T2, T3>(this CombinedResult<InnerConnectionSparkGluePropertiesInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionSparkGluePropertiesInputFactory, T2, T3, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1, T2, T3>(this CombinedResult<T1, InnerConnectionSparkGluePropertiesInputFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionSparkGluePropertiesInputFactory, T3, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionSparkGluePropertiesInputFactory, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionSparkGluePropertiesInputFactory, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionSparkGluePropertiesInputFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionSparkGluePropertiesInputFactory, T1, T2, T3, T4, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1, T2, T3, T4>(this CombinedResult<InnerConnectionSparkGluePropertiesInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionSparkGluePropertiesInputFactory, T2, T3, T4, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionSparkGluePropertiesInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionSparkGluePropertiesInputFactory, T3, T4, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionSparkGluePropertiesInputFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionSparkGluePropertiesInputFactory, T4, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionSparkGluePropertiesInputFactory, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionSparkGluePropertiesInputFactory, InnerConnectionSparkGlueArgsFactory> WithAdditionalArgs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionSparkGluePropertiesInputFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.SparkGlueArgs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdditionalArgs(combinedResult.T5, subFactoryAction).T2);
}
