// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerConnectionGluePropertiesInputFactory(Action<Humidifier.DataZone.ConnectionTypes.GluePropertiesInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ConnectionTypes.GluePropertiesInput>
{

    internal InnerConnectionGlueConnectionInputFactory GlueConnectionInputFactory { get; set; }

    protected override Humidifier.DataZone.ConnectionTypes.GluePropertiesInput Create()
    {
        var gluePropertiesInputResult = CreateGluePropertiesInput();
        factoryAction?.Invoke(gluePropertiesInputResult);

        return gluePropertiesInputResult;
    }

    private Humidifier.DataZone.ConnectionTypes.GluePropertiesInput CreateGluePropertiesInput()
    {
        var gluePropertiesInputResult = new Humidifier.DataZone.ConnectionTypes.GluePropertiesInput();

        return gluePropertiesInputResult;
    }
    public override void CreateChildren(Humidifier.DataZone.ConnectionTypes.GluePropertiesInput result)
    {
        base.CreateChildren(result);

        result.GlueConnectionInput ??= GlueConnectionInputFactory?.Build();
    }

} // End Of Class

public static class InnerConnectionGluePropertiesInputFactoryExtensions
{
    public static CombinedResult<InnerConnectionGluePropertiesInputFactory, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput(this InnerConnectionGluePropertiesInputFactory parentFactory, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null)
    {
        parentFactory.GlueConnectionInputFactory = new InnerConnectionGlueConnectionInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GlueConnectionInputFactory);
    }

    public static CombinedResult<InnerConnectionGluePropertiesInputFactory, T1, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1>(this CombinedResult<InnerConnectionGluePropertiesInputFactory, T1> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionGluePropertiesInputFactory, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1>(this CombinedResult<T1, InnerConnectionGluePropertiesInputFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionGluePropertiesInputFactory, T1, T2, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1, T2>(this CombinedResult<InnerConnectionGluePropertiesInputFactory, T1, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionGluePropertiesInputFactory, T2, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1, T2>(this CombinedResult<T1, InnerConnectionGluePropertiesInputFactory, T2> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionGluePropertiesInputFactory, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1, T2>(this CombinedResult<T1, T2, InnerConnectionGluePropertiesInputFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionGluePropertiesInputFactory, T1, T2, T3, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1, T2, T3>(this CombinedResult<InnerConnectionGluePropertiesInputFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionGluePropertiesInputFactory, T2, T3, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1, T2, T3>(this CombinedResult<T1, InnerConnectionGluePropertiesInputFactory, T2, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionGluePropertiesInputFactory, T3, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1, T2, T3>(this CombinedResult<T1, T2, InnerConnectionGluePropertiesInputFactory, T3> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionGluePropertiesInputFactory, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConnectionGluePropertiesInputFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerConnectionGluePropertiesInputFactory, T1, T2, T3, T4, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1, T2, T3, T4>(this CombinedResult<InnerConnectionGluePropertiesInputFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerConnectionGluePropertiesInputFactory, T2, T3, T4, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1, T2, T3, T4>(this CombinedResult<T1, InnerConnectionGluePropertiesInputFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerConnectionGluePropertiesInputFactory, T3, T4, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConnectionGluePropertiesInputFactory, T3, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerConnectionGluePropertiesInputFactory, T4, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConnectionGluePropertiesInputFactory, T4> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerConnectionGluePropertiesInputFactory, InnerConnectionGlueConnectionInputFactory> WithGlueConnectionInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConnectionGluePropertiesInputFactory> combinedResult, Action<Humidifier.DataZone.ConnectionTypes.GlueConnectionInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlueConnectionInput(combinedResult.T5, subFactoryAction).T2);
}
