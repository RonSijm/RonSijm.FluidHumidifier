// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerDataSourceOneDriveConfigurationFactory(Action<Humidifier.Kendra.DataSourceTypes.OneDriveConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.DataSourceTypes.OneDriveConfiguration>
{

    internal InnerDataSourceOneDriveUsersFactory OneDriveUsersFactory { get; set; }

    protected override Humidifier.Kendra.DataSourceTypes.OneDriveConfiguration Create()
    {
        var oneDriveConfigurationResult = CreateOneDriveConfiguration();
        factoryAction?.Invoke(oneDriveConfigurationResult);

        return oneDriveConfigurationResult;
    }

    private Humidifier.Kendra.DataSourceTypes.OneDriveConfiguration CreateOneDriveConfiguration()
    {
        var oneDriveConfigurationResult = new Humidifier.Kendra.DataSourceTypes.OneDriveConfiguration();

        return oneDriveConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Kendra.DataSourceTypes.OneDriveConfiguration result)
    {
        base.CreateChildren(result);

        result.OneDriveUsers ??= OneDriveUsersFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceOneDriveConfigurationFactoryExtensions
{
    public static CombinedResult<InnerDataSourceOneDriveConfigurationFactory, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers(this InnerDataSourceOneDriveConfigurationFactory parentFactory, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null)
    {
        parentFactory.OneDriveUsersFactory = new InnerDataSourceOneDriveUsersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OneDriveUsersFactory);
    }

    public static CombinedResult<InnerDataSourceOneDriveConfigurationFactory, T1, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1>(this CombinedResult<InnerDataSourceOneDriveConfigurationFactory, T1> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceOneDriveConfigurationFactory, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1>(this CombinedResult<T1, InnerDataSourceOneDriveConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataSourceOneDriveConfigurationFactory, T1, T2, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1, T2>(this CombinedResult<InnerDataSourceOneDriveConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceOneDriveConfigurationFactory, T2, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1, T2>(this CombinedResult<T1, InnerDataSourceOneDriveConfigurationFactory, T2> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceOneDriveConfigurationFactory, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceOneDriveConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataSourceOneDriveConfigurationFactory, T1, T2, T3, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1, T2, T3>(this CombinedResult<InnerDataSourceOneDriveConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceOneDriveConfigurationFactory, T2, T3, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceOneDriveConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceOneDriveConfigurationFactory, T3, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceOneDriveConfigurationFactory, T3> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceOneDriveConfigurationFactory, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceOneDriveConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataSourceOneDriveConfigurationFactory, T1, T2, T3, T4, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceOneDriveConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataSourceOneDriveConfigurationFactory, T2, T3, T4, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceOneDriveConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataSourceOneDriveConfigurationFactory, T3, T4, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceOneDriveConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataSourceOneDriveConfigurationFactory, T4, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceOneDriveConfigurationFactory, T4> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceOneDriveConfigurationFactory, InnerDataSourceOneDriveUsersFactory> WithOneDriveUsers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceOneDriveConfigurationFactory> combinedResult, Action<Humidifier.Kendra.DataSourceTypes.OneDriveUsers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOneDriveUsers(combinedResult.T5, subFactoryAction));
}
