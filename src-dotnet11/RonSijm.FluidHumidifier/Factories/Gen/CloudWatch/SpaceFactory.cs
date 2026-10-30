// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class SpaceFactory(string resourceName = null, Action<Humidifier.CloudWatch.Space> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.Space>(resourceName)
{

    internal InnerSpaceEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    protected override Humidifier.CloudWatch.Space Create()
    {
        var spaceResult = CreateSpace();
        factoryAction?.Invoke(spaceResult);

        return spaceResult;
    }

    private Humidifier.CloudWatch.Space CreateSpace()
    {
        var spaceResult = new Humidifier.CloudWatch.Space
        {
            GivenName = InputResourceName,
        };

        return spaceResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.Space result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class SpaceFactoryExtensions
{
    public static CombinedResult<SpaceFactory, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration(this SpaceFactory parentFactory, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerSpaceEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<SpaceFactory, T1, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<SpaceFactory, T1> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpaceFactory, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, SpaceFactory> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SpaceFactory, T1, T2, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<SpaceFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpaceFactory, T2, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, SpaceFactory, T2> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpaceFactory, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, SpaceFactory> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SpaceFactory, T1, T2, T3, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<SpaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpaceFactory, T2, T3, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, SpaceFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpaceFactory, T3, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, SpaceFactory, T3> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SpaceFactory, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, SpaceFactory> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SpaceFactory, T1, T2, T3, T4, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<SpaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpaceFactory, T2, T3, T4, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, SpaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpaceFactory, T3, T4, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, SpaceFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SpaceFactory, T4, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SpaceFactory, T4> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SpaceFactory, InnerSpaceEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SpaceFactory> combinedResult, Action<Humidifier.CloudWatch.SpaceTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
