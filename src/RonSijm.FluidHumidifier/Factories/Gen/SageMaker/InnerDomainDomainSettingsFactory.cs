// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDomainDomainSettingsFactory(Action<Humidifier.SageMaker.DomainTypes.DomainSettings> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DomainTypes.DomainSettings>
{

    internal InnerDomainDockerSettingsFactory DockerSettingsFactory { get; set; }

    internal InnerDomainRStudioServerProDomainSettingsFactory RStudioServerProDomainSettingsFactory { get; set; }

    protected override Humidifier.SageMaker.DomainTypes.DomainSettings Create()
    {
        var domainSettingsResult = CreateDomainSettings();
        factoryAction?.Invoke(domainSettingsResult);

        return domainSettingsResult;
    }

    private Humidifier.SageMaker.DomainTypes.DomainSettings CreateDomainSettings()
    {
        var domainSettingsResult = new Humidifier.SageMaker.DomainTypes.DomainSettings();

        return domainSettingsResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DomainTypes.DomainSettings result)
    {
        base.CreateChildren(result);

        result.DockerSettings ??= DockerSettingsFactory?.Build();
        result.RStudioServerProDomainSettings ??= RStudioServerProDomainSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerDomainDomainSettingsFactoryExtensions
{
    public static CombinedResult<InnerDomainDomainSettingsFactory, InnerDomainDockerSettingsFactory> WithDockerSettings(this InnerDomainDomainSettingsFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null)
    {
        parentFactory.DockerSettingsFactory = new InnerDomainDockerSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DockerSettingsFactory);
    }

    public static CombinedResult<InnerDomainDomainSettingsFactory, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings(this InnerDomainDomainSettingsFactory parentFactory, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null)
    {
        parentFactory.RStudioServerProDomainSettingsFactory = new InnerDomainRStudioServerProDomainSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RStudioServerProDomainSettingsFactory);
    }

    public static CombinedResult<InnerDomainDomainSettingsFactory, T1, InnerDomainDockerSettingsFactory> WithDockerSettings<T1>(this CombinedResult<InnerDomainDomainSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDockerSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainDomainSettingsFactory, InnerDomainDockerSettingsFactory> WithDockerSettings<T1>(this CombinedResult<T1, InnerDomainDomainSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithDockerSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainDomainSettingsFactory, T1, T2, InnerDomainDockerSettingsFactory> WithDockerSettings<T1, T2>(this CombinedResult<InnerDomainDomainSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDockerSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainDomainSettingsFactory, T2, InnerDomainDockerSettingsFactory> WithDockerSettings<T1, T2>(this CombinedResult<T1, InnerDomainDomainSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDockerSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainDomainSettingsFactory, InnerDomainDockerSettingsFactory> WithDockerSettings<T1, T2>(this CombinedResult<T1, T2, InnerDomainDomainSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDockerSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainDomainSettingsFactory, T1, T2, T3, InnerDomainDockerSettingsFactory> WithDockerSettings<T1, T2, T3>(this CombinedResult<InnerDomainDomainSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDockerSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainDomainSettingsFactory, T2, T3, InnerDomainDockerSettingsFactory> WithDockerSettings<T1, T2, T3>(this CombinedResult<T1, InnerDomainDomainSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDockerSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainDomainSettingsFactory, T3, InnerDomainDockerSettingsFactory> WithDockerSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainDomainSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDockerSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainDomainSettingsFactory, InnerDomainDockerSettingsFactory> WithDockerSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainDomainSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDockerSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainDomainSettingsFactory, T1, T2, T3, T4, InnerDomainDockerSettingsFactory> WithDockerSettings<T1, T2, T3, T4>(this CombinedResult<InnerDomainDomainSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDockerSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainDomainSettingsFactory, T2, T3, T4, InnerDomainDockerSettingsFactory> WithDockerSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainDomainSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDockerSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainDomainSettingsFactory, T3, T4, InnerDomainDockerSettingsFactory> WithDockerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainDomainSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDockerSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainDomainSettingsFactory, T4, InnerDomainDockerSettingsFactory> WithDockerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainDomainSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDockerSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainDomainSettingsFactory, InnerDomainDockerSettingsFactory> WithDockerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainDomainSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.DockerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDockerSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerDomainDomainSettingsFactory, T1, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1>(this CombinedResult<InnerDomainDomainSettingsFactory, T1> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainDomainSettingsFactory, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1>(this CombinedResult<T1, InnerDomainDomainSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDomainDomainSettingsFactory, T1, T2, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1, T2>(this CombinedResult<InnerDomainDomainSettingsFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainDomainSettingsFactory, T2, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1, T2>(this CombinedResult<T1, InnerDomainDomainSettingsFactory, T2> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainDomainSettingsFactory, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1, T2>(this CombinedResult<T1, T2, InnerDomainDomainSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDomainDomainSettingsFactory, T1, T2, T3, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1, T2, T3>(this CombinedResult<InnerDomainDomainSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainDomainSettingsFactory, T2, T3, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1, T2, T3>(this CombinedResult<T1, InnerDomainDomainSettingsFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainDomainSettingsFactory, T3, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerDomainDomainSettingsFactory, T3> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainDomainSettingsFactory, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDomainDomainSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDomainDomainSettingsFactory, T1, T2, T3, T4, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1, T2, T3, T4>(this CombinedResult<InnerDomainDomainSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDomainDomainSettingsFactory, T2, T3, T4, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerDomainDomainSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDomainDomainSettingsFactory, T3, T4, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDomainDomainSettingsFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDomainDomainSettingsFactory, T4, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDomainDomainSettingsFactory, T4> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDomainDomainSettingsFactory, InnerDomainRStudioServerProDomainSettingsFactory> WithRStudioServerProDomainSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDomainDomainSettingsFactory> combinedResult, Action<Humidifier.SageMaker.DomainTypes.RStudioServerProDomainSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRStudioServerProDomainSettings(combinedResult.T5, subFactoryAction));
}
