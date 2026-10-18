// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class ImportImageTaskFactory(string resourceName = null, Action<Humidifier.EC2.ImportImageTask> factoryAction = null) : ResourceFactory<Humidifier.EC2.ImportImageTask>(resourceName)
{

    internal List<InnerImportImageTaskImportImageLicenseConfigurationFactory> LicenseSpecificationsFactories { get; set; } = [];

    protected override Humidifier.EC2.ImportImageTask Create()
    {
        var importImageTaskResult = CreateImportImageTask();
        factoryAction?.Invoke(importImageTaskResult);

        return importImageTaskResult;
    }

    private Humidifier.EC2.ImportImageTask CreateImportImageTask()
    {
        var importImageTaskResult = new Humidifier.EC2.ImportImageTask
        {
            GivenName = InputResourceName,
        };

        return importImageTaskResult;
    }
    public override void CreateChildren(Humidifier.EC2.ImportImageTask result)
    {
        base.CreateChildren(result);

        result.LicenseSpecifications = LicenseSpecificationsFactories.Any() ? LicenseSpecificationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ImportImageTaskFactoryExtensions
{
    public static CombinedResult<ImportImageTaskFactory, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications(this ImportImageTaskFactory parentFactory, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null)
    {
        var factory = new InnerImportImageTaskImportImageLicenseConfigurationFactory(subFactoryAction);
        parentFactory.LicenseSpecificationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ImportImageTaskFactory, T1, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1>(this CombinedResult<ImportImageTaskFactory, T1> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportImageTaskFactory, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1>(this CombinedResult<T1, ImportImageTaskFactory> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ImportImageTaskFactory, T1, T2, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1, T2>(this CombinedResult<ImportImageTaskFactory, T1, T2> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportImageTaskFactory, T2, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1, T2>(this CombinedResult<T1, ImportImageTaskFactory, T2> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImportImageTaskFactory, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1, T2>(this CombinedResult<T1, T2, ImportImageTaskFactory> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ImportImageTaskFactory, T1, T2, T3, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1, T2, T3>(this CombinedResult<ImportImageTaskFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportImageTaskFactory, T2, T3, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1, T2, T3>(this CombinedResult<T1, ImportImageTaskFactory, T2, T3> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImportImageTaskFactory, T3, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, ImportImageTaskFactory, T3> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ImportImageTaskFactory, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1, T2, T3>(this CombinedResult<T1, T2, T3, ImportImageTaskFactory> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ImportImageTaskFactory, T1, T2, T3, T4, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1, T2, T3, T4>(this CombinedResult<ImportImageTaskFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ImportImageTaskFactory, T2, T3, T4, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, ImportImageTaskFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ImportImageTaskFactory, T3, T4, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, ImportImageTaskFactory, T3, T4> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ImportImageTaskFactory, T4, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ImportImageTaskFactory, T4> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ImportImageTaskFactory, InnerImportImageTaskImportImageLicenseConfigurationFactory> WithLicenseSpecifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ImportImageTaskFactory> combinedResult, Action<Humidifier.EC2.ImportImageTaskTypes.ImportImageLicenseConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseSpecifications(combinedResult.T5, subFactoryAction).T2);
}
