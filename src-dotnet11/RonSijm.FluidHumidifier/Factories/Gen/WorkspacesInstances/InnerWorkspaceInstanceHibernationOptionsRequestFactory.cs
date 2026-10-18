// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerWorkspaceInstanceHibernationOptionsRequestFactory(Action<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.HibernationOptionsRequest> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.HibernationOptionsRequest>
{

    protected override Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.HibernationOptionsRequest Create()
    {
        var hibernationOptionsRequestResult = CreateHibernationOptionsRequest();
        factoryAction?.Invoke(hibernationOptionsRequestResult);

        return hibernationOptionsRequestResult;
    }

    private Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.HibernationOptionsRequest CreateHibernationOptionsRequest()
    {
        var hibernationOptionsRequestResult = new Humidifier.WorkspacesInstances.WorkspaceInstanceTypes.HibernationOptionsRequest();

        return hibernationOptionsRequestResult;
    }

} // End Of Class

public static class InnerWorkspaceInstanceHibernationOptionsRequestFactoryExtensions
{
}
