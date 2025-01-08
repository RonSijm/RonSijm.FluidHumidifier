// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerGuardHookStackRolesFactory(Action<Humidifier.CloudFormation.GuardHookTypes.StackRoles> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.GuardHookTypes.StackRoles>
{

    protected override Humidifier.CloudFormation.GuardHookTypes.StackRoles Create()
    {
        var stackRolesResult = CreateStackRoles();
        factoryAction?.Invoke(stackRolesResult);

        return stackRolesResult;
    }

    private Humidifier.CloudFormation.GuardHookTypes.StackRoles CreateStackRoles()
    {
        var stackRolesResult = new Humidifier.CloudFormation.GuardHookTypes.StackRoles();

        return stackRolesResult;
    }

} // End Of Class

public static class InnerGuardHookStackRolesFactoryExtensions
{
}
