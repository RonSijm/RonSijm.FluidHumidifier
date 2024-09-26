// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class InnerContainerPrivateRegistryAccessFactory(Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> factoryAction = null) : SubResourceFactory<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess>
{

    internal InnerContainerEcrImagePullerRoleFactory EcrImagePullerRoleFactory { get; set; }

    protected override Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess Create()
    {
        var privateRegistryAccessResult = CreatePrivateRegistryAccess();
        factoryAction?.Invoke(privateRegistryAccessResult);

        return privateRegistryAccessResult;
    }

    private Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess CreatePrivateRegistryAccess()
    {
        var privateRegistryAccessResult = new Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess();

        return privateRegistryAccessResult;
    }
    public override void CreateChildren(Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess result)
    {
        base.CreateChildren(result);

        result.EcrImagePullerRole ??= EcrImagePullerRoleFactory?.Build();
    }

} // End Of Class

public static class InnerContainerPrivateRegistryAccessFactoryExtensions
{
    public static CombinedResult<InnerContainerPrivateRegistryAccessFactory, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole(this InnerContainerPrivateRegistryAccessFactory parentFactory, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null)
    {
        parentFactory.EcrImagePullerRoleFactory = new InnerContainerEcrImagePullerRoleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EcrImagePullerRoleFactory);
    }

    public static CombinedResult<InnerContainerPrivateRegistryAccessFactory, T1, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1>(this CombinedResult<InnerContainerPrivateRegistryAccessFactory, T1> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerPrivateRegistryAccessFactory, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1>(this CombinedResult<T1, InnerContainerPrivateRegistryAccessFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerContainerPrivateRegistryAccessFactory, T1, T2, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1, T2>(this CombinedResult<InnerContainerPrivateRegistryAccessFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerPrivateRegistryAccessFactory, T2, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1, T2>(this CombinedResult<T1, InnerContainerPrivateRegistryAccessFactory, T2> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerPrivateRegistryAccessFactory, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1, T2>(this CombinedResult<T1, T2, InnerContainerPrivateRegistryAccessFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerContainerPrivateRegistryAccessFactory, T1, T2, T3, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1, T2, T3>(this CombinedResult<InnerContainerPrivateRegistryAccessFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerPrivateRegistryAccessFactory, T2, T3, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1, T2, T3>(this CombinedResult<T1, InnerContainerPrivateRegistryAccessFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerPrivateRegistryAccessFactory, T3, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1, T2, T3>(this CombinedResult<T1, T2, InnerContainerPrivateRegistryAccessFactory, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContainerPrivateRegistryAccessFactory, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerContainerPrivateRegistryAccessFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerContainerPrivateRegistryAccessFactory, T1, T2, T3, T4, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1, T2, T3, T4>(this CombinedResult<InnerContainerPrivateRegistryAccessFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerContainerPrivateRegistryAccessFactory, T2, T3, T4, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1, T2, T3, T4>(this CombinedResult<T1, InnerContainerPrivateRegistryAccessFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerContainerPrivateRegistryAccessFactory, T3, T4, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerContainerPrivateRegistryAccessFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerContainerPrivateRegistryAccessFactory, T4, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerContainerPrivateRegistryAccessFactory, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerContainerPrivateRegistryAccessFactory, InnerContainerEcrImagePullerRoleFactory> WithEcrImagePullerRole<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerContainerPrivateRegistryAccessFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.EcrImagePullerRole> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEcrImagePullerRole(combinedResult.T5, subFactoryAction));
}
