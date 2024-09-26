// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class RepositoryCreationTemplateFactory(string resourceName = null, Action<Humidifier.ECR.RepositoryCreationTemplate> factoryAction = null) : ResourceFactory<Humidifier.ECR.RepositoryCreationTemplate>(resourceName)
{

    internal InnerRepositoryCreationTemplateEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    protected override Humidifier.ECR.RepositoryCreationTemplate Create()
    {
        var repositoryCreationTemplateResult = CreateRepositoryCreationTemplate();
        factoryAction?.Invoke(repositoryCreationTemplateResult);

        return repositoryCreationTemplateResult;
    }

    private Humidifier.ECR.RepositoryCreationTemplate CreateRepositoryCreationTemplate()
    {
        var repositoryCreationTemplateResult = new Humidifier.ECR.RepositoryCreationTemplate
        {
            GivenName = InputResourceName,
        };

        return repositoryCreationTemplateResult;
    }
    public override void CreateChildren(Humidifier.ECR.RepositoryCreationTemplate result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class RepositoryCreationTemplateFactoryExtensions
{
    public static CombinedResult<RepositoryCreationTemplateFactory, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration(this RepositoryCreationTemplateFactory parentFactory, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerRepositoryCreationTemplateEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<RepositoryCreationTemplateFactory, T1, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<RepositoryCreationTemplateFactory, T1> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RepositoryCreationTemplateFactory, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, RepositoryCreationTemplateFactory> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RepositoryCreationTemplateFactory, T1, T2, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<RepositoryCreationTemplateFactory, T1, T2> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RepositoryCreationTemplateFactory, T2, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, RepositoryCreationTemplateFactory, T2> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RepositoryCreationTemplateFactory, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, RepositoryCreationTemplateFactory> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RepositoryCreationTemplateFactory, T1, T2, T3, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<RepositoryCreationTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RepositoryCreationTemplateFactory, T2, T3, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, RepositoryCreationTemplateFactory, T2, T3> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RepositoryCreationTemplateFactory, T3, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, RepositoryCreationTemplateFactory, T3> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RepositoryCreationTemplateFactory, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, RepositoryCreationTemplateFactory> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RepositoryCreationTemplateFactory, T1, T2, T3, T4, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<RepositoryCreationTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RepositoryCreationTemplateFactory, T2, T3, T4, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, RepositoryCreationTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RepositoryCreationTemplateFactory, T3, T4, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, RepositoryCreationTemplateFactory, T3, T4> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RepositoryCreationTemplateFactory, T4, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RepositoryCreationTemplateFactory, T4> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RepositoryCreationTemplateFactory, InnerRepositoryCreationTemplateEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RepositoryCreationTemplateFactory> combinedResult, Action<Humidifier.ECR.RepositoryCreationTemplateTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction));
}
