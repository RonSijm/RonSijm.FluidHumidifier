// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class VdmAttributesFactory(string resourceName = null, Action<Humidifier.SES.VdmAttributes> factoryAction = null) : ResourceFactory<Humidifier.SES.VdmAttributes>(resourceName)
{

    internal InnerVdmAttributesDashboardAttributesFactory DashboardAttributesFactory { get; set; }

    internal InnerVdmAttributesGuardianAttributesFactory GuardianAttributesFactory { get; set; }

    protected override Humidifier.SES.VdmAttributes Create()
    {
        var vdmAttributesResult = CreateVdmAttributes();
        factoryAction?.Invoke(vdmAttributesResult);

        return vdmAttributesResult;
    }

    private Humidifier.SES.VdmAttributes CreateVdmAttributes()
    {
        var vdmAttributesResult = new Humidifier.SES.VdmAttributes
        {
            GivenName = InputResourceName,
        };

        return vdmAttributesResult;
    }
    public override void CreateChildren(Humidifier.SES.VdmAttributes result)
    {
        base.CreateChildren(result);

        result.DashboardAttributes ??= DashboardAttributesFactory?.Build();
        result.GuardianAttributes ??= GuardianAttributesFactory?.Build();
    }

} // End Of Class

public static class VdmAttributesFactoryExtensions
{
    public static CombinedResult<VdmAttributesFactory, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes(this VdmAttributesFactory parentFactory, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null)
    {
        parentFactory.DashboardAttributesFactory = new InnerVdmAttributesDashboardAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DashboardAttributesFactory);
    }

    public static CombinedResult<VdmAttributesFactory, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes(this VdmAttributesFactory parentFactory, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null)
    {
        parentFactory.GuardianAttributesFactory = new InnerVdmAttributesGuardianAttributesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GuardianAttributesFactory);
    }

    public static CombinedResult<VdmAttributesFactory, T1, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1>(this CombinedResult<VdmAttributesFactory, T1> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VdmAttributesFactory, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1>(this CombinedResult<T1, VdmAttributesFactory> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VdmAttributesFactory, T1, T2, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1, T2>(this CombinedResult<VdmAttributesFactory, T1, T2> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VdmAttributesFactory, T2, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1, T2>(this CombinedResult<T1, VdmAttributesFactory, T2> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VdmAttributesFactory, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1, T2>(this CombinedResult<T1, T2, VdmAttributesFactory> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VdmAttributesFactory, T1, T2, T3, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1, T2, T3>(this CombinedResult<VdmAttributesFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VdmAttributesFactory, T2, T3, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1, T2, T3>(this CombinedResult<T1, VdmAttributesFactory, T2, T3> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VdmAttributesFactory, T3, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1, T2, T3>(this CombinedResult<T1, T2, VdmAttributesFactory, T3> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VdmAttributesFactory, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, VdmAttributesFactory> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VdmAttributesFactory, T1, T2, T3, T4, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1, T2, T3, T4>(this CombinedResult<VdmAttributesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VdmAttributesFactory, T2, T3, T4, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1, T2, T3, T4>(this CombinedResult<T1, VdmAttributesFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VdmAttributesFactory, T3, T4, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, VdmAttributesFactory, T3, T4> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VdmAttributesFactory, T4, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VdmAttributesFactory, T4> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VdmAttributesFactory, InnerVdmAttributesDashboardAttributesFactory> WithDashboardAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VdmAttributesFactory> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.DashboardAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardAttributes(combinedResult.T5, subFactoryAction));
    public static CombinedResult<VdmAttributesFactory, T1, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1>(this CombinedResult<VdmAttributesFactory, T1> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VdmAttributesFactory, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1>(this CombinedResult<T1, VdmAttributesFactory> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VdmAttributesFactory, T1, T2, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1, T2>(this CombinedResult<VdmAttributesFactory, T1, T2> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VdmAttributesFactory, T2, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1, T2>(this CombinedResult<T1, VdmAttributesFactory, T2> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VdmAttributesFactory, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1, T2>(this CombinedResult<T1, T2, VdmAttributesFactory> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VdmAttributesFactory, T1, T2, T3, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1, T2, T3>(this CombinedResult<VdmAttributesFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VdmAttributesFactory, T2, T3, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1, T2, T3>(this CombinedResult<T1, VdmAttributesFactory, T2, T3> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VdmAttributesFactory, T3, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1, T2, T3>(this CombinedResult<T1, T2, VdmAttributesFactory, T3> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VdmAttributesFactory, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1, T2, T3>(this CombinedResult<T1, T2, T3, VdmAttributesFactory> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VdmAttributesFactory, T1, T2, T3, T4, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1, T2, T3, T4>(this CombinedResult<VdmAttributesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VdmAttributesFactory, T2, T3, T4, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1, T2, T3, T4>(this CombinedResult<T1, VdmAttributesFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VdmAttributesFactory, T3, T4, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, VdmAttributesFactory, T3, T4> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VdmAttributesFactory, T4, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VdmAttributesFactory, T4> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VdmAttributesFactory, InnerVdmAttributesGuardianAttributesFactory> WithGuardianAttributes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VdmAttributesFactory> combinedResult, Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianAttributes(combinedResult.T5, subFactoryAction));
}
