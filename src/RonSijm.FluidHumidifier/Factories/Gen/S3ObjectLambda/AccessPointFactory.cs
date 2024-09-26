// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3ObjectLambda;

public class AccessPointFactory(string resourceName = null, Action<Humidifier.S3ObjectLambda.AccessPoint> factoryAction = null) : ResourceFactory<Humidifier.S3ObjectLambda.AccessPoint>(resourceName)
{

    internal InnerAccessPointObjectLambdaConfigurationFactory ObjectLambdaConfigurationFactory { get; set; }

    protected override Humidifier.S3ObjectLambda.AccessPoint Create()
    {
        var accessPointResult = CreateAccessPoint();
        factoryAction?.Invoke(accessPointResult);

        return accessPointResult;
    }

    private Humidifier.S3ObjectLambda.AccessPoint CreateAccessPoint()
    {
        var accessPointResult = new Humidifier.S3ObjectLambda.AccessPoint
        {
            GivenName = InputResourceName,
        };

        return accessPointResult;
    }
    public override void CreateChildren(Humidifier.S3ObjectLambda.AccessPoint result)
    {
        base.CreateChildren(result);

        result.ObjectLambdaConfiguration ??= ObjectLambdaConfigurationFactory?.Build();
    }

} // End Of Class

public static class AccessPointFactoryExtensions
{
    public static CombinedResult<AccessPointFactory, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration(this AccessPointFactory parentFactory, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null)
    {
        parentFactory.ObjectLambdaConfigurationFactory = new InnerAccessPointObjectLambdaConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ObjectLambdaConfigurationFactory);
    }

    public static CombinedResult<AccessPointFactory, T1, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1>(this CombinedResult<AccessPointFactory, T1> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1>(this CombinedResult<T1, AccessPointFactory> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AccessPointFactory, T1, T2, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1, T2>(this CombinedResult<AccessPointFactory, T1, T2> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, T2, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1, T2>(this CombinedResult<T1, AccessPointFactory, T2> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPointFactory, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1, T2>(this CombinedResult<T1, T2, AccessPointFactory> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AccessPointFactory, T1, T2, T3, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1, T2, T3>(this CombinedResult<AccessPointFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, T2, T3, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1, T2, T3>(this CombinedResult<T1, AccessPointFactory, T2, T3> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPointFactory, T3, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, AccessPointFactory, T3> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessPointFactory, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, AccessPointFactory> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AccessPointFactory, T1, T2, T3, T4, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1, T2, T3, T4>(this CombinedResult<AccessPointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AccessPointFactory, T2, T3, T4, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, AccessPointFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AccessPointFactory, T3, T4, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, AccessPointFactory, T3, T4> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AccessPointFactory, T4, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AccessPointFactory, T4> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AccessPointFactory, InnerAccessPointObjectLambdaConfigurationFactory> WithObjectLambdaConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AccessPointFactory> combinedResult, Action<Humidifier.S3ObjectLambda.AccessPointTypes.ObjectLambdaConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithObjectLambdaConfiguration(combinedResult.T5, subFactoryAction));
}
