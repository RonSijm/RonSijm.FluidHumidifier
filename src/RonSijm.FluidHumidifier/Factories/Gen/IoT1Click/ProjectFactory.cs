// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT1Click;

public class ProjectFactory(string resourceName = null, Action<Humidifier.IoT1Click.Project> factoryAction = null) : ResourceFactory<Humidifier.IoT1Click.Project>(resourceName)
{

    internal InnerProjectPlacementTemplateFactory PlacementTemplateFactory { get; set; }

    protected override Humidifier.IoT1Click.Project Create()
    {
        var projectResult = CreateProject();
        factoryAction?.Invoke(projectResult);

        return projectResult;
    }

    private Humidifier.IoT1Click.Project CreateProject()
    {
        var projectResult = new Humidifier.IoT1Click.Project
        {
            GivenName = InputResourceName,
        };

        return projectResult;
    }
    public override void CreateChildren(Humidifier.IoT1Click.Project result)
    {
        base.CreateChildren(result);

        result.PlacementTemplate ??= PlacementTemplateFactory?.Build();
    }

} // End Of Class

public static class ProjectFactoryExtensions
{
    public static CombinedResult<ProjectFactory, InnerProjectPlacementTemplateFactory> WithPlacementTemplate(this ProjectFactory parentFactory, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null)
    {
        parentFactory.PlacementTemplateFactory = new InnerProjectPlacementTemplateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PlacementTemplateFactory);
    }

    public static CombinedResult<ProjectFactory, T1, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1>(this CombinedResult<ProjectFactory, T1> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1>(this CombinedResult<T1, ProjectFactory> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1, T2>(this CombinedResult<ProjectFactory, T1, T2> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1, T2>(this CombinedResult<T1, ProjectFactory, T2> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1, T2>(this CombinedResult<T1, T2, ProjectFactory> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, T3, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1, T2, T3>(this CombinedResult<ProjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, T3, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1, T2, T3>(this CombinedResult<T1, ProjectFactory, T2, T3> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, T3, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1, T2, T3>(this CombinedResult<T1, T2, ProjectFactory, T3> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectFactory, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectFactory> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, T3, T4, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1, T2, T3, T4>(this CombinedResult<ProjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, T3, T4, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1, T2, T3, T4>(this CombinedResult<T1, ProjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, T3, T4, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectFactory, T3, T4> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectFactory, T4, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectFactory, T4> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ProjectFactory, InnerProjectPlacementTemplateFactory> WithPlacementTemplate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectFactory> combinedResult, Action<Humidifier.IoT1Click.ProjectTypes.PlacementTemplate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPlacementTemplate(combinedResult.T5, subFactoryAction));
}
