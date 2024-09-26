// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class MigrationProjectFactory(string resourceName = null, Action<Humidifier.DMS.MigrationProject> factoryAction = null) : ResourceFactory<Humidifier.DMS.MigrationProject>(resourceName)
{

    internal List<InnerMigrationProjectDataProviderDescriptorFactory> TargetDataProviderDescriptorsFactories { get; set; } = [];

    internal List<InnerMigrationProjectDataProviderDescriptorFactory> SourceDataProviderDescriptorsFactories { get; set; } = [];

    internal InnerMigrationProjectSchemaConversionApplicationAttributesFactory SchemaConversionApplicationAttributesFactory { get; set; }

    protected override Humidifier.DMS.MigrationProject Create()
    {
        var migrationProjectResult = CreateMigrationProject();
        factoryAction?.Invoke(migrationProjectResult);

        return migrationProjectResult;
    }

    private Humidifier.DMS.MigrationProject CreateMigrationProject()
    {
        var migrationProjectResult = new Humidifier.DMS.MigrationProject
        {
            GivenName = InputResourceName,
        };

        return migrationProjectResult;
    }
    public override void CreateChildren(Humidifier.DMS.MigrationProject result)
    {
        base.CreateChildren(result);

        result.TargetDataProviderDescriptors = TargetDataProviderDescriptorsFactories.Any() ? TargetDataProviderDescriptorsFactories.Select(x => x.Build()).ToList() : null;
        result.SourceDataProviderDescriptors = SourceDataProviderDescriptorsFactories.Any() ? SourceDataProviderDescriptorsFactories.Select(x => x.Build()).ToList() : null;
        result.SchemaConversionApplicationAttributes ??= SchemaConversionApplicationAttributesFactory?.Build();
    }

} // End Of Class

