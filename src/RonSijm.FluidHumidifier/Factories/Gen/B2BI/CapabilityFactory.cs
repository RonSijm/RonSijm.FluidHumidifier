// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class CapabilityFactory(string resourceName = null, Action<Humidifier.B2BI.Capability> factoryAction = null) : ResourceFactory<Humidifier.B2BI.Capability>(resourceName)
{

    internal List<InnerCapabilityS3LocationFactory> InstructionsDocumentsFactories { get; set; } = [];

    internal InnerCapabilityCapabilityConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.B2BI.Capability Create()
    {
        var capabilityResult = CreateCapability();
        factoryAction?.Invoke(capabilityResult);

        return capabilityResult;
    }

    private Humidifier.B2BI.Capability CreateCapability()
    {
        var capabilityResult = new Humidifier.B2BI.Capability
        {
            GivenName = InputResourceName,
        };

        return capabilityResult;
    }
    public override void CreateChildren(Humidifier.B2BI.Capability result)
    {
        base.CreateChildren(result);

        result.InstructionsDocuments = InstructionsDocumentsFactories.Any() ? InstructionsDocumentsFactories.Select(x => x.Build()).ToList() : null;
        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class CapabilityFactoryExtensions
{
    public static CombinedResult<CapabilityFactory, InnerCapabilityS3LocationFactory> WithInstructionsDocuments(this CapabilityFactory parentFactory, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null)
    {
        var factory = new InnerCapabilityS3LocationFactory(subFactoryAction);
        parentFactory.InstructionsDocumentsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CapabilityFactory, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration(this CapabilityFactory parentFactory, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerCapabilityCapabilityConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<CapabilityFactory, T1, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1>(this CombinedResult<CapabilityFactory, T1> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapabilityFactory, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1>(this CombinedResult<T1, CapabilityFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CapabilityFactory, T1, T2, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1, T2>(this CombinedResult<CapabilityFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapabilityFactory, T2, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1, T2>(this CombinedResult<T1, CapabilityFactory, T2> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapabilityFactory, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1, T2>(this CombinedResult<T1, T2, CapabilityFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CapabilityFactory, T1, T2, T3, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1, T2, T3>(this CombinedResult<CapabilityFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapabilityFactory, T2, T3, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1, T2, T3>(this CombinedResult<T1, CapabilityFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapabilityFactory, T3, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1, T2, T3>(this CombinedResult<T1, T2, CapabilityFactory, T3> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapabilityFactory, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1, T2, T3>(this CombinedResult<T1, T2, T3, CapabilityFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CapabilityFactory, T1, T2, T3, T4, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1, T2, T3, T4>(this CombinedResult<CapabilityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapabilityFactory, T2, T3, T4, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1, T2, T3, T4>(this CombinedResult<T1, CapabilityFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapabilityFactory, T3, T4, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1, T2, T3, T4>(this CombinedResult<T1, T2, CapabilityFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapabilityFactory, T4, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CapabilityFactory, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CapabilityFactory, InnerCapabilityS3LocationFactory> WithInstructionsDocuments<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CapabilityFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.S3Location> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstructionsDocuments(combinedResult.T5, subFactoryAction));
    public static CombinedResult<CapabilityFactory, T1, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1>(this CombinedResult<CapabilityFactory, T1> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapabilityFactory, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, CapabilityFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CapabilityFactory, T1, T2, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<CapabilityFactory, T1, T2> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapabilityFactory, T2, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, CapabilityFactory, T2> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapabilityFactory, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, CapabilityFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CapabilityFactory, T1, T2, T3, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<CapabilityFactory, T1, T2, T3> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapabilityFactory, T2, T3, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, CapabilityFactory, T2, T3> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapabilityFactory, T3, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, CapabilityFactory, T3> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapabilityFactory, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, CapabilityFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CapabilityFactory, T1, T2, T3, T4, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<CapabilityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CapabilityFactory, T2, T3, T4, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, CapabilityFactory, T2, T3, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CapabilityFactory, T3, T4, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, CapabilityFactory, T3, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CapabilityFactory, T4, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CapabilityFactory, T4> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CapabilityFactory, InnerCapabilityCapabilityConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CapabilityFactory> combinedResult, Action<Humidifier.B2BI.CapabilityTypes.CapabilityConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction));
}
