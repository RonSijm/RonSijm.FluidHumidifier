// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceWebSourceConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.WebSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.WebSourceConfiguration>
{

    internal InnerDataSourceUrlConfigurationFactory UrlConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.DataSourceTypes.WebSourceConfiguration Create()
    {
        var webSourceConfigurationResult = CreateWebSourceConfiguration();
        factoryAction?.Invoke(webSourceConfigurationResult);

        return webSourceConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.WebSourceConfiguration CreateWebSourceConfiguration()
    {
        var webSourceConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.WebSourceConfiguration();

        return webSourceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataSourceTypes.WebSourceConfiguration result)
    {
        base.CreateChildren(result);

        result.UrlConfiguration ??= UrlConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceWebSourceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceWebSourceConfigurationFactory, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration(this InnerDataSourceWebSourceConfigurationFactory parentFactory, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null)
    {
        parentFactory.UrlConfigurationFactory = new InnerDataSourceUrlConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UrlConfigurationFactory);
    }

    public static CombinedResult<InnerDataSourceWebSourceConfigurationFactory, T1, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1>(this CombinedResult<InnerDataSourceWebSourceConfigurationFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceWebSourceConfigurationFactory, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1>(this CombinedResult<T1, InnerDataSourceWebSourceConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceWebSourceConfigurationFactory, T1, T2, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1, T2>(this CombinedResult<InnerDataSourceWebSourceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceWebSourceConfigurationFactory, T2, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1, T2>(this CombinedResult<T1, InnerDataSourceWebSourceConfigurationFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceWebSourceConfigurationFactory, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceWebSourceConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceWebSourceConfigurationFactory, T1, T2, T3, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3>(this CombinedResult<InnerDataSourceWebSourceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceWebSourceConfigurationFactory, T2, T3, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceWebSourceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceWebSourceConfigurationFactory, T3, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceWebSourceConfigurationFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceWebSourceConfigurationFactory, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceWebSourceConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceWebSourceConfigurationFactory, T1, T2, T3, T4, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceWebSourceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceWebSourceConfigurationFactory, T2, T3, T4, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceWebSourceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceWebSourceConfigurationFactory, T3, T4, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceWebSourceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceWebSourceConfigurationFactory, T4, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceWebSourceConfigurationFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceWebSourceConfigurationFactory, InnerDataSourceUrlConfigurationFactory> WithUrlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceWebSourceConfigurationFactory> combinedResult, Action<Humidifier.Bedrock.DataSourceTypes.UrlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUrlConfiguration(combinedResult.T5, subFactoryAction));
}
