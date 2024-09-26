// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DMS;

public class InnerMigrationProjectDataProviderDescriptorFactory(Action<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor> factoryAction = null) : SubResourceFactory<Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor>
{

    protected override Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor Create()
    {
        var dataProviderDescriptorResult = CreateDataProviderDescriptor();
        factoryAction?.Invoke(dataProviderDescriptorResult);

        return dataProviderDescriptorResult;
    }

    private Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor CreateDataProviderDescriptor()
    {
        var dataProviderDescriptorResult = new Humidifier.DMS.MigrationProjectTypes.DataProviderDescriptor();

        return dataProviderDescriptorResult;
    }

} // End Of Class

public static class InnerMigrationProjectDataProviderDescriptorFactoryExtensions
{
}
