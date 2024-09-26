// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ProjectFactory(string resourceName = null, Action<Humidifier.SageMaker.Project> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.Project>(resourceName)
{

    internal InnerProjectServiceCatalogProvisionedProductDetailsFactory ServiceCatalogProvisionedProductDetailsFactory { get; set; }

    internal InnerProjectServiceCatalogProvisioningDetailsFactory ServiceCatalogProvisioningDetailsFactory { get; set; }

    protected override Humidifier.SageMaker.Project Create()
    {
        var projectResult = CreateProject();
        factoryAction?.Invoke(projectResult);

        return projectResult;
    }

    private Humidifier.SageMaker.Project CreateProject()
    {
        var projectResult = new Humidifier.SageMaker.Project
        {
            GivenName = InputResourceName,
        };

        return projectResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.Project result)
    {
        base.CreateChildren(result);

        result.ServiceCatalogProvisionedProductDetails ??= ServiceCatalogProvisionedProductDetailsFactory?.Build();
        result.ServiceCatalogProvisioningDetails ??= ServiceCatalogProvisioningDetailsFactory?.Build();
    }

} // End Of Class

public static class ProjectFactoryExtensions
{
    public static CombinedResult<ProjectFactory, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails(this ProjectFactory parentFactory, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null)
    {
        parentFactory.ServiceCatalogProvisionedProductDetailsFactory = new InnerProjectServiceCatalogProvisionedProductDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServiceCatalogProvisionedProductDetailsFactory);
    }

    public static CombinedResult<ProjectFactory, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails(this ProjectFactory parentFactory, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null)
    {
        parentFactory.ServiceCatalogProvisioningDetailsFactory = new InnerProjectServiceCatalogProvisioningDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServiceCatalogProvisioningDetailsFactory);
    }

    public static CombinedResult<ProjectFactory, T1, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1>(this CombinedResult<ProjectFactory, T1> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1>(this CombinedResult<T1, ProjectFactory> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1, T2>(this CombinedResult<ProjectFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1, T2>(this CombinedResult<T1, ProjectFactory, T2> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1, T2>(this CombinedResult<T1, T2, ProjectFactory> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, T3, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1, T2, T3>(this CombinedResult<ProjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, T3, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1, T2, T3>(this CombinedResult<T1, ProjectFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, T3, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1, T2, T3>(this CombinedResult<T1, T2, ProjectFactory, T3> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectFactory, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectFactory> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, T3, T4, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1, T2, T3, T4>(this CombinedResult<ProjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, T3, T4, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1, T2, T3, T4>(this CombinedResult<T1, ProjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, T3, T4, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectFactory, T4, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectFactory, T4> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ProjectFactory, InnerProjectServiceCatalogProvisionedProductDetailsFactory> WithServiceCatalogProvisionedProductDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectFactory> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisionedProductDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisionedProductDetails(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1>(this CombinedResult<ProjectFactory, T1> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1>(this CombinedResult<T1, ProjectFactory> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1, T2>(this CombinedResult<ProjectFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1, T2>(this CombinedResult<T1, ProjectFactory, T2> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1, T2>(this CombinedResult<T1, T2, ProjectFactory> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, T3, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1, T2, T3>(this CombinedResult<ProjectFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, T3, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1, T2, T3>(this CombinedResult<T1, ProjectFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, T3, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1, T2, T3>(this CombinedResult<T1, T2, ProjectFactory, T3> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectFactory, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, ProjectFactory> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ProjectFactory, T1, T2, T3, T4, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1, T2, T3, T4>(this CombinedResult<ProjectFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ProjectFactory, T2, T3, T4, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1, T2, T3, T4>(this CombinedResult<T1, ProjectFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ProjectFactory, T3, T4, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, ProjectFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ProjectFactory, T4, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ProjectFactory, T4> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ProjectFactory, InnerProjectServiceCatalogProvisioningDetailsFactory> WithServiceCatalogProvisioningDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ProjectFactory> combinedResult, Action<Humidifier.SageMaker.ProjectTypes.ServiceCatalogProvisioningDetails> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceCatalogProvisioningDetails(combinedResult.T5, subFactoryAction));
}
