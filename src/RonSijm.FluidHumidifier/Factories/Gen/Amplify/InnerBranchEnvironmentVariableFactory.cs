// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class InnerBranchEnvironmentVariableFactory(Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> factoryAction = null) : SubResourceFactory<Humidifier.Amplify.BranchTypes.EnvironmentVariable>
{

    protected override Humidifier.Amplify.BranchTypes.EnvironmentVariable Create()
    {
        var environmentVariableResult = CreateEnvironmentVariable();
        factoryAction?.Invoke(environmentVariableResult);

        return environmentVariableResult;
    }

    private Humidifier.Amplify.BranchTypes.EnvironmentVariable CreateEnvironmentVariable()
    {
        var environmentVariableResult = new Humidifier.Amplify.BranchTypes.EnvironmentVariable();

        return environmentVariableResult;
    }

} // End Of Class

public static class InnerBranchEnvironmentVariableFactoryExtensions
{
}
