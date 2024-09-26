// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class RolePolicyFactory(string resourceName = null, Action<Humidifier.IAM.RolePolicy> factoryAction = null) : ResourceFactory<Humidifier.IAM.RolePolicy>(resourceName)
{

    protected override Humidifier.IAM.RolePolicy Create()
    {
        var rolePolicyResult = CreateRolePolicy();
        factoryAction?.Invoke(rolePolicyResult);

        return rolePolicyResult;
    }

    private Humidifier.IAM.RolePolicy CreateRolePolicy()
    {
        var rolePolicyResult = new Humidifier.IAM.RolePolicy
        {
            GivenName = InputResourceName,
        };

        return rolePolicyResult;
    }

} // End Of Class

public static class RolePolicyFactoryExtensions
{
}
