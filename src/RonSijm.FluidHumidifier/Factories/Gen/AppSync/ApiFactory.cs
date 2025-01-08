// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppSync;

public class ApiFactory(string resourceName = null, Action<Humidifier.AppSync.Api> factoryAction = null) : ResourceFactory<Humidifier.AppSync.Api>(resourceName)
{

    internal InnerApiEventConfigFactory EventConfigFactory { get; set; }

    protected override Humidifier.AppSync.Api Create()
    {
        var apiResult = CreateApi();
        factoryAction?.Invoke(apiResult);

        return apiResult;
    }

    private Humidifier.AppSync.Api CreateApi()
    {
        var apiResult = new Humidifier.AppSync.Api
        {
            GivenName = InputResourceName,
        };

        return apiResult;
    }
    public override void CreateChildren(Humidifier.AppSync.Api result)
    {
        base.CreateChildren(result);

        result.EventConfig ??= EventConfigFactory?.Build();
    }

} // End Of Class

public static class ApiFactoryExtensions
{
    public static CombinedResult<ApiFactory, InnerApiEventConfigFactory> WithEventConfig(this ApiFactory parentFactory, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null)
    {
        parentFactory.EventConfigFactory = new InnerApiEventConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventConfigFactory);
    }

    public static CombinedResult<ApiFactory, T1, InnerApiEventConfigFactory> WithEventConfig<T1>(this CombinedResult<ApiFactory, T1> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiFactory, InnerApiEventConfigFactory> WithEventConfig<T1>(this CombinedResult<T1, ApiFactory> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApiFactory, T1, T2, InnerApiEventConfigFactory> WithEventConfig<T1, T2>(this CombinedResult<ApiFactory, T1, T2> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiFactory, T2, InnerApiEventConfigFactory> WithEventConfig<T1, T2>(this CombinedResult<T1, ApiFactory, T2> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApiFactory, InnerApiEventConfigFactory> WithEventConfig<T1, T2>(this CombinedResult<T1, T2, ApiFactory> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApiFactory, T1, T2, T3, InnerApiEventConfigFactory> WithEventConfig<T1, T2, T3>(this CombinedResult<ApiFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiFactory, T2, T3, InnerApiEventConfigFactory> WithEventConfig<T1, T2, T3>(this CombinedResult<T1, ApiFactory, T2, T3> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApiFactory, T3, InnerApiEventConfigFactory> WithEventConfig<T1, T2, T3>(this CombinedResult<T1, T2, ApiFactory, T3> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApiFactory, InnerApiEventConfigFactory> WithEventConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApiFactory> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApiFactory, T1, T2, T3, T4, InnerApiEventConfigFactory> WithEventConfig<T1, T2, T3, T4>(this CombinedResult<ApiFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApiFactory, T2, T3, T4, InnerApiEventConfigFactory> WithEventConfig<T1, T2, T3, T4>(this CombinedResult<T1, ApiFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApiFactory, T3, T4, InnerApiEventConfigFactory> WithEventConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApiFactory, T3, T4> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApiFactory, T4, InnerApiEventConfigFactory> WithEventConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApiFactory, T4> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApiFactory, InnerApiEventConfigFactory> WithEventConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApiFactory> combinedResult, Action<Humidifier.AppSync.ApiTypes.EventConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventConfig(combinedResult.T5, subFactoryAction));
}
