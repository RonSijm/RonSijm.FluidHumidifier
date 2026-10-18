// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceDataSourceCredentialsFactory(Action<Humidifier.QuickSight.DataSourceTypes.DataSourceCredentials> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.DataSourceCredentials>
{

    internal InnerDataSourceCredentialPairFactory CredentialPairFactory { get; set; }

    internal InnerDataSourceKeyPairCredentialsFactory KeyPairCredentialsFactory { get; set; }

    protected override Humidifier.QuickSight.DataSourceTypes.DataSourceCredentials Create()
    {
        var dataSourceCredentialsResult = CreateDataSourceCredentials();
        factoryAction?.Invoke(dataSourceCredentialsResult);

        return dataSourceCredentialsResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.DataSourceCredentials CreateDataSourceCredentials()
    {
        var dataSourceCredentialsResult = new Humidifier.QuickSight.DataSourceTypes.DataSourceCredentials();

        return dataSourceCredentialsResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.DataSourceTypes.DataSourceCredentials result)
    {
        base.CreateChildren(result);

        result.CredentialPair ??= CredentialPairFactory?.Build();
        result.KeyPairCredentials ??= KeyPairCredentialsFactory?.Build();
    }

} // End Of Class

public static class InnerDataSourceDataSourceCredentialsFactoryExtensions
{
    public static CombinedResult<InnerDataSourceDataSourceCredentialsFactory, InnerDataSourceCredentialPairFactory> WithCredentialPair(this InnerDataSourceDataSourceCredentialsFactory parentFactory, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null)
    {
        parentFactory.CredentialPairFactory = new InnerDataSourceCredentialPairFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CredentialPairFactory);
    }

    public static CombinedResult<InnerDataSourceDataSourceCredentialsFactory, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials(this InnerDataSourceDataSourceCredentialsFactory parentFactory, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null)
    {
        parentFactory.KeyPairCredentialsFactory = new InnerDataSourceKeyPairCredentialsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KeyPairCredentialsFactory);
    }

    public static CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1>(this CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentialPair(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1>(this CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, WithCredentialPair(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, T2, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1, T2>(this CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentialPair(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, T2, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1, T2>(this CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentialPair(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDataSourceCredentialsFactory, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceDataSourceCredentialsFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCredentialPair(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, T2, T3, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1, T2, T3>(this CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialPair(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, T2, T3, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialPair(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDataSourceCredentialsFactory, T3, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceDataSourceCredentialsFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialPair(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceDataSourceCredentialsFactory, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceDataSourceCredentialsFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialPair(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, T2, T3, T4, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialPair(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, T2, T3, T4, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialPair(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDataSourceCredentialsFactory, T3, T4, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceDataSourceCredentialsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialPair(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceDataSourceCredentialsFactory, T4, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceDataSourceCredentialsFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialPair(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceDataSourceCredentialsFactory, InnerDataSourceCredentialPairFactory> WithCredentialPair<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceDataSourceCredentialsFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.CredentialPair> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCredentialPair(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1>(this CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1>(this CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, T2, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1, T2>(this CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, T2, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1, T2>(this CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, T2> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDataSourceCredentialsFactory, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1, T2>(this CombinedResult<T1, T2, InnerDataSourceDataSourceCredentialsFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, T2, T3, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1, T2, T3>(this CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, T2, T3, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1, T2, T3>(this CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDataSourceCredentialsFactory, T3, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataSourceDataSourceCredentialsFactory, T3> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceDataSourceCredentialsFactory, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataSourceDataSourceCredentialsFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, T2, T3, T4, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1, T2, T3, T4>(this CombinedResult<InnerDataSourceDataSourceCredentialsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, T2, T3, T4, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataSourceDataSourceCredentialsFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataSourceDataSourceCredentialsFactory, T3, T4, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataSourceDataSourceCredentialsFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataSourceDataSourceCredentialsFactory, T4, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataSourceDataSourceCredentialsFactory, T4> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataSourceDataSourceCredentialsFactory, InnerDataSourceKeyPairCredentialsFactory> WithKeyPairCredentials<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataSourceDataSourceCredentialsFactory> combinedResult, Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyPairCredentials(combinedResult.T5, subFactoryAction).T2);
}
