// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataSourceMediaExtractionConfigurationFactory(Action<Humidifier.QBusiness.DataSourceTypes.MediaExtractionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataSourceTypes.MediaExtractionConfiguration>
{

    internal InnerDataSourceImageExtractionConfigurationFactory ImageExtractionConfigurationFactory { get; set; }

    protected override Humidifier.QBusiness.DataSourceTypes.MediaExtractionConfiguration Create()
    {
        var mediaExtractionConfigurationResult = CreateMediaExtractionConfiguration();
        factoryAction?.Invoke(mediaExtractionConfigurationResult);

        return mediaExtractionConfigurationResult;
    }

    private Humidifier.QBusiness.DataSourceTypes.MediaExtractionConfiguration CreateMediaExtractionConfiguration()
    {
        var mediaExtractionConfigurationResult = new Humidifier.QBusiness.DataSourceTypes.MediaExtractionConfiguration();

        return mediaExtractionConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.DataSourceTypes.MediaExtractionConfiguration result)
    {
        base.CreateChildren(result);

        result.ImageExtractionConfiguration ??= ImageExtractionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceMediaExtractionConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceMediaExtractionConfigurationFactory, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration(this InnerDataSourceMediaExtractionConfigurationFactory parentFactory, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null)
    {
        parentFactory.ImageExtractionConfigurationFactory = new InnerDataSourceImageExtractionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ImageExtractionConfigurationFactory);
    }

    public static CombinedResult<InnerDataSourceMediaExtractionConfigurationFactory, T1, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1>(this CombinedResult<InnerDataSourceMediaExtractionConfigurationFactory, T1> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceMediaExtractionConfigurationFactory, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1>(this CombinedResult<T1, InnerDataSourceMediaExtractionConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceMediaExtractionConfigurationFactory, T1, T2, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1, T2>(this CombinedResult<InnerDataSourceMediaExtractionConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceMediaExtractionConfigurationFactory, T2, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1, T2>(this CombinedResult<T1, InnerDataSourceMediaExtractionConfigurationFactory, T2> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceMediaExtractionConfigurationFactory, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceMediaExtractionConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceMediaExtractionConfigurationFactory, T1, T2, T3, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1, T2, T3>(this CombinedResult<InnerDataSourceMediaExtractionConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceMediaExtractionConfigurationFactory, T2, T3, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceMediaExtractionConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceMediaExtractionConfigurationFactory, T3, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceMediaExtractionConfigurationFactory, T3> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceMediaExtractionConfigurationFactory, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceMediaExtractionConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceMediaExtractionConfigurationFactory, T1, T2, T3, T4, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceMediaExtractionConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceMediaExtractionConfigurationFactory, T2, T3, T4, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceMediaExtractionConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceMediaExtractionConfigurationFactory, T3, T4, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceMediaExtractionConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceMediaExtractionConfigurationFactory, T4, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceMediaExtractionConfigurationFactory, T4> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceMediaExtractionConfigurationFactory, InnerDataSourceImageExtractionConfigurationFactory> WithImageExtractionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceMediaExtractionConfigurationFactory> combinedResult, Action<Humidifier.QBusiness.DataSourceTypes.ImageExtractionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImageExtractionConfiguration(combinedResult.T5, subFactoryAction));
}
