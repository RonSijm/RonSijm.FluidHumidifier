// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class DataAutomationLibraryFactory(string resourceName = null, Action<Humidifier.Bedrock.DataAutomationLibrary> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.DataAutomationLibrary>(resourceName)
{

    internal InnerDataAutomationLibraryEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    protected override Humidifier.Bedrock.DataAutomationLibrary Create()
    {
        var dataAutomationLibraryResult = CreateDataAutomationLibrary();
        factoryAction?.Invoke(dataAutomationLibraryResult);

        return dataAutomationLibraryResult;
    }

    private Humidifier.Bedrock.DataAutomationLibrary CreateDataAutomationLibrary()
    {
        var dataAutomationLibraryResult = new Humidifier.Bedrock.DataAutomationLibrary
        {
            GivenName = InputResourceName,
        };

        return dataAutomationLibraryResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.DataAutomationLibrary result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
    }

} // End Of Class

public static class DataAutomationLibraryFactoryExtensions
{
    public static CombinedResult<DataAutomationLibraryFactory, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration(this DataAutomationLibraryFactory parentFactory, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerDataAutomationLibraryEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<DataAutomationLibraryFactory, T1, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<DataAutomationLibraryFactory, T1> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataAutomationLibraryFactory, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, DataAutomationLibraryFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DataAutomationLibraryFactory, T1, T2, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<DataAutomationLibraryFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataAutomationLibraryFactory, T2, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, DataAutomationLibraryFactory, T2> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataAutomationLibraryFactory, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, DataAutomationLibraryFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DataAutomationLibraryFactory, T1, T2, T3, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<DataAutomationLibraryFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataAutomationLibraryFactory, T2, T3, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, DataAutomationLibraryFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataAutomationLibraryFactory, T3, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DataAutomationLibraryFactory, T3> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataAutomationLibraryFactory, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataAutomationLibraryFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DataAutomationLibraryFactory, T1, T2, T3, T4, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<DataAutomationLibraryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DataAutomationLibraryFactory, T2, T3, T4, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DataAutomationLibraryFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DataAutomationLibraryFactory, T3, T4, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataAutomationLibraryFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DataAutomationLibraryFactory, T4, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataAutomationLibraryFactory, T4> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DataAutomationLibraryFactory, InnerDataAutomationLibraryEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataAutomationLibraryFactory> combinedResult, Action<Humidifier.Bedrock.DataAutomationLibraryTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction).T2);
}
