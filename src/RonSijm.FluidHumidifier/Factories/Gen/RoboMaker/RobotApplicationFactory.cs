// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RoboMaker;

public class RobotApplicationFactory(string resourceName = null, Action<Humidifier.RoboMaker.RobotApplication> factoryAction = null) : ResourceFactory<Humidifier.RoboMaker.RobotApplication>(resourceName)
{

    internal List<InnerRobotApplicationSourceConfigFactory> SourcesFactories { get; set; } = [];

    internal InnerRobotApplicationRobotSoftwareSuiteFactory RobotSoftwareSuiteFactory { get; set; }

    protected override Humidifier.RoboMaker.RobotApplication Create()
    {
        var robotApplicationResult = CreateRobotApplication();
        factoryAction?.Invoke(robotApplicationResult);

        return robotApplicationResult;
    }

    private Humidifier.RoboMaker.RobotApplication CreateRobotApplication()
    {
        var robotApplicationResult = new Humidifier.RoboMaker.RobotApplication
        {
            GivenName = InputResourceName,
        };

        return robotApplicationResult;
    }
    public override void CreateChildren(Humidifier.RoboMaker.RobotApplication result)
    {
        base.CreateChildren(result);

        result.Sources = SourcesFactories.Any() ? SourcesFactories.Select(x => x.Build()).ToList() : null;
        result.RobotSoftwareSuite ??= RobotSoftwareSuiteFactory?.Build();
    }

} // End Of Class

public static class RobotApplicationFactoryExtensions
{
    public static CombinedResult<RobotApplicationFactory, InnerRobotApplicationSourceConfigFactory> WithSources(this RobotApplicationFactory parentFactory, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null)
    {
        var factory = new InnerRobotApplicationSourceConfigFactory(subFactoryAction);
        parentFactory.SourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RobotApplicationFactory, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite(this RobotApplicationFactory parentFactory, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null)
    {
        parentFactory.RobotSoftwareSuiteFactory = new InnerRobotApplicationRobotSoftwareSuiteFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RobotSoftwareSuiteFactory);
    }

    public static CombinedResult<RobotApplicationFactory, T1, InnerRobotApplicationSourceConfigFactory> WithSources<T1>(this CombinedResult<RobotApplicationFactory, T1> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RobotApplicationFactory, InnerRobotApplicationSourceConfigFactory> WithSources<T1>(this CombinedResult<T1, RobotApplicationFactory> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RobotApplicationFactory, T1, T2, InnerRobotApplicationSourceConfigFactory> WithSources<T1, T2>(this CombinedResult<RobotApplicationFactory, T1, T2> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RobotApplicationFactory, T2, InnerRobotApplicationSourceConfigFactory> WithSources<T1, T2>(this CombinedResult<T1, RobotApplicationFactory, T2> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RobotApplicationFactory, InnerRobotApplicationSourceConfigFactory> WithSources<T1, T2>(this CombinedResult<T1, T2, RobotApplicationFactory> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RobotApplicationFactory, T1, T2, T3, InnerRobotApplicationSourceConfigFactory> WithSources<T1, T2, T3>(this CombinedResult<RobotApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RobotApplicationFactory, T2, T3, InnerRobotApplicationSourceConfigFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, RobotApplicationFactory, T2, T3> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RobotApplicationFactory, T3, InnerRobotApplicationSourceConfigFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, RobotApplicationFactory, T3> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RobotApplicationFactory, InnerRobotApplicationSourceConfigFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, T3, RobotApplicationFactory> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RobotApplicationFactory, T1, T2, T3, T4, InnerRobotApplicationSourceConfigFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<RobotApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RobotApplicationFactory, T2, T3, T4, InnerRobotApplicationSourceConfigFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, RobotApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RobotApplicationFactory, T3, T4, InnerRobotApplicationSourceConfigFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, RobotApplicationFactory, T3, T4> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RobotApplicationFactory, T4, InnerRobotApplicationSourceConfigFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RobotApplicationFactory, T4> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RobotApplicationFactory, InnerRobotApplicationSourceConfigFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RobotApplicationFactory> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.SourceConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RobotApplicationFactory, T1, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1>(this CombinedResult<RobotApplicationFactory, T1> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RobotApplicationFactory, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1>(this CombinedResult<T1, RobotApplicationFactory> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RobotApplicationFactory, T1, T2, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1, T2>(this CombinedResult<RobotApplicationFactory, T1, T2> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RobotApplicationFactory, T2, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1, T2>(this CombinedResult<T1, RobotApplicationFactory, T2> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RobotApplicationFactory, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1, T2>(this CombinedResult<T1, T2, RobotApplicationFactory> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RobotApplicationFactory, T1, T2, T3, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1, T2, T3>(this CombinedResult<RobotApplicationFactory, T1, T2, T3> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RobotApplicationFactory, T2, T3, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1, T2, T3>(this CombinedResult<T1, RobotApplicationFactory, T2, T3> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RobotApplicationFactory, T3, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1, T2, T3>(this CombinedResult<T1, T2, RobotApplicationFactory, T3> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RobotApplicationFactory, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1, T2, T3>(this CombinedResult<T1, T2, T3, RobotApplicationFactory> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RobotApplicationFactory, T1, T2, T3, T4, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1, T2, T3, T4>(this CombinedResult<RobotApplicationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RobotApplicationFactory, T2, T3, T4, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1, T2, T3, T4>(this CombinedResult<T1, RobotApplicationFactory, T2, T3, T4> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RobotApplicationFactory, T3, T4, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1, T2, T3, T4>(this CombinedResult<T1, T2, RobotApplicationFactory, T3, T4> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RobotApplicationFactory, T4, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RobotApplicationFactory, T4> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RobotApplicationFactory, InnerRobotApplicationRobotSoftwareSuiteFactory> WithRobotSoftwareSuite<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RobotApplicationFactory> combinedResult, Action<Humidifier.RoboMaker.RobotApplicationTypes.RobotSoftwareSuite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRobotSoftwareSuite(combinedResult.T5, subFactoryAction));
}
