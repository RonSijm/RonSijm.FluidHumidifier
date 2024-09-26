// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Grafana;

public class InnerWorkspaceRoleValuesFactory(Action<Humidifier.Grafana.WorkspaceTypes.RoleValues> factoryAction = null) : SubResourceFactory<Humidifier.Grafana.WorkspaceTypes.RoleValues>
{

    protected override Humidifier.Grafana.WorkspaceTypes.RoleValues Create()
    {
        var roleValuesResult = CreateRoleValues();
        factoryAction?.Invoke(roleValuesResult);

        return roleValuesResult;
    }

    private Humidifier.Grafana.WorkspaceTypes.RoleValues CreateRoleValues()
    {
        var roleValuesResult = new Humidifier.Grafana.WorkspaceTypes.RoleValues();

        return roleValuesResult;
    }

} // End Of Class

public static class InnerWorkspaceRoleValuesFactoryExtensions
{
}
