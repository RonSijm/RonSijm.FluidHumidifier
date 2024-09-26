// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerPluginCustomPluginConfigurationFactory(Action<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration>
{

    internal InnerPluginAPISchemaFactory ApiSchemaFactory { get; set; }

    protected override Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration Create()
    {
        var customPluginConfigurationResult = CreateCustomPluginConfiguration();
        factoryAction?.Invoke(customPluginConfigurationResult);

        return customPluginConfigurationResult;
    }

    private Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration CreateCustomPluginConfiguration()
    {
        var customPluginConfigurationResult = new Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration();

        return customPluginConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.PluginTypes.CustomPluginConfiguration result)
    {
        base.CreateChildren(result);

        result.ApiSchema ??= ApiSchemaFactory?.Build();
    }

} // End Of Class

public static class InnerPluginCustomPluginConfigurationFactoryExtensions
{
    public static CombinedResult<InnerPluginCustomPluginConfigurationFactory, InnerPluginAPISchemaFactory> WithApiSchema(this InnerPluginCustomPluginConfigurationFactory parentFactory, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null)
    {
        parentFactory.ApiSchemaFactory = new InnerPluginAPISchemaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApiSchemaFactory);
    }

    public static CombinedResult<InnerPluginCustomPluginConfigurationFactory, T1, InnerPluginAPISchemaFactory> WithApiSchema<T1>(this CombinedResult<InnerPluginCustomPluginConfigurationFactory, T1> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPluginCustomPluginConfigurationFactory, InnerPluginAPISchemaFactory> WithApiSchema<T1>(this CombinedResult<T1, InnerPluginCustomPluginConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPluginCustomPluginConfigurationFactory, T1, T2, InnerPluginAPISchemaFactory> WithApiSchema<T1, T2>(this CombinedResult<InnerPluginCustomPluginConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPluginCustomPluginConfigurationFactory, T2, InnerPluginAPISchemaFactory> WithApiSchema<T1, T2>(this CombinedResult<T1, InnerPluginCustomPluginConfigurationFactory, T2> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPluginCustomPluginConfigurationFactory, InnerPluginAPISchemaFactory> WithApiSchema<T1, T2>(this CombinedResult<T1, T2, InnerPluginCustomPluginConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPluginCustomPluginConfigurationFactory, T1, T2, T3, InnerPluginAPISchemaFactory> WithApiSchema<T1, T2, T3>(this CombinedResult<InnerPluginCustomPluginConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPluginCustomPluginConfigurationFactory, T2, T3, InnerPluginAPISchemaFactory> WithApiSchema<T1, T2, T3>(this CombinedResult<T1, InnerPluginCustomPluginConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPluginCustomPluginConfigurationFactory, T3, InnerPluginAPISchemaFactory> WithApiSchema<T1, T2, T3>(this CombinedResult<T1, T2, InnerPluginCustomPluginConfigurationFactory, T3> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPluginCustomPluginConfigurationFactory, InnerPluginAPISchemaFactory> WithApiSchema<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPluginCustomPluginConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiSchema(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPluginCustomPluginConfigurationFactory, T1, T2, T3, T4, InnerPluginAPISchemaFactory> WithApiSchema<T1, T2, T3, T4>(this CombinedResult<InnerPluginCustomPluginConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiSchema(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPluginCustomPluginConfigurationFactory, T2, T3, T4, InnerPluginAPISchemaFactory> WithApiSchema<T1, T2, T3, T4>(this CombinedResult<T1, InnerPluginCustomPluginConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiSchema(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPluginCustomPluginConfigurationFactory, T3, T4, InnerPluginAPISchemaFactory> WithApiSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPluginCustomPluginConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiSchema(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPluginCustomPluginConfigurationFactory, T4, InnerPluginAPISchemaFactory> WithApiSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPluginCustomPluginConfigurationFactory, T4> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiSchema(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPluginCustomPluginConfigurationFactory, InnerPluginAPISchemaFactory> WithApiSchema<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPluginCustomPluginConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.PluginTypes.APISchema> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiSchema(combinedResult.T5, subFactoryAction));
}
