// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class ContainerFactory(string resourceName = null, Action<Humidifier.Lightsail.Container> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.Container>(resourceName)
{

    internal List<InnerContainerPublicDomainNameFactory> PublicDomainNamesFactories { get; set; } = [];

    internal InnerContainerPrivateRegistryAccessFactory PrivateRegistryAccessFactory { get; set; }

    internal InnerContainerContainerServiceDeploymentFactory ContainerServiceDeploymentFactory { get; set; }

    protected override Humidifier.Lightsail.Container Create()
    {
        var containerResult = CreateContainer();
        factoryAction?.Invoke(containerResult);

        return containerResult;
    }

    private Humidifier.Lightsail.Container CreateContainer()
    {
        var containerResult = new Humidifier.Lightsail.Container
        {
            GivenName = InputResourceName,
        };

        return containerResult;
    }
    public override void CreateChildren(Humidifier.Lightsail.Container result)
    {
        base.CreateChildren(result);

        result.PublicDomainNames = PublicDomainNamesFactories.Any() ? PublicDomainNamesFactories.Select(x => x.Build()).ToList() : null;
        result.PrivateRegistryAccess ??= PrivateRegistryAccessFactory?.Build();
        result.ContainerServiceDeployment ??= ContainerServiceDeploymentFactory?.Build();
    }

} // End Of Class

public static class ContainerFactoryExtensions
{
    public static CombinedResult<ContainerFactory, InnerContainerPublicDomainNameFactory> WithPublicDomainNames(this ContainerFactory parentFactory, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null)
    {
        var factory = new InnerContainerPublicDomainNameFactory(subFactoryAction);
        parentFactory.PublicDomainNamesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ContainerFactory, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess(this ContainerFactory parentFactory, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null)
    {
        parentFactory.PrivateRegistryAccessFactory = new InnerContainerPrivateRegistryAccessFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrivateRegistryAccessFactory);
    }

    public static CombinedResult<ContainerFactory, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment(this ContainerFactory parentFactory, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null)
    {
        parentFactory.ContainerServiceDeploymentFactory = new InnerContainerContainerServiceDeploymentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContainerServiceDeploymentFactory);
    }

    public static CombinedResult<ContainerFactory, T1, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1>(this CombinedResult<ContainerFactory, T1> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1>(this CombinedResult<T1, ContainerFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1, T2>(this CombinedResult<ContainerFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1, T2>(this CombinedResult<T1, ContainerFactory, T2> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1, T2>(this CombinedResult<T1, T2, ContainerFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, T3, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1, T2, T3>(this CombinedResult<ContainerFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, T3, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1, T2, T3>(this CombinedResult<T1, ContainerFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, T3, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1, T2, T3>(this CombinedResult<T1, T2, ContainerFactory, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContainerFactory, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContainerFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, T3, T4, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1, T2, T3, T4>(this CombinedResult<ContainerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, T3, T4, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1, T2, T3, T4>(this CombinedResult<T1, ContainerFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, T3, T4, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContainerFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContainerFactory, T4, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContainerFactory, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ContainerFactory, InnerContainerPublicDomainNameFactory> WithPublicDomainNames<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContainerFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PublicDomainName> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPublicDomainNames(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1>(this CombinedResult<ContainerFactory, T1> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1>(this CombinedResult<T1, ContainerFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1, T2>(this CombinedResult<ContainerFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1, T2>(this CombinedResult<T1, ContainerFactory, T2> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1, T2>(this CombinedResult<T1, T2, ContainerFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, T3, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1, T2, T3>(this CombinedResult<ContainerFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, T3, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1, T2, T3>(this CombinedResult<T1, ContainerFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, T3, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1, T2, T3>(this CombinedResult<T1, T2, ContainerFactory, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContainerFactory, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContainerFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, T3, T4, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1, T2, T3, T4>(this CombinedResult<ContainerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, T3, T4, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1, T2, T3, T4>(this CombinedResult<T1, ContainerFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, T3, T4, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContainerFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContainerFactory, T4, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContainerFactory, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ContainerFactory, InnerContainerPrivateRegistryAccessFactory> WithPrivateRegistryAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContainerFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.PrivateRegistryAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrivateRegistryAccess(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1>(this CombinedResult<ContainerFactory, T1> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1>(this CombinedResult<T1, ContainerFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1, T2>(this CombinedResult<ContainerFactory, T1, T2> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1, T2>(this CombinedResult<T1, ContainerFactory, T2> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1, T2>(this CombinedResult<T1, T2, ContainerFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, T3, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1, T2, T3>(this CombinedResult<ContainerFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, T3, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1, T2, T3>(this CombinedResult<T1, ContainerFactory, T2, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, T3, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1, T2, T3>(this CombinedResult<T1, T2, ContainerFactory, T3> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContainerFactory, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1, T2, T3>(this CombinedResult<T1, T2, T3, ContainerFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ContainerFactory, T1, T2, T3, T4, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1, T2, T3, T4>(this CombinedResult<ContainerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ContainerFactory, T2, T3, T4, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1, T2, T3, T4>(this CombinedResult<T1, ContainerFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ContainerFactory, T3, T4, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1, T2, T3, T4>(this CombinedResult<T1, T2, ContainerFactory, T3, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ContainerFactory, T4, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ContainerFactory, T4> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ContainerFactory, InnerContainerContainerServiceDeploymentFactory> WithContainerServiceDeployment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ContainerFactory> combinedResult, Action<Humidifier.Lightsail.ContainerTypes.ContainerServiceDeployment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerServiceDeployment(combinedResult.T5, subFactoryAction));
}
