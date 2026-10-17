// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class InnerSessionLoggerLogConfigurationFactory(Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration>
{

    internal InnerSessionLoggerS3LogConfigurationFactory S3Factory { get; set; }

    protected override Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration Create()
    {
        var logConfigurationResult = CreateLogConfiguration();
        factoryAction?.Invoke(logConfigurationResult);

        return logConfigurationResult;
    }

    private Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration CreateLogConfiguration()
    {
        var logConfigurationResult = new Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration();

        return logConfigurationResult;
    }
    public override void CreateChildren(Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
    }

} // End Of Class

public static class InnerSessionLoggerLogConfigurationFactoryExtensions
{
    public static CombinedResult<InnerSessionLoggerLogConfigurationFactory, InnerSessionLoggerS3LogConfigurationFactory> WithS3(this InnerSessionLoggerLogConfigurationFactory parentFactory, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerSessionLoggerS3LogConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerSessionLoggerLogConfigurationFactory, T1, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1>(this CombinedResult<InnerSessionLoggerLogConfigurationFactory, T1> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSessionLoggerLogConfigurationFactory, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1>(this CombinedResult<T1, InnerSessionLoggerLogConfigurationFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerSessionLoggerLogConfigurationFactory, T1, T2, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1, T2>(this CombinedResult<InnerSessionLoggerLogConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSessionLoggerLogConfigurationFactory, T2, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, InnerSessionLoggerLogConfigurationFactory, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSessionLoggerLogConfigurationFactory, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerSessionLoggerLogConfigurationFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerSessionLoggerLogConfigurationFactory, T1, T2, T3, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<InnerSessionLoggerLogConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSessionLoggerLogConfigurationFactory, T2, T3, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerSessionLoggerLogConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSessionLoggerLogConfigurationFactory, T3, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerSessionLoggerLogConfigurationFactory, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSessionLoggerLogConfigurationFactory, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSessionLoggerLogConfigurationFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerSessionLoggerLogConfigurationFactory, T1, T2, T3, T4, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerSessionLoggerLogConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerSessionLoggerLogConfigurationFactory, T2, T3, T4, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerSessionLoggerLogConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerSessionLoggerLogConfigurationFactory, T3, T4, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSessionLoggerLogConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerSessionLoggerLogConfigurationFactory, T4, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSessionLoggerLogConfigurationFactory, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerSessionLoggerLogConfigurationFactory, InnerSessionLoggerS3LogConfigurationFactory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSessionLoggerLogConfigurationFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.S3LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction).T2);
}
