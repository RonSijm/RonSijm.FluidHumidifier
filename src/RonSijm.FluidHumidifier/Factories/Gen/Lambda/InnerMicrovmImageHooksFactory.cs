// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerMicrovmImageHooksFactory(Action<Humidifier.Lambda.MicrovmImageTypes.Hooks> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.MicrovmImageTypes.Hooks>
{

    internal InnerMicrovmImageMicrovmImageHooksFactory MicrovmImageHooksFactory { get; set; }

    internal InnerMicrovmImageMicrovmHooksFactory MicrovmHooksFactory { get; set; }

    protected override Humidifier.Lambda.MicrovmImageTypes.Hooks Create()
    {
        var hooksResult = CreateHooks();
        factoryAction?.Invoke(hooksResult);

        return hooksResult;
    }

    private Humidifier.Lambda.MicrovmImageTypes.Hooks CreateHooks()
    {
        var hooksResult = new Humidifier.Lambda.MicrovmImageTypes.Hooks();

        return hooksResult;
    }
    public override void CreateChildren(Humidifier.Lambda.MicrovmImageTypes.Hooks result)
    {
        base.CreateChildren(result);

        result.MicrovmImageHooks ??= MicrovmImageHooksFactory?.Build();
        result.MicrovmHooks ??= MicrovmHooksFactory?.Build();
    }

} // End Of Class

public static class InnerMicrovmImageHooksFactoryExtensions
{
    public static CombinedResult<InnerMicrovmImageHooksFactory, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks(this InnerMicrovmImageHooksFactory parentFactory, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null)
    {
        parentFactory.MicrovmImageHooksFactory = new InnerMicrovmImageMicrovmImageHooksFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MicrovmImageHooksFactory);
    }

    public static CombinedResult<InnerMicrovmImageHooksFactory, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks(this InnerMicrovmImageHooksFactory parentFactory, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null)
    {
        parentFactory.MicrovmHooksFactory = new InnerMicrovmImageMicrovmHooksFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MicrovmHooksFactory);
    }

    public static CombinedResult<InnerMicrovmImageHooksFactory, T1, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1>(this CombinedResult<InnerMicrovmImageHooksFactory, T1> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMicrovmImageHooksFactory, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1>(this CombinedResult<T1, InnerMicrovmImageHooksFactory> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMicrovmImageHooksFactory, T1, T2, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1, T2>(this CombinedResult<InnerMicrovmImageHooksFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMicrovmImageHooksFactory, T2, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1, T2>(this CombinedResult<T1, InnerMicrovmImageHooksFactory, T2> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMicrovmImageHooksFactory, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1, T2>(this CombinedResult<T1, T2, InnerMicrovmImageHooksFactory> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMicrovmImageHooksFactory, T1, T2, T3, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1, T2, T3>(this CombinedResult<InnerMicrovmImageHooksFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMicrovmImageHooksFactory, T2, T3, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1, T2, T3>(this CombinedResult<T1, InnerMicrovmImageHooksFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMicrovmImageHooksFactory, T3, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1, T2, T3>(this CombinedResult<T1, T2, InnerMicrovmImageHooksFactory, T3> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMicrovmImageHooksFactory, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMicrovmImageHooksFactory> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMicrovmImageHooksFactory, T1, T2, T3, T4, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1, T2, T3, T4>(this CombinedResult<InnerMicrovmImageHooksFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMicrovmImageHooksFactory, T2, T3, T4, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1, T2, T3, T4>(this CombinedResult<T1, InnerMicrovmImageHooksFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMicrovmImageHooksFactory, T3, T4, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMicrovmImageHooksFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMicrovmImageHooksFactory, T4, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMicrovmImageHooksFactory, T4> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMicrovmImageHooksFactory, InnerMicrovmImageMicrovmImageHooksFactory> WithMicrovmImageHooks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMicrovmImageHooksFactory> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmImageHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmImageHooks(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerMicrovmImageHooksFactory, T1, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1>(this CombinedResult<InnerMicrovmImageHooksFactory, T1> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMicrovmImageHooksFactory, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1>(this CombinedResult<T1, InnerMicrovmImageHooksFactory> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMicrovmImageHooksFactory, T1, T2, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1, T2>(this CombinedResult<InnerMicrovmImageHooksFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMicrovmImageHooksFactory, T2, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1, T2>(this CombinedResult<T1, InnerMicrovmImageHooksFactory, T2> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMicrovmImageHooksFactory, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1, T2>(this CombinedResult<T1, T2, InnerMicrovmImageHooksFactory> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMicrovmImageHooksFactory, T1, T2, T3, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1, T2, T3>(this CombinedResult<InnerMicrovmImageHooksFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMicrovmImageHooksFactory, T2, T3, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1, T2, T3>(this CombinedResult<T1, InnerMicrovmImageHooksFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMicrovmImageHooksFactory, T3, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1, T2, T3>(this CombinedResult<T1, T2, InnerMicrovmImageHooksFactory, T3> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMicrovmImageHooksFactory, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMicrovmImageHooksFactory> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMicrovmImageHooksFactory, T1, T2, T3, T4, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1, T2, T3, T4>(this CombinedResult<InnerMicrovmImageHooksFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMicrovmImageHooksFactory, T2, T3, T4, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1, T2, T3, T4>(this CombinedResult<T1, InnerMicrovmImageHooksFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMicrovmImageHooksFactory, T3, T4, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMicrovmImageHooksFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMicrovmImageHooksFactory, T4, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMicrovmImageHooksFactory, T4> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMicrovmImageHooksFactory, InnerMicrovmImageMicrovmHooksFactory> WithMicrovmHooks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMicrovmImageHooksFactory> combinedResult, Action<Humidifier.Lambda.MicrovmImageTypes.MicrovmHooks> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMicrovmHooks(combinedResult.T5, subFactoryAction).T2);
}
