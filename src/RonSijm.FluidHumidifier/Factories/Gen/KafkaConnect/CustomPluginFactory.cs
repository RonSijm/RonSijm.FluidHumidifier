// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KafkaConnect;

public class CustomPluginFactory(string resourceName = null, Action<Humidifier.KafkaConnect.CustomPlugin> factoryAction = null) : ResourceFactory<Humidifier.KafkaConnect.CustomPlugin>(resourceName)
{

    internal InnerCustomPluginCustomPluginLocationFactory LocationFactory { get; set; }

    protected override Humidifier.KafkaConnect.CustomPlugin Create()
    {
        var customPluginResult = CreateCustomPlugin();
        factoryAction?.Invoke(customPluginResult);

        return customPluginResult;
    }

    private Humidifier.KafkaConnect.CustomPlugin CreateCustomPlugin()
    {
        var customPluginResult = new Humidifier.KafkaConnect.CustomPlugin
        {
            GivenName = InputResourceName,
        };

        return customPluginResult;
    }
    public override void CreateChildren(Humidifier.KafkaConnect.CustomPlugin result)
    {
        base.CreateChildren(result);

        result.Location ??= LocationFactory?.Build();
    }

} // End Of Class

public static class CustomPluginFactoryExtensions
{
    public static CombinedResult<CustomPluginFactory, InnerCustomPluginCustomPluginLocationFactory> WithLocation(this CustomPluginFactory parentFactory, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null)
    {
        parentFactory.LocationFactory = new InnerCustomPluginCustomPluginLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationFactory);
    }

    public static CombinedResult<CustomPluginFactory, T1, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1>(this CombinedResult<CustomPluginFactory, T1> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomPluginFactory, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1>(this CombinedResult<T1, CustomPluginFactory> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CustomPluginFactory, T1, T2, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1, T2>(this CombinedResult<CustomPluginFactory, T1, T2> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomPluginFactory, T2, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, CustomPluginFactory, T2> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomPluginFactory, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, T2, CustomPluginFactory> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CustomPluginFactory, T1, T2, T3, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<CustomPluginFactory, T1, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomPluginFactory, T2, T3, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, CustomPluginFactory, T2, T3> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomPluginFactory, T3, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, CustomPluginFactory, T3> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CustomPluginFactory, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, CustomPluginFactory> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CustomPluginFactory, T1, T2, T3, T4, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<CustomPluginFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CustomPluginFactory, T2, T3, T4, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, CustomPluginFactory, T2, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CustomPluginFactory, T3, T4, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, CustomPluginFactory, T3, T4> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CustomPluginFactory, T4, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CustomPluginFactory, T4> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CustomPluginFactory, InnerCustomPluginCustomPluginLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CustomPluginFactory> combinedResult, Action<Humidifier.KafkaConnect.CustomPluginTypes.CustomPluginLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T5, subFactoryAction));
}
