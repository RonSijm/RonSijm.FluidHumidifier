// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerConfigurationSetVdmOptionsFactory(Action<Humidifier.SES.ConfigurationSetTypes.VdmOptions> factoryAction = null) : SubResourceFactory<Humidifier.SES.ConfigurationSetTypes.VdmOptions>
{

    internal InnerConfigurationSetDashboardOptionsFactory DashboardOptionsFactory { get; set; }

    internal InnerConfigurationSetGuardianOptionsFactory GuardianOptionsFactory { get; set; }

    protected override Humidifier.SES.ConfigurationSetTypes.VdmOptions Create()
    {
        var vdmOptionsResult = CreateVdmOptions();
        factoryAction?.Invoke(vdmOptionsResult);

        return vdmOptionsResult;
    }

    private Humidifier.SES.ConfigurationSetTypes.VdmOptions CreateVdmOptions()
    {
        var vdmOptionsResult = new Humidifier.SES.ConfigurationSetTypes.VdmOptions();

        return vdmOptionsResult;
    }
    public override void CreateChildren(Humidifier.SES.ConfigurationSetTypes.VdmOptions result)
    {
        base.CreateChildren(result);

        result.DashboardOptions ??= DashboardOptionsFactory?.Build();
        result.GuardianOptions ??= GuardianOptionsFactory?.Build();
    }

} // End Of Class

public static class InnerConfigurationSetVdmOptionsFactoryExtensions
{
    public static CombinedResult<InnerConfigurationSetVdmOptionsFactory, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions(this InnerConfigurationSetVdmOptionsFactory parentFactory, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null)
    {
        parentFactory.DashboardOptionsFactory = new InnerConfigurationSetDashboardOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DashboardOptionsFactory);
    }

    public static CombinedResult<InnerConfigurationSetVdmOptionsFactory, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions(this InnerConfigurationSetVdmOptionsFactory parentFactory, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null)
    {
        parentFactory.GuardianOptionsFactory = new InnerConfigurationSetGuardianOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GuardianOptionsFactory);
    }

    public static CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1>(this CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDashboardOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1>(this CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDashboardOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, T2, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1, T2>(this CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, T2> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDashboardOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, T2, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1, T2>(this CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, T2> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDashboardOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigurationSetVdmOptionsFactory, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1, T2>(this CombinedResult<T1, T2, InnerConfigurationSetVdmOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDashboardOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, T2, T3, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1, T2, T3>(this CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, T2, T3, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1, T2, T3>(this CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, T2, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigurationSetVdmOptionsFactory, T3, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigurationSetVdmOptionsFactory, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigurationSetVdmOptionsFactory, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigurationSetVdmOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, T2, T3, T4, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1, T2, T3, T4>(this CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, T2, T3, T4, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigurationSetVdmOptionsFactory, T3, T4, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigurationSetVdmOptionsFactory, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigurationSetVdmOptionsFactory, T4, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigurationSetVdmOptionsFactory, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfigurationSetVdmOptionsFactory, InnerConfigurationSetDashboardOptionsFactory> WithDashboardOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigurationSetVdmOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.DashboardOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDashboardOptions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1>(this CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithGuardianOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1>(this CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithGuardianOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, T2, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1, T2>(this CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, T2> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGuardianOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, T2, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1, T2>(this CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, T2> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGuardianOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigurationSetVdmOptionsFactory, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1, T2>(this CombinedResult<T1, T2, InnerConfigurationSetVdmOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGuardianOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, T2, T3, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1, T2, T3>(this CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, T2, T3, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1, T2, T3>(this CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, T2, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigurationSetVdmOptionsFactory, T3, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfigurationSetVdmOptionsFactory, T3> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigurationSetVdmOptionsFactory, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfigurationSetVdmOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, T2, T3, T4, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1, T2, T3, T4>(this CombinedResult<InnerConfigurationSetVdmOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, T2, T3, T4, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfigurationSetVdmOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfigurationSetVdmOptionsFactory, T3, T4, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfigurationSetVdmOptionsFactory, T3, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfigurationSetVdmOptionsFactory, T4, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfigurationSetVdmOptionsFactory, T4> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfigurationSetVdmOptionsFactory, InnerConfigurationSetGuardianOptionsFactory> WithGuardianOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfigurationSetVdmOptionsFactory> combinedResult, Action<Humidifier.SES.ConfigurationSetTypes.GuardianOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGuardianOptions(combinedResult.T5, subFactoryAction));
}
