// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class InnerRepositoryLifecyclePolicyFactory(Action<Humidifier.ECR.RepositoryTypes.LifecyclePolicy> factoryAction = null) : SubResourceFactory<Humidifier.ECR.RepositoryTypes.LifecyclePolicy>
{

    protected override Humidifier.ECR.RepositoryTypes.LifecyclePolicy Create()
    {
        var lifecyclePolicyResult = CreateLifecyclePolicy();
        factoryAction?.Invoke(lifecyclePolicyResult);

        return lifecyclePolicyResult;
    }

    private Humidifier.ECR.RepositoryTypes.LifecyclePolicy CreateLifecyclePolicy()
    {
        var lifecyclePolicyResult = new Humidifier.ECR.RepositoryTypes.LifecyclePolicy();

        return lifecyclePolicyResult;
    }

} // End Of Class

public static class InnerRepositoryLifecyclePolicyFactoryExtensions
{
}
