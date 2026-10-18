// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerWorkspaceInstanceIamInstanceProfileSpecificationFactory(Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.IamInstanceProfileSpecification> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.IamInstanceProfileSpecification>
{

    protected override Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.IamInstanceProfileSpecification Create()
    {
        var iamInstanceProfileSpecificationResult = CreateIamInstanceProfileSpecification();
        factoryAction?.Invoke(iamInstanceProfileSpecificationResult);

        return iamInstanceProfileSpecificationResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.IamInstanceProfileSpecification CreateIamInstanceProfileSpecification()
    {
        var iamInstanceProfileSpecificationResult = new Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.IamInstanceProfileSpecification();

        return iamInstanceProfileSpecificationResult;
    }

} // End Of Class

public static class InnerWorkspaceInstanceIamInstanceProfileSpecificationFactoryExtensions
{
}
