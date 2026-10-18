// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class ApplicationsListFactory(string resourceName = null, Action<Humidifier.FMS.ApplicationsList> factoryAction = null) : ResourceFactory<Humidifier.FMS.ApplicationsList>(resourceName)
{

    internal List<InnerApplicationsListAppFactory> AppsListFactories { get; set; } = [];

    protected override Humidifier.FMS.ApplicationsList Create()
    {
        var applicationsListResult = CreateApplicationsList();
        factoryAction?.Invoke(applicationsListResult);

        return applicationsListResult;
    }

    private Humidifier.FMS.ApplicationsList CreateApplicationsList()
    {
        var applicationsListResult = new Humidifier.FMS.ApplicationsList
        {
            GivenName = InputResourceName,
        };

        return applicationsListResult;
    }
    public override void CreateChildren(Humidifier.FMS.ApplicationsList result)
    {
        base.CreateChildren(result);

        result.AppsList = AppsListFactories.Any() ? AppsListFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ApplicationsListFactoryExtensions
{
    public static CombinedResult<ApplicationsListFactory, InnerApplicationsListAppFactory> WithAppsList(this ApplicationsListFactory parentFactory, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null)
    {
        var factory = new InnerApplicationsListAppFactory(subFactoryAction);
        parentFactory.AppsListFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ApplicationsListFactory, T1, InnerApplicationsListAppFactory> WithAppsList<T1>(this CombinedResult<ApplicationsListFactory, T1> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppsList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationsListFactory, InnerApplicationsListAppFactory> WithAppsList<T1>(this CombinedResult<T1, ApplicationsListFactory> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, WithAppsList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ApplicationsListFactory, T1, T2, InnerApplicationsListAppFactory> WithAppsList<T1, T2>(this CombinedResult<ApplicationsListFactory, T1, T2> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppsList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationsListFactory, T2, InnerApplicationsListAppFactory> WithAppsList<T1, T2>(this CombinedResult<T1, ApplicationsListFactory, T2> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppsList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApplicationsListFactory, InnerApplicationsListAppFactory> WithAppsList<T1, T2>(this CombinedResult<T1, T2, ApplicationsListFactory> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAppsList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ApplicationsListFactory, T1, T2, T3, InnerApplicationsListAppFactory> WithAppsList<T1, T2, T3>(this CombinedResult<ApplicationsListFactory, T1, T2, T3> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppsList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationsListFactory, T2, T3, InnerApplicationsListAppFactory> WithAppsList<T1, T2, T3>(this CombinedResult<T1, ApplicationsListFactory, T2, T3> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppsList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApplicationsListFactory, T3, InnerApplicationsListAppFactory> WithAppsList<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationsListFactory, T3> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppsList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApplicationsListFactory, InnerApplicationsListAppFactory> WithAppsList<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationsListFactory> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAppsList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ApplicationsListFactory, T1, T2, T3, T4, InnerApplicationsListAppFactory> WithAppsList<T1, T2, T3, T4>(this CombinedResult<ApplicationsListFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppsList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ApplicationsListFactory, T2, T3, T4, InnerApplicationsListAppFactory> WithAppsList<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationsListFactory, T2, T3, T4> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppsList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ApplicationsListFactory, T3, T4, InnerApplicationsListAppFactory> WithAppsList<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationsListFactory, T3, T4> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppsList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ApplicationsListFactory, T4, InnerApplicationsListAppFactory> WithAppsList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationsListFactory, T4> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppsList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ApplicationsListFactory, InnerApplicationsListAppFactory> WithAppsList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationsListFactory> combinedResult, Action<Humidifier.FMS.ApplicationsListTypes.App> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAppsList(combinedResult.T5, subFactoryAction).T2);
}
