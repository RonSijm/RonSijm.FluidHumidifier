// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class IndexFactory(string resourceName = null, Action<Humidifier.QBusiness.Index> factoryAction = null) : ResourceFactory<Humidifier.QBusiness.Index>(resourceName)
{

    internal List<InnerIndexDocumentAttributeConfigurationFactory> DocumentAttributeConfigurationsFactories { get; set; } = [];

    internal InnerIndexIndexCapacityConfigurationFactory CapacityConfigurationFactory { get; set; }

    protected override Humidifier.QBusiness.Index Create()
    {
        var indexResult = CreateIndex();
        factoryAction?.Invoke(indexResult);

        return indexResult;
    }

    private Humidifier.QBusiness.Index CreateIndex()
    {
        var indexResult = new Humidifier.QBusiness.Index
        {
            GivenName = InputResourceName,
        };

        return indexResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.Index result)
    {
        base.CreateChildren(result);

        result.DocumentAttributeConfigurations = DocumentAttributeConfigurationsFactories.Any() ? DocumentAttributeConfigurationsFactories.Select(x => x.Build()).ToList() : null;
        result.CapacityConfiguration ??= CapacityConfigurationFactory?.Build();
    }

} // End Of Class

public static class IndexFactoryExtensions
{
    public static CombinedResult<IndexFactory, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations(this IndexFactory parentFactory, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null)
    {
        var factory = new InnerIndexDocumentAttributeConfigurationFactory(subFactoryAction);
        parentFactory.DocumentAttributeConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IndexFactory, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration(this IndexFactory parentFactory, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null)
    {
        parentFactory.CapacityConfigurationFactory = new InnerIndexIndexCapacityConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityConfigurationFactory);
    }

    public static CombinedResult<IndexFactory, T1, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1>(this CombinedResult<IndexFactory, T1> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1>(this CombinedResult<T1, IndexFactory> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1, T2>(this CombinedResult<IndexFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1, T2>(this CombinedResult<T1, IndexFactory, T2> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1, T2>(this CombinedResult<T1, T2, IndexFactory> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, T3, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1, T2, T3>(this CombinedResult<IndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, T3, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1, T2, T3>(this CombinedResult<T1, IndexFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, T3, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, IndexFactory, T3> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IndexFactory, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, IndexFactory> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, T3, T4, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1, T2, T3, T4>(this CombinedResult<IndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, T3, T4, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, IndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, T3, T4, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, IndexFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IndexFactory, T4, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IndexFactory, T4> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IndexFactory, InnerIndexDocumentAttributeConfigurationFactory> WithDocumentAttributeConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IndexFactory> combinedResult, Action<Humidifier.QBusiness.IndexTypes.DocumentAttributeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentAttributeConfigurations(combinedResult.T5, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1>(this CombinedResult<IndexFactory, T1> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1>(this CombinedResult<T1, IndexFactory> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1, T2>(this CombinedResult<IndexFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1, T2>(this CombinedResult<T1, IndexFactory, T2> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1, T2>(this CombinedResult<T1, T2, IndexFactory> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, T3, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1, T2, T3>(this CombinedResult<IndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, T3, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1, T2, T3>(this CombinedResult<T1, IndexFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, T3, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, IndexFactory, T3> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IndexFactory, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, IndexFactory> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, T3, T4, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<IndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, T3, T4, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, IndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, T3, T4, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, IndexFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IndexFactory, T4, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IndexFactory, T4> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IndexFactory, InnerIndexIndexCapacityConfigurationFactory> WithCapacityConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IndexFactory> combinedResult, Action<Humidifier.QBusiness.IndexTypes.IndexCapacityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityConfiguration(combinedResult.T5, subFactoryAction));
}
