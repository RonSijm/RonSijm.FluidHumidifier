// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerAccessPolicyAccessPolicyResourceFactory(Action<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource>
{

    internal InnerAccessPolicyProjectFactory ProjectFactory { get; set; }

    internal InnerAccessPolicyPortalFactory PortalFactory { get; set; }

    protected override Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource Create()
    {
        var accessPolicyResourceResult = CreateAccessPolicyResource();
        factoryAction?.Invoke(accessPolicyResourceResult);

        return accessPolicyResourceResult;
    }

    private Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource CreateAccessPolicyResource()
    {
        var accessPolicyResourceResult = new Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource();

        return accessPolicyResourceResult;
    }
    public override void CreateChildren(Humidifier.IoTSiteWise.AccessPolicyTypes.AccessPolicyResource result)
    {
        base.CreateChildren(result);

        result.Project ??= ProjectFactory?.Build();
        result.Portal ??= PortalFactory?.Build();
    }

} // End Of Class

public static class InnerAccessPolicyAccessPolicyResourceFactoryExtensions
{
    public static CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, InnerAccessPolicyProjectFactory> WithProject(this InnerAccessPolicyAccessPolicyResourceFactory parentFactory, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null)
    {
        parentFactory.ProjectFactory = new InnerAccessPolicyProjectFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProjectFactory);
    }

    public static CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, InnerAccessPolicyPortalFactory> WithPortal(this InnerAccessPolicyAccessPolicyResourceFactory parentFactory, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null)
    {
        parentFactory.PortalFactory = new InnerAccessPolicyPortalFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PortalFactory);
    }

    public static CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, InnerAccessPolicyProjectFactory> WithProject<T1>(this CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, WithProject(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, InnerAccessPolicyProjectFactory> WithProject<T1>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, WithProject(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, T2, InnerAccessPolicyProjectFactory> WithProject<T1, T2>(this CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProject(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, T2, InnerAccessPolicyProjectFactory> WithProject<T1, T2>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProject(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyResourceFactory, InnerAccessPolicyProjectFactory> WithProject<T1, T2>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyResourceFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProject(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, T2, T3, InnerAccessPolicyProjectFactory> WithProject<T1, T2, T3>(this CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProject(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, T2, T3, InnerAccessPolicyProjectFactory> WithProject<T1, T2, T3>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProject(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyResourceFactory, T3, InnerAccessPolicyProjectFactory> WithProject<T1, T2, T3>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyResourceFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProject(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyResourceFactory, InnerAccessPolicyProjectFactory> WithProject<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyResourceFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProject(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, T2, T3, T4, InnerAccessPolicyProjectFactory> WithProject<T1, T2, T3, T4>(this CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProject(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, T2, T3, T4, InnerAccessPolicyProjectFactory> WithProject<T1, T2, T3, T4>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProject(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyResourceFactory, T3, T4, InnerAccessPolicyProjectFactory> WithProject<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyResourceFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProject(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyResourceFactory, T4, InnerAccessPolicyProjectFactory> WithProject<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyResourceFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProject(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAccessPolicyAccessPolicyResourceFactory, InnerAccessPolicyProjectFactory> WithProject<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAccessPolicyAccessPolicyResourceFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Project> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProject(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, InnerAccessPolicyPortalFactory> WithPortal<T1>(this CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, InnerAccessPolicyPortalFactory> WithPortal<T1>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPortal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, T2, InnerAccessPolicyPortalFactory> WithPortal<T1, T2>(this CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, T2, InnerAccessPolicyPortalFactory> WithPortal<T1, T2>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, T2> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyResourceFactory, InnerAccessPolicyPortalFactory> WithPortal<T1, T2>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyResourceFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPortal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, T2, T3, InnerAccessPolicyPortalFactory> WithPortal<T1, T2, T3>(this CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, T2, T3, InnerAccessPolicyPortalFactory> WithPortal<T1, T2, T3>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, T2, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyResourceFactory, T3, InnerAccessPolicyPortalFactory> WithPortal<T1, T2, T3>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyResourceFactory, T3> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyResourceFactory, InnerAccessPolicyPortalFactory> WithPortal<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyResourceFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPortal(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, T2, T3, T4, InnerAccessPolicyPortalFactory> WithPortal<T1, T2, T3, T4>(this CombinedResult<InnerAccessPolicyAccessPolicyResourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortal(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, T2, T3, T4, InnerAccessPolicyPortalFactory> WithPortal<T1, T2, T3, T4>(this CombinedResult<T1, InnerAccessPolicyAccessPolicyResourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortal(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyResourceFactory, T3, T4, InnerAccessPolicyPortalFactory> WithPortal<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAccessPolicyAccessPolicyResourceFactory, T3, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortal(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyResourceFactory, T4, InnerAccessPolicyPortalFactory> WithPortal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAccessPolicyAccessPolicyResourceFactory, T4> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortal(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAccessPolicyAccessPolicyResourceFactory, InnerAccessPolicyPortalFactory> WithPortal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAccessPolicyAccessPolicyResourceFactory> combinedResult, Action<Humidifier.IoTSiteWise.AccessPolicyTypes.Portal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPortal(combinedResult.T5, subFactoryAction));
}
