// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerLambdaHookStackRolesFactory(Action<Humidifier.CloudFormation.LambdaHookTypes.StackRoles> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.LambdaHookTypes.StackRoles>
{

    protected override Humidifier.CloudFormation.LambdaHookTypes.StackRoles Create()
    {
        var stackRolesResult = CreateStackRoles();
        factoryAction?.Invoke(stackRolesResult);

        return stackRolesResult;
    }

    private Humidifier.CloudFormation.LambdaHookTypes.StackRoles CreateStackRoles()
    {
        var stackRolesResult = new Humidifier.CloudFormation.LambdaHookTypes.StackRoles();

        return stackRolesResult;
    }

} // End Of Class

public static class InnerLambdaHookStackRolesFactoryExtensions
{
}
