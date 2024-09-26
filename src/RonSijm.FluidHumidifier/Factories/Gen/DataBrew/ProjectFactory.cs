// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class ProjectFactory(string resourceName = null, Action<Humidifier.DataBrew.Project> factoryAction = null) : ResourceFactory<Humidifier.DataBrew.Project>(resourceName)
{

    internal InnerProjectSampleFactory SampleFactory { get; set; }

    protected override Humidifier.DataBrew.Project Create()
    {
        var projectResult = CreateProject();
        factoryAction?.Invoke(projectResult);

        return projectResult;
    }

    private Humidifier.DataBrew.Project CreateProject()
    {
        var projectResult = new Humidifier.DataBrew.Project
        {
            GivenName = InputResourceName,
        };

        return projectResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.Project result)
    {
        base.CreateChildren(result);

        result.Sample ??= SampleFactory?.Build();
    }

} // End Of Class

public static class ProjectFactoryExtensions
{
    public static CombinedResult<ProjectFactory, InnerProjectSampleFactory> WithSample(this ProjectFactory parentFactory, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null)
    {
        parentFactory.SampleFactory = new InnerProjectSampleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SampleFactory);
    }

    public static CombinedResult<ProjectFactory, T1, InnerProjectSampleFactory> WithSample<T1>(this CombinedResult<ProjectFactory, T1> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, WithSample(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, InnerProjectSampleFactory> WithSample<T1>(this CombinedResult<T1, ProjectFactory> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, WithSample(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, InnerProjectSampleFactory> WithSample<T1, T2>(this CombinedResult<ProjectFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSample(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, InnerProjectSampleFactory> WithSample<T1, T2>(this CombinedResult<T1, ProjectFactory, T2> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSample(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, InnerProjectSampleFactory> WithSample<T1, T2>(this CombinedResult<T1, T2, ProjectFactory> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSample(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, T3, InnerProjectSampleFactory> WithSample<T1, T2, T3>(this CombinedResult<ProjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSample(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, T3, InnerProjectSampleFactory> WithSample<T1, T2, T3>(this CombinedResult<T1, ProjectFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSample(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, T3, InnerProjectSampleFactory> WithSample<T1, T2, T3>(this CombinedResult<T1, T2, ProjectFactory, T3> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSample(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectFactory, InnerProjectSampleFactory> WithSample<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectFactory> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSample(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, T3, T4, InnerProjectSampleFactory> WithSample<T1, T2, T3, T4>(this CombinedResult<ProjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSample(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, T3, T4, InnerProjectSampleFactory> WithSample<T1, T2, T3, T4>(this CombinedResult<T1, ProjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSample(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, T3, T4, InnerProjectSampleFactory> WithSample<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSample(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectFactory, T4, InnerProjectSampleFactory> WithSample<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectFactory, T4> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSample(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ProjectFactory, InnerProjectSampleFactory> WithSample<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectFactory> combinedResult, Action<Humidifier.DataBrew.ProjectTypes.Sample> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSample(combinedResult.T5, subFactoryAction));
}
