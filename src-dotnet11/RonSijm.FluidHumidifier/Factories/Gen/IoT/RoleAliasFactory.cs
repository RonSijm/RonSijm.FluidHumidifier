// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class RoleAliasFactory(string resourceName = null, Action<Humidifier.IoT.RoleAlias> factoryAction = null) : ResourceFactory<Humidifier.IoT.RoleAlias>(resourceName)
{

    protected override Humidifier.IoT.RoleAlias Create()
    {
        var roleAliasResult = CreateRoleAlias();
        factoryAction?.Invoke(roleAliasResult);

        return roleAliasResult;
    }

    private Humidifier.IoT.RoleAlias CreateRoleAlias()
    {
        var roleAliasResult = new Humidifier.IoT.RoleAlias
        {
            GivenName = InputResourceName,
        };

        return roleAliasResult;
    }

} // End Of Class

public static class RoleAliasFactoryExtensions
{
}
