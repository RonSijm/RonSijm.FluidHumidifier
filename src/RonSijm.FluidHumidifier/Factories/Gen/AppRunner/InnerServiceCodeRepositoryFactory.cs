// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceCodeRepositoryFactory(Action<Humidifier.AppRunner.ServiceTypes.CodeRepository> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.CodeRepository>
{

    internal InnerServiceSourceCodeVersionFactory SourceCodeVersionFactory { get; set; }

    internal InnerServiceCodeConfigurationFactory CodeConfigurationFactory { get; set; }

    protected override Humidifier.AppRunner.ServiceTypes.CodeRepository Create()
    {
        var codeRepositoryResult = CreateCodeRepository();
        factoryAction?.Invoke(codeRepositoryResult);

        return codeRepositoryResult;
    }

    private Humidifier.AppRunner.ServiceTypes.CodeRepository CreateCodeRepository()
    {
        var codeRepositoryResult = new Humidifier.AppRunner.ServiceTypes.CodeRepository();

        return codeRepositoryResult;
    }
    public override void CreateChildren(Humidifier.AppRunner.ServiceTypes.CodeRepository result)
    {
        base.CreateChildren(result);

        result.SourceCodeVersion ??= SourceCodeVersionFactory?.Build();
        result.CodeConfiguration ??= CodeConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerServiceCodeRepositoryFactoryExtensions
{
    public static CombinedResult<InnerServiceCodeRepositoryFactory, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion(this InnerServiceCodeRepositoryFactory parentFactory, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null)
    {
        parentFactory.SourceCodeVersionFactory = new InnerServiceSourceCodeVersionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceCodeVersionFactory);
    }

    public static CombinedResult<InnerServiceCodeRepositoryFactory, InnerServiceCodeConfigurationFactory> WithCodeConfiguration(this InnerServiceCodeRepositoryFactory parentFactory, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null)
    {
        parentFactory.CodeConfigurationFactory = new InnerServiceCodeConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeConfigurationFactory);
    }

    public static CombinedResult<InnerServiceCodeRepositoryFactory, T1, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1>(this CombinedResult<InnerServiceCodeRepositoryFactory, T1> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceCodeRepositoryFactory, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1>(this CombinedResult<T1, InnerServiceCodeRepositoryFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceCodeRepositoryFactory, T1, T2, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1, T2>(this CombinedResult<InnerServiceCodeRepositoryFactory, T1, T2> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceCodeRepositoryFactory, T2, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1, T2>(this CombinedResult<T1, InnerServiceCodeRepositoryFactory, T2> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceCodeRepositoryFactory, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1, T2>(this CombinedResult<T1, T2, InnerServiceCodeRepositoryFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceCodeRepositoryFactory, T1, T2, T3, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1, T2, T3>(this CombinedResult<InnerServiceCodeRepositoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceCodeRepositoryFactory, T2, T3, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1, T2, T3>(this CombinedResult<T1, InnerServiceCodeRepositoryFactory, T2, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceCodeRepositoryFactory, T3, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceCodeRepositoryFactory, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceCodeRepositoryFactory, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceCodeRepositoryFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceCodeRepositoryFactory, T1, T2, T3, T4, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1, T2, T3, T4>(this CombinedResult<InnerServiceCodeRepositoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceCodeRepositoryFactory, T2, T3, T4, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceCodeRepositoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceCodeRepositoryFactory, T3, T4, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceCodeRepositoryFactory, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceCodeRepositoryFactory, T4, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceCodeRepositoryFactory, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceCodeRepositoryFactory, InnerServiceSourceCodeVersionFactory> WithSourceCodeVersion<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceCodeRepositoryFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.SourceCodeVersion> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSourceCodeVersion(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerServiceCodeRepositoryFactory, T1, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1>(this CombinedResult<InnerServiceCodeRepositoryFactory, T1> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceCodeRepositoryFactory, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1>(this CombinedResult<T1, InnerServiceCodeRepositoryFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceCodeRepositoryFactory, T1, T2, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1, T2>(this CombinedResult<InnerServiceCodeRepositoryFactory, T1, T2> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceCodeRepositoryFactory, T2, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1, T2>(this CombinedResult<T1, InnerServiceCodeRepositoryFactory, T2> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceCodeRepositoryFactory, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerServiceCodeRepositoryFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceCodeRepositoryFactory, T1, T2, T3, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1, T2, T3>(this CombinedResult<InnerServiceCodeRepositoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceCodeRepositoryFactory, T2, T3, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerServiceCodeRepositoryFactory, T2, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceCodeRepositoryFactory, T3, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceCodeRepositoryFactory, T3> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceCodeRepositoryFactory, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceCodeRepositoryFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceCodeRepositoryFactory, T1, T2, T3, T4, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerServiceCodeRepositoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceCodeRepositoryFactory, T2, T3, T4, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceCodeRepositoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceCodeRepositoryFactory, T3, T4, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceCodeRepositoryFactory, T3, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceCodeRepositoryFactory, T4, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceCodeRepositoryFactory, T4> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceCodeRepositoryFactory, InnerServiceCodeConfigurationFactory> WithCodeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceCodeRepositoryFactory> combinedResult, Action<Humidifier.AppRunner.ServiceTypes.CodeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCodeConfiguration(combinedResult.T5, subFactoryAction));
}
