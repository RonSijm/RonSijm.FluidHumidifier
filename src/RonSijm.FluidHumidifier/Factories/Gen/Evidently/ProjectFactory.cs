// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class ProjectFactory(string resourceName = null, Action<Humidifier.Evidently.Project> factoryAction = null) : ResourceFactory<Humidifier.Evidently.Project>(resourceName)
{

    internal InnerProjectDataDeliveryObjectFactory DataDeliveryFactory { get; set; }

    internal InnerProjectAppConfigResourceObjectFactory AppConfigResourceFactory { get; set; }

    protected override Humidifier.Evidently.Project Create()
    {
        var projectResult = CreateProject();
        factoryAction?.Invoke(projectResult);

        return projectResult;
    }

    private Humidifier.Evidently.Project CreateProject()
    {
        var projectResult = new Humidifier.Evidently.Project
        {
            GivenName = InputResourceName,
        };

        return projectResult;
    }
    public override void CreateChildren(Humidifier.Evidently.Project result)
    {
        base.CreateChildren(result);

        result.DataDelivery ??= DataDeliveryFactory?.Build();
        result.AppConfigResource ??= AppConfigResourceFactory?.Build();
    }

} // End Of Class

public static class ProjectFactoryExtensions
{
    public static CombinedResult<ProjectFactory, InnerProjectDataDeliveryObjectFactory> WithDataDelivery(this ProjectFactory parentFactory, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null)
    {
        parentFactory.DataDeliveryFactory = new InnerProjectDataDeliveryObjectFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataDeliveryFactory);
    }

    public static CombinedResult<ProjectFactory, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource(this ProjectFactory parentFactory, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null)
    {
        parentFactory.AppConfigResourceFactory = new InnerProjectAppConfigResourceObjectFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AppConfigResourceFactory);
    }

    public static CombinedResult<ProjectFactory, T1, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1>(this CombinedResult<ProjectFactory, T1> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataDelivery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1>(this CombinedResult<T1, ProjectFactory> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataDelivery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1, T2>(this CombinedResult<ProjectFactory, T1, T2> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataDelivery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1, T2>(this CombinedResult<T1, ProjectFactory, T2> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataDelivery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1, T2>(this CombinedResult<T1, T2, ProjectFactory> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataDelivery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, T3, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1, T2, T3>(this CombinedResult<ProjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataDelivery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, T3, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1, T2, T3>(this CombinedResult<T1, ProjectFactory, T2, T3> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataDelivery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, T3, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1, T2, T3>(this CombinedResult<T1, T2, ProjectFactory, T3> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataDelivery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectFactory, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectFactory> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataDelivery(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, T3, T4, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1, T2, T3, T4>(this CombinedResult<ProjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataDelivery(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, T3, T4, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1, T2, T3, T4>(this CombinedResult<T1, ProjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataDelivery(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, T3, T4, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectFactory, T3, T4> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataDelivery(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectFactory, T4, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectFactory, T4> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataDelivery(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ProjectFactory, InnerProjectDataDeliveryObjectFactory> WithDataDelivery<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectFactory> combinedResult, Action<Humidifier.Evidently.ProjectTypes.DataDeliveryObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataDelivery(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1>(this CombinedResult<ProjectFactory, T1> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppConfigResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1>(this CombinedResult<T1, ProjectFactory> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppConfigResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1, T2>(this CombinedResult<ProjectFactory, T1, T2> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppConfigResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1, T2>(this CombinedResult<T1, ProjectFactory, T2> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppConfigResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1, T2>(this CombinedResult<T1, T2, ProjectFactory> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppConfigResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, T3, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1, T2, T3>(this CombinedResult<ProjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, T3, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1, T2, T3>(this CombinedResult<T1, ProjectFactory, T2, T3> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, T3, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1, T2, T3>(this CombinedResult<T1, T2, ProjectFactory, T3> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectFactory, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectFactory> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, T3, T4, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1, T2, T3, T4>(this CombinedResult<ProjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, T3, T4, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1, T2, T3, T4>(this CombinedResult<T1, ProjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, T3, T4, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectFactory, T3, T4> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectFactory, T4, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectFactory, T4> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ProjectFactory, InnerProjectAppConfigResourceObjectFactory> WithAppConfigResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectFactory> combinedResult, Action<Humidifier.Evidently.ProjectTypes.AppConfigResourceObject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppConfigResource(combinedResult.T5, subFactoryAction));
}
