// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerInstrumentationConfigLocationFactory(Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location>
{

    internal InnerInstrumentationConfigCodeLocationFactory CodeLocationFactory { get; set; }

    protected override Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location Create()
    {
        var locationResult = CreateLocation();
        factoryAction?.Invoke(locationResult);

        return locationResult;
    }

    private Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location CreateLocation()
    {
        var locationResult = new Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location();

        return locationResult;
    }
    public override void CreateChildren(Humidifier.ApplicationSignals.InstrumentationConfigTypes.Location result)
    {
        base.CreateChildren(result);

        result.CodeLocation ??= CodeLocationFactory?.Build();
    }

} // End Of Class

public static class InnerInstrumentationConfigLocationFactoryExtensions
{
    public static CombinedResult<InnerInstrumentationConfigLocationFactory, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation(this InnerInstrumentationConfigLocationFactory parentFactory, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null)
    {
        parentFactory.CodeLocationFactory = new InnerInstrumentationConfigCodeLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeLocationFactory);
    }

    public static CombinedResult<InnerInstrumentationConfigLocationFactory, T1, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1>(this CombinedResult<InnerInstrumentationConfigLocationFactory, T1> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstrumentationConfigLocationFactory, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1>(this CombinedResult<T1, InnerInstrumentationConfigLocationFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerInstrumentationConfigLocationFactory, T1, T2, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1, T2>(this CombinedResult<InnerInstrumentationConfigLocationFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstrumentationConfigLocationFactory, T2, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1, T2>(this CombinedResult<T1, InnerInstrumentationConfigLocationFactory, T2> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInstrumentationConfigLocationFactory, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1, T2>(this CombinedResult<T1, T2, InnerInstrumentationConfigLocationFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerInstrumentationConfigLocationFactory, T1, T2, T3, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1, T2, T3>(this CombinedResult<InnerInstrumentationConfigLocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstrumentationConfigLocationFactory, T2, T3, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1, T2, T3>(this CombinedResult<T1, InnerInstrumentationConfigLocationFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInstrumentationConfigLocationFactory, T3, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstrumentationConfigLocationFactory, T3> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInstrumentationConfigLocationFactory, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstrumentationConfigLocationFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerInstrumentationConfigLocationFactory, T1, T2, T3, T4, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1, T2, T3, T4>(this CombinedResult<InnerInstrumentationConfigLocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerInstrumentationConfigLocationFactory, T2, T3, T4, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstrumentationConfigLocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerInstrumentationConfigLocationFactory, T3, T4, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstrumentationConfigLocationFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerInstrumentationConfigLocationFactory, T4, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstrumentationConfigLocationFactory, T4> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerInstrumentationConfigLocationFactory, InnerInstrumentationConfigCodeLocationFactory> WithCodeLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstrumentationConfigLocationFactory> combinedResult, Action<Humidifier.ApplicationSignals.InstrumentationConfigTypes.CodeLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeLocation(combinedResult.T5, subFactoryAction).T2);
}
