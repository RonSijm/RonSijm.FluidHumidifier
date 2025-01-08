// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class DataProtectionSettingsFactory(string resourceName = null, Action<Humidifier.WorkSpacesWeb.DataProtectionSettings> factoryAction = null) : ResourceFactory<Humidifier.WorkSpacesWeb.DataProtectionSettings>(resourceName)
{

    internal InnerDataProtectionSettingsInlineRedactionConfigurationFactory InlineRedactionConfigurationFactory { get; set; }

    protected override Humidifier.WorkSpacesWeb.DataProtectionSettings Create()
    {
        var dataProtectionSettingsResult = CreateDataProtectionSettings();
        factoryAction?.Invoke(dataProtectionSettingsResult);

        return dataProtectionSettingsResult;
    }

    private Humidifier.WorkSpacesWeb.DataProtectionSettings CreateDataProtectionSettings()
    {
        var dataProtectionSettingsResult = new Humidifier.WorkSpacesWeb.DataProtectionSettings
        {
            GivenName = InputResourceName,
        };

        return dataProtectionSettingsResult;
    }
    public override void CreateChildren(Humidifier.WorkSpacesWeb.DataProtectionSettings result)
    {
        base.CreateChildren(result);

        result.InlineRedactionConfiguration ??= InlineRedactionConfigurationFactory?.Build();
    }

} // End Of Class

public static class DataProtectionSettingsFactoryExtensions
{
    public static CombinedResult<DataProtectionSettingsFactory, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration(this DataProtectionSettingsFactory parentFactory, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null)
    {
        parentFactory.InlineRedactionConfigurationFactory = new InnerDataProtectionSettingsInlineRedactionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InlineRedactionConfigurationFactory);
    }

    public static CombinedResult<DataProtectionSettingsFactory, T1, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1>(this CombinedResult<DataProtectionSettingsFactory, T1> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataProtectionSettingsFactory, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1>(this CombinedResult<T1, DataProtectionSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<DataProtectionSettingsFactory, T1, T2, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1, T2>(this CombinedResult<DataProtectionSettingsFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataProtectionSettingsFactory, T2, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1, T2>(this CombinedResult<T1, DataProtectionSettingsFactory, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataProtectionSettingsFactory, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1, T2>(this CombinedResult<T1, T2, DataProtectionSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<DataProtectionSettingsFactory, T1, T2, T3, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1, T2, T3>(this CombinedResult<DataProtectionSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataProtectionSettingsFactory, T2, T3, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1, T2, T3>(this CombinedResult<T1, DataProtectionSettingsFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataProtectionSettingsFactory, T3, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, DataProtectionSettingsFactory, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataProtectionSettingsFactory, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, DataProtectionSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<DataProtectionSettingsFactory, T1, T2, T3, T4, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1, T2, T3, T4>(this CombinedResult<DataProtectionSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, DataProtectionSettingsFactory, T2, T3, T4, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, DataProtectionSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, DataProtectionSettingsFactory, T3, T4, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, DataProtectionSettingsFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, DataProtectionSettingsFactory, T4, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DataProtectionSettingsFactory, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, DataProtectionSettingsFactory, InnerDataProtectionSettingsInlineRedactionConfigurationFactory> WithInlineRedactionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DataProtectionSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.DataProtectionSettingsTypes.InlineRedactionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInlineRedactionConfiguration(combinedResult.T5, subFactoryAction));
}
