// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class HoursOfOperationFactory(string resourceName = null, Action<Humidifier.Connect.HoursOfOperation> factoryAction = null) : ResourceFactory<Humidifier.Connect.HoursOfOperation>(resourceName)
{

    internal List<InnerHoursOfOperationHoursOfOperationConfigFactory> ConfigFactories { get; set; } = [];

    protected override Humidifier.Connect.HoursOfOperation Create()
    {
        var hoursOfOperationResult = CreateHoursOfOperation();
        factoryAction?.Invoke(hoursOfOperationResult);

        return hoursOfOperationResult;
    }

    private Humidifier.Connect.HoursOfOperation CreateHoursOfOperation()
    {
        var hoursOfOperationResult = new Humidifier.Connect.HoursOfOperation
        {
            GivenName = InputResourceName,
        };

        return hoursOfOperationResult;
    }
    public override void CreateChildren(Humidifier.Connect.HoursOfOperation result)
    {
        base.CreateChildren(result);

        result.Config = ConfigFactories.Any() ? ConfigFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class HoursOfOperationFactoryExtensions
{
    public static CombinedResult<HoursOfOperationFactory, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig(this HoursOfOperationFactory parentFactory, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null)
    {
        var factory = new InnerHoursOfOperationHoursOfOperationConfigFactory(subFactoryAction);
        parentFactory.ConfigFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<HoursOfOperationFactory, T1, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1>(this CombinedResult<HoursOfOperationFactory, T1> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HoursOfOperationFactory, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1>(this CombinedResult<T1, HoursOfOperationFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<HoursOfOperationFactory, T1, T2, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1, T2>(this CombinedResult<HoursOfOperationFactory, T1, T2> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HoursOfOperationFactory, T2, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1, T2>(this CombinedResult<T1, HoursOfOperationFactory, T2> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, HoursOfOperationFactory, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1, T2>(this CombinedResult<T1, T2, HoursOfOperationFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<HoursOfOperationFactory, T1, T2, T3, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1, T2, T3>(this CombinedResult<HoursOfOperationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HoursOfOperationFactory, T2, T3, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, HoursOfOperationFactory, T2, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, HoursOfOperationFactory, T3, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, T2, HoursOfOperationFactory, T3> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, HoursOfOperationFactory, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, HoursOfOperationFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<HoursOfOperationFactory, T1, T2, T3, T4, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<HoursOfOperationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, HoursOfOperationFactory, T2, T3, T4, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, HoursOfOperationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, HoursOfOperationFactory, T3, T4, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, HoursOfOperationFactory, T3, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, HoursOfOperationFactory, T4, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, HoursOfOperationFactory, T4> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, HoursOfOperationFactory, InnerHoursOfOperationHoursOfOperationConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, HoursOfOperationFactory> combinedResult, Action<Humidifier.Connect.HoursOfOperationTypes.HoursOfOperationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T5, subFactoryAction));
}