public static class MigrationProjectFactoryExtensions
{
    public static CombinedResult<MigrationProjectFactory, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors(this MigrationProjectFactory parentFactory, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null)
    {
        var factory = new InnerMigrationProjectDataProviderDescriptorFactory(subFactoryAction);
        parentFactory.TargetDataProviderDescriptorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MigrationProjectFactory, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors(this MigrationProjectFactory parentFactory, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null)
    {
        var factory = new InnerMigrationProjectDataProviderDescriptorFactory(subFactoryAction);
        parentFactory.SourceDataProviderDescriptorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MigrationProjectFactory, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes(this MigrationProjectFactory parentFactory, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null)
    {
        parentFactory.SchemaConversionApplicationAttributesFactory = new InnerMigrationProjectSchemaConversionApplicationAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchemaConversionApplicationAttributesFactory);
    }

    public static CombinedResult<MigrationProjectFactory, T1, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1>(this CombinedResult<MigrationProjectFactory, T1> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MigrationProjectFactory, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1>(this CombinedResult<T1, MigrationProjectFactory> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MigrationProjectFactory, T1, T2, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1, T2>(this CombinedResult<MigrationProjectFactory, T1, T2> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MigrationProjectFactory, T2, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1, T2>(this CombinedResult<T1, MigrationProjectFactory, T2> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MigrationProjectFactory, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1, T2>(this CombinedResult<T1, T2, MigrationProjectFactory> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MigrationProjectFactory, T1, T2, T3, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1, T2, T3>(this CombinedResult<MigrationProjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MigrationProjectFactory, T2, T3, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1, T2, T3>(this CombinedResult<T1, MigrationProjectFactory, T2, T3> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MigrationProjectFactory, T3, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1, T2, T3>(this CombinedResult<T1, T2, MigrationProjectFactory, T3> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MigrationProjectFactory, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1, T2, T3>(this CombinedResult<T1, T2, T3, MigrationProjectFactory> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MigrationProjectFactory, T1, T2, T3, T4, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1, T2, T3, T4>(this CombinedResult<MigrationProjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MigrationProjectFactory, T2, T3, T4, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, MigrationProjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MigrationProjectFactory, T3, T4, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, T2, MigrationProjectFactory, T3, T4> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MigrationProjectFactory, T4, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MigrationProjectFactory, T4> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MigrationProjectFactory, InnerMigrationProjectDataProviderDescriptorFactory> WithTargetDataProviderDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MigrationProjectFactory> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetDataProviderDescriptors(combinedResult.T5, subFactoryAction));
    public static CombinedResult<MigrationProjectFactory, T1, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1>(this CombinedResult<MigrationProjectFactory, T1> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MigrationProjectFactory, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1>(this CombinedResult<T1, MigrationProjectFactory> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MigrationProjectFactory, T1, T2, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1, T2>(this CombinedResult<MigrationProjectFactory, T1, T2> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MigrationProjectFactory, T2, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1, T2>(this CombinedResult<T1, MigrationProjectFactory, T2> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MigrationProjectFactory, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1, T2>(this CombinedResult<T1, T2, MigrationProjectFactory> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MigrationProjectFactory, T1, T2, T3, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1, T2, T3>(this CombinedResult<MigrationProjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MigrationProjectFactory, T2, T3, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1, T2, T3>(this CombinedResult<T1, MigrationProjectFactory, T2, T3> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MigrationProjectFactory, T3, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1, T2, T3>(this CombinedResult<T1, T2, MigrationProjectFactory, T3> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MigrationProjectFactory, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1, T2, T3>(this CombinedResult<T1, T2, T3, MigrationProjectFactory> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MigrationProjectFactory, T1, T2, T3, T4, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1, T2, T3, T4>(this CombinedResult<MigrationProjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MigrationProjectFactory, T2, T3, T4, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, MigrationProjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MigrationProjectFactory, T3, T4, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, T2, MigrationProjectFactory, T3, T4> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MigrationProjectFactory, T4, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MigrationProjectFactory, T4> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MigrationProjectFactory, InnerMigrationProjectDataProviderDescriptorFactory> WithSourceDataProviderDescriptors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MigrationProjectFactory> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceDataProviderDescriptors(combinedResult.T5, subFactoryAction));
    public static CombinedResult<MigrationProjectFactory, T1, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1>(this CombinedResult<MigrationProjectFactory, T1> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MigrationProjectFactory, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1>(this CombinedResult<T1, MigrationProjectFactory> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MigrationProjectFactory, T1, T2, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1, T2>(this CombinedResult<MigrationProjectFactory, T1, T2> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MigrationProjectFactory, T2, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1, T2>(this CombinedResult<T1, MigrationProjectFactory, T2> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MigrationProjectFactory, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1, T2>(this CombinedResult<T1, T2, MigrationProjectFactory> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MigrationProjectFactory, T1, T2, T3, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1, T2, T3>(this CombinedResult<MigrationProjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MigrationProjectFactory, T2, T3, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1, T2, T3>(this CombinedResult<T1, MigrationProjectFactory, T2, T3> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MigrationProjectFactory, T3, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1, T2, T3>(this CombinedResult<T1, T2, MigrationProjectFactory, T3> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MigrationProjectFactory, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, MigrationProjectFactory> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MigrationProjectFactory, T1, T2, T3, T4, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1, T2, T3, T4>(this CombinedResult<MigrationProjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MigrationProjectFactory, T2, T3, T4, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1, T2, T3, T4>(this CombinedResult<T1, MigrationProjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MigrationProjectFactory, T3, T4, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, MigrationProjectFactory, T3, T4> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MigrationProjectFactory, T4, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MigrationProjectFactory, T4> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MigrationProjectFactory, InnerMigrationProjectSchemaConversionApplicationAttributesFactory> WithSchemaConversionApplicationAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MigrationProjectFactory> combinedResult, Action<Humidifier.DMS.MigrationProjectTypes.SchemaConversionApplicationAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchemaConversionApplicationAttributes(combinedResult.T5, subFactoryAction));
}
