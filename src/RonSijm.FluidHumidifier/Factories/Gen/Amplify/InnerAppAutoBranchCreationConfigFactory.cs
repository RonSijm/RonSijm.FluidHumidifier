// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class InnerAppAutoBranchCreationConfigFactory(Action<Humidifier.Amplify.AppTypes.AutoBranchCreationConfig> factoryAction = null) : SubResourceFactory<Humidifier.Amplify.AppTypes.AutoBranchCreationConfig>
{

    internal InnerAppBasicAuthConfigFactory BasicAuthConfigFactory { get; set; }

    protected override Humidifier.Amplify.AppTypes.AutoBranchCreationConfig Create()
    {
        var autoBranchCreationConfigResult = CreateAutoBranchCreationConfig();
        factoryAction?.Invoke(autoBranchCreationConfigResult);

        return autoBranchCreationConfigResult;
    }

    private Humidifier.Amplify.AppTypes.AutoBranchCreationConfig CreateAutoBranchCreationConfig()
    {
        var autoBranchCreationConfigResult = new Humidifier.Amplify.AppTypes.AutoBranchCreationConfig();

        return autoBranchCreationConfigResult;
    }
    public override void CreateChildren(Humidifier.Amplify.AppTypes.AutoBranchCreationConfig result)
    {
        base.CreateChildren(result);

        result.BasicAuthConfig ??= BasicAuthConfigFactory?.Build();
    }

} // End Of Class

public static class InnerAppAutoBranchCreationConfigFactoryExtensions
{
    public static CombinedResult<InnerAppAutoBranchCreationConfigFactory, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig(this InnerAppAutoBranchCreationConfigFactory parentFactory, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null)
    {
        parentFactory.BasicAuthConfigFactory = new InnerAppBasicAuthConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BasicAuthConfigFactory);
    }

    public static CombinedResult<InnerAppAutoBranchCreationConfigFactory, T1, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1>(this CombinedResult<InnerAppAutoBranchCreationConfigFactory, T1> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppAutoBranchCreationConfigFactory, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1>(this CombinedResult<T1, InnerAppAutoBranchCreationConfigFactory> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAppAutoBranchCreationConfigFactory, T1, T2, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2>(this CombinedResult<InnerAppAutoBranchCreationConfigFactory, T1, T2> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppAutoBranchCreationConfigFactory, T2, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2>(this CombinedResult<T1, InnerAppAutoBranchCreationConfigFactory, T2> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppAutoBranchCreationConfigFactory, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2>(this CombinedResult<T1, T2, InnerAppAutoBranchCreationConfigFactory> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAppAutoBranchCreationConfigFactory, T1, T2, T3, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3>(this CombinedResult<InnerAppAutoBranchCreationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppAutoBranchCreationConfigFactory, T2, T3, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3>(this CombinedResult<T1, InnerAppAutoBranchCreationConfigFactory, T2, T3> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppAutoBranchCreationConfigFactory, T3, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerAppAutoBranchCreationConfigFactory, T3> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAppAutoBranchCreationConfigFactory, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAppAutoBranchCreationConfigFactory> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAppAutoBranchCreationConfigFactory, T1, T2, T3, T4, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3, T4>(this CombinedResult<InnerAppAutoBranchCreationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAppAutoBranchCreationConfigFactory, T2, T3, T4, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerAppAutoBranchCreationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAppAutoBranchCreationConfigFactory, T3, T4, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAppAutoBranchCreationConfigFactory, T3, T4> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAppAutoBranchCreationConfigFactory, T4, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAppAutoBranchCreationConfigFactory, T4> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAppAutoBranchCreationConfigFactory, InnerAppBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAppAutoBranchCreationConfigFactory> combinedResult, Action<Humidifier.Amplify.AppTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T5, subFactoryAction));
}
