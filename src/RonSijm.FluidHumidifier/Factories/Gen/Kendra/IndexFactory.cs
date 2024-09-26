// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class IndexFactory(string resourceName = null, Action<Humidifier.Kendra.Index> factoryAction = null) : ResourceFactory<Humidifier.Kendra.Index>(resourceName)
{

    internal List<InnerIndexDocumentMetadataConfigurationFactory> DocumentMetadataConfigurationsFactories { get; set; } = [];

    internal List<InnerIndexUserTokenConfigurationFactory> UserTokenConfigurationsFactories { get; set; } = [];

    internal InnerIndexCapacityUnitsConfigurationFactory CapacityUnitsFactory { get; set; }

    internal InnerIndexServerSideEncryptionConfigurationFactory ServerSideEncryptionConfigurationFactory { get; set; }

    protected override Humidifier.Kendra.Index Create()
    {
        var indexResult = CreateIndex();
        factoryAction?.Invoke(indexResult);

        return indexResult;
    }

    private Humidifier.Kendra.Index CreateIndex()
    {
        var indexResult = new Humidifier.Kendra.Index
        {
            GivenName = InputResourceName,
        };

        return indexResult;
    }
    public override void CreateChildren(Humidifier.Kendra.Index result)
    {
        base.CreateChildren(result);

        result.DocumentMetadataConfigurations = DocumentMetadataConfigurationsFactories.Any() ? DocumentMetadataConfigurationsFactories.Select(x => x.Build()).ToList() : null;
        result.UserTokenConfigurations = UserTokenConfigurationsFactories.Any() ? UserTokenConfigurationsFactories.Select(x => x.Build()).ToList() : null;
        result.CapacityUnits ??= CapacityUnitsFactory?.Build();
        result.ServerSideEncryptionConfiguration ??= ServerSideEncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class IndexFactoryExtensions
{
    public static CombinedResult<IndexFactory, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations(this IndexFactory parentFactory, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null)
    {
        var factory = new InnerIndexDocumentMetadataConfigurationFactory(subFactoryAction);
        parentFactory.DocumentMetadataConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IndexFactory, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations(this IndexFactory parentFactory, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null)
    {
        var factory = new InnerIndexUserTokenConfigurationFactory(subFactoryAction);
        parentFactory.UserTokenConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<IndexFactory, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits(this IndexFactory parentFactory, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null)
    {
        parentFactory.CapacityUnitsFactory = new InnerIndexCapacityUnitsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CapacityUnitsFactory);
    }

    public static CombinedResult<IndexFactory, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration(this IndexFactory parentFactory, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.ServerSideEncryptionConfigurationFactory = new InnerIndexServerSideEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServerSideEncryptionConfigurationFactory);
    }

    public static CombinedResult<IndexFactory, T1, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1>(this CombinedResult<IndexFactory, T1> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1>(this CombinedResult<T1, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1, T2>(this CombinedResult<IndexFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1, T2>(this CombinedResult<T1, IndexFactory, T2> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1, T2>(this CombinedResult<T1, T2, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, T3, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1, T2, T3>(this CombinedResult<IndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, T3, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1, T2, T3>(this CombinedResult<T1, IndexFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, T3, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, IndexFactory, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IndexFactory, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, T3, T4, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1, T2, T3, T4>(this CombinedResult<IndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, T3, T4, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, IndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, T3, T4, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, IndexFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IndexFactory, T4, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IndexFactory, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IndexFactory, InnerIndexDocumentMetadataConfigurationFactory> WithDocumentMetadataConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.DocumentMetadataConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDocumentMetadataConfigurations(combinedResult.T5, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1>(this CombinedResult<IndexFactory, T1> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1>(this CombinedResult<T1, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1, T2>(this CombinedResult<IndexFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1, T2>(this CombinedResult<T1, IndexFactory, T2> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1, T2>(this CombinedResult<T1, T2, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, T3, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1, T2, T3>(this CombinedResult<IndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, T3, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1, T2, T3>(this CombinedResult<T1, IndexFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, T3, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, IndexFactory, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IndexFactory, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, T3, T4, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1, T2, T3, T4>(this CombinedResult<IndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, T3, T4, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, IndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, T3, T4, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, IndexFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IndexFactory, T4, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IndexFactory, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IndexFactory, InnerIndexUserTokenConfigurationFactory> WithUserTokenConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.UserTokenConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUserTokenConfigurations(combinedResult.T5, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1>(this CombinedResult<IndexFactory, T1> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityUnits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1>(this CombinedResult<T1, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCapacityUnits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2>(this CombinedResult<IndexFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2>(this CombinedResult<T1, IndexFactory, T2> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2>(this CombinedResult<T1, T2, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, T3, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3>(this CombinedResult<IndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, T3, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3>(this CombinedResult<T1, IndexFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, T3, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3>(this CombinedResult<T1, T2, IndexFactory, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IndexFactory, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3>(this CombinedResult<T1, T2, T3, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, T3, T4, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3, T4>(this CombinedResult<IndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, T3, T4, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3, T4>(this CombinedResult<T1, IndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, T3, T4, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3, T4>(this CombinedResult<T1, T2, IndexFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IndexFactory, T4, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IndexFactory, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IndexFactory, InnerIndexCapacityUnitsConfigurationFactory> WithCapacityUnits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCapacityUnits(combinedResult.T5, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1>(this CombinedResult<IndexFactory, T1> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1>(this CombinedResult<T1, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2>(this CombinedResult<IndexFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2>(this CombinedResult<T1, IndexFactory, T2> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, T3, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3>(this CombinedResult<IndexFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, T3, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, IndexFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, T3, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, IndexFactory, T3> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IndexFactory, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<IndexFactory, T1, T2, T3, T4, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<IndexFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, IndexFactory, T2, T3, T4, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, IndexFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, IndexFactory, T3, T4, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, IndexFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, IndexFactory, T4, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IndexFactory, T4> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, IndexFactory, InnerIndexServerSideEncryptionConfigurationFactory> WithServerSideEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IndexFactory> combinedResult, Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSideEncryptionConfiguration(combinedResult.T5, subFactoryAction));
}
