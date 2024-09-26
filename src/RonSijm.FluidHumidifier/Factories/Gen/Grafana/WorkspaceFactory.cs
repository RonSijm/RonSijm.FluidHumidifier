// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Grafana;

public class WorkspaceFactory(string resourceName = null, Action<Humidifier.Grafana.Workspace> factoryAction = null) : ResourceFactory<Humidifier.Grafana.Workspace>(resourceName)
{

    internal InnerWorkspaceSamlConfigurationFactory SamlConfigurationFactory { get; set; }

    internal InnerWorkspaceVpcConfigurationFactory VpcConfigurationFactory { get; set; }

    internal InnerWorkspaceNetworkAccessControlFactory NetworkAccessControlFactory { get; set; }

    protected override Humidifier.Grafana.Workspace Create()
    {
        var workspaceResult = CreateWorkspace();
        factoryAction?.Invoke(workspaceResult);

        return workspaceResult;
    }

    private Humidifier.Grafana.Workspace CreateWorkspace()
    {
        var workspaceResult = new Humidifier.Grafana.Workspace
        {
            GivenName = InputResourceName,
        };

        return workspaceResult;
    }
    public override void CreateChildren(Humidifier.Grafana.Workspace result)
    {
        base.CreateChildren(result);

        result.SamlConfiguration ??= SamlConfigurationFactory?.Build();
        result.VpcConfiguration ??= VpcConfigurationFactory?.Build();
        result.NetworkAccessControl ??= NetworkAccessControlFactory?.Build();
    }

} // End Of Class

public static class WorkspaceFactoryExtensions
{
    public static CombinedResult<WorkspaceFactory, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration(this WorkspaceFactory parentFactory, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null)
    {
        parentFactory.SamlConfigurationFactory = new InnerWorkspaceSamlConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SamlConfigurationFactory);
    }

    public static CombinedResult<WorkspaceFactory, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration(this WorkspaceFactory parentFactory, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null)
    {
        parentFactory.VpcConfigurationFactory = new InnerWorkspaceVpcConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigurationFactory);
    }

    public static CombinedResult<WorkspaceFactory, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl(this WorkspaceFactory parentFactory, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null)
    {
        parentFactory.NetworkAccessControlFactory = new InnerWorkspaceNetworkAccessControlFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkAccessControlFactory);
    }

    public static CombinedResult<WorkspaceFactory, T1, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1>(this CombinedResult<WorkspaceFactory, T1> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1>(this CombinedResult<T1, WorkspaceFactory> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1, T2>(this CombinedResult<WorkspaceFactory, T1, T2> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1, T2>(this CombinedResult<T1, WorkspaceFactory, T2> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1, T2>(this CombinedResult<T1, T2, WorkspaceFactory> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1, T2, T3>(this CombinedResult<WorkspaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1, T2, T3>(this CombinedResult<T1, WorkspaceFactory, T2, T3> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceFactory, T3> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceFactory> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, T4, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1, T2, T3, T4>(this CombinedResult<WorkspaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, T4, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, T4, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceFactory, T3, T4> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, T4, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceFactory, T4> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkspaceFactory, InnerWorkspaceSamlConfigurationFactory> WithSamlConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceFactory> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.SamlConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSamlConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<WorkspaceFactory, T1> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1>(this CombinedResult<T1, WorkspaceFactory> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<WorkspaceFactory, T1, T2> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, WorkspaceFactory, T2> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1, T2>(this CombinedResult<T1, T2, WorkspaceFactory> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<WorkspaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, WorkspaceFactory, T2, T3> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceFactory, T3> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceFactory> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, T4, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<WorkspaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, T4, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, T4, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceFactory, T3, T4> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, T4, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceFactory, T4> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkspaceFactory, InnerWorkspaceVpcConfigurationFactory> WithVpcConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceFactory> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.VpcConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1>(this CombinedResult<WorkspaceFactory, T1> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1>(this CombinedResult<T1, WorkspaceFactory> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1, T2>(this CombinedResult<WorkspaceFactory, T1, T2> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1, T2>(this CombinedResult<T1, WorkspaceFactory, T2> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1, T2>(this CombinedResult<T1, T2, WorkspaceFactory> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1, T2, T3>(this CombinedResult<WorkspaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1, T2, T3>(this CombinedResult<T1, WorkspaceFactory, T2, T3> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1, T2, T3>(this CombinedResult<T1, T2, WorkspaceFactory, T3> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1, T2, T3>(this CombinedResult<T1, T2, T3, WorkspaceFactory> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WorkspaceFactory, T1, T2, T3, T4, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1, T2, T3, T4>(this CombinedResult<WorkspaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WorkspaceFactory, T2, T3, T4, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1, T2, T3, T4>(this CombinedResult<T1, WorkspaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WorkspaceFactory, T3, T4, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1, T2, T3, T4>(this CombinedResult<T1, T2, WorkspaceFactory, T3, T4> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WorkspaceFactory, T4, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WorkspaceFactory, T4> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WorkspaceFactory, InnerWorkspaceNetworkAccessControlFactory> WithNetworkAccessControl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WorkspaceFactory> combinedResult, Action<Humidifier.Grafana.WorkspaceTypes.NetworkAccessControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccessControl(combinedResult.T5, subFactoryAction));
}
