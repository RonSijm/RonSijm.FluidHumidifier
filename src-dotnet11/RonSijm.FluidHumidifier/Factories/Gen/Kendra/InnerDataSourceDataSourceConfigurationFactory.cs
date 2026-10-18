// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceDataSourceConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration>
{

    internal InnerDataSourceTemplateConfigurationFactory TemplateConfigurationFactory { get; set; }

    protected override Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration Create()
    {
        var dataSourceConfigurationResult = CreateDataSourceConfiguration();
        factoryAction?.Invoke(dataSourceConfigurationResult);

        return dataSourceConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration CreateDataSourceConfiguration()
    {
        var dataSourceConfigurationResult = new Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration();

        return dataSourceConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Kendra.DataSourceTypes.DataSourceConfiguration result)
    {
        base.CreateChildren(result);

        result.TemplateConfiguration ??= TemplateConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceDataSourceConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceDataSourceConfigurationFactory, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration(this InnerDataSourceDataSourceConfigurationFactory parentFactory, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null)
    {
        parentFactory.TemplateConfigurationFactory = new InnerDataSourceTemplateConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TemplateConfigurationFactory);
    }

    public static CombinedResult<InnerDataSourceDataSourceConfigurationFactory, T1, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1>(this CombinedResult<InnerDataSourceDataSourceConfigurationFactory, T1> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceConfigurationFactory, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1>(this CombinedResult<T1, InnerDataSourceDataSourceConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDataSourceConfigurationFactory, T1, T2, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<InnerDataSourceDataSourceConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceConfigurationFactory, T2, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<T1, InnerDataSourceDataSourceConfigurationFactory, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDataSourceConfigurationFactory, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceDataSourceConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDataSourceConfigurationFactory, T1, T2, T3, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<InnerDataSourceDataSourceConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceConfigurationFactory, T2, T3, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceDataSourceConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDataSourceConfigurationFactory, T3, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceDataSourceConfigurationFactory, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceDataSourceConfigurationFactory, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceDataSourceConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDataSourceConfigurationFactory, T1, T2, T3, T4, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceDataSourceConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceConfigurationFactory, T2, T3, T4, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceDataSourceConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDataSourceConfigurationFactory, T3, T4, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceDataSourceConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceDataSourceConfigurationFactory, T4, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceDataSourceConfigurationFactory, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceDataSourceConfigurationFactory, InnerDataSourceTemplateConfigurationFactory> WithTemplateConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceDataSourceConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.TemplateConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTemplateConfiguration(combinedResult.T5, subFactoryAction).T2);
}
