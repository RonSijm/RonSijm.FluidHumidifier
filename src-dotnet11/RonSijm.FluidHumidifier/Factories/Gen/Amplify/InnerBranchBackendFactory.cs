// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class InnerBranchBackendFactory(Action<Humidifier.Amplify.BranchTypes.Backend> factoryAction = null) : SubResourceFactory<Humidifier.Amplify.BranchTypes.Backend>
{

    protected override Humidifier.Amplify.BranchTypes.Backend Create()
    {
        var backendResult = CreateBackend();
        factoryAction?.Invoke(backendResult);

        return backendResult;
    }

    private Humidifier.Amplify.BranchTypes.Backend CreateBackend()
    {
        var backendResult = new Humidifier.Amplify.BranchTypes.Backend();

        return backendResult;
    }

} // End Of Class

public static class InnerBranchBackendFactoryExtensions
{
}
