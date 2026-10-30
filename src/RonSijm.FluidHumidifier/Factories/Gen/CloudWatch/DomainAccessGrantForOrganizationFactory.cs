// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class DomainAccessGrantForOrganizationFactory(string resourceName = null, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganization> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.DomainAccessGrantForOrganization>(resourceName)
{

    internal InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory PrincipalFactory { get; set; }

    protected override Humidifier.CloudWatch.DomainAccessGrantForOrganization Create()
    {
        var domainAccessGrantForOrganizationResult = CreateDomainAccessGrantForOrganization();
        factoryAction?.Invoke(domainAccessGrantForOrganizationResult);

        return domainAccessGrantForOrganizationResult;
    }

    private Humidifier.CloudWatch.DomainAccessGrantForOrganization CreateDomainAccessGrantForOrganization()
    {
        var domainAccessGrantForOrganizationResult = new Humidifier.CloudWatch.DomainAccessGrantForOrganization
        {
            GivenName = InputResourceName,
        };

        return domainAccessGrantForOrganizationResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.DomainAccessGrantForOrganization result)
    {
        base.CreateChildren(result);

        result.Principal ??= PrincipalFactory?.Build();
    }

} // End Of Class

public static class DomainAccessGrantForOrganizationFactoryExtensions
{
    public static CombinedResult<DomainAccessGrantForOrganizationFactory, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal(this DomainAccessGrantForOrganizationFactory parentFactory, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null)
    {
        parentFactory.PrincipalFactory = new InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrincipalFactory);
    }

    public static CombinedResult<DomainAccessGrantForOrganizationFactory, T1, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1>(this CombinedResult<DomainAccessGrantForOrganizationFactory, T1> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainAccessGrantForOrganizationFactory, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1>(this CombinedResult<T1, DomainAccessGrantForOrganizationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DomainAccessGrantForOrganizationFactory, T1, T2, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<DomainAccessGrantForOrganizationFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainAccessGrantForOrganizationFactory, T2, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, DomainAccessGrantForOrganizationFactory, T2> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainAccessGrantForOrganizationFactory, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1, T2>(this CombinedResult<T1, T2, DomainAccessGrantForOrganizationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DomainAccessGrantForOrganizationFactory, T1, T2, T3, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<DomainAccessGrantForOrganizationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainAccessGrantForOrganizationFactory, T2, T3, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, DomainAccessGrantForOrganizationFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainAccessGrantForOrganizationFactory, T3, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, DomainAccessGrantForOrganizationFactory, T3> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DomainAccessGrantForOrganizationFactory, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3>(this CombinedResult<T1, T2, T3, DomainAccessGrantForOrganizationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DomainAccessGrantForOrganizationFactory, T1, T2, T3, T4, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<DomainAccessGrantForOrganizationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DomainAccessGrantForOrganizationFactory, T2, T3, T4, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, DomainAccessGrantForOrganizationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DomainAccessGrantForOrganizationFactory, T3, T4, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, DomainAccessGrantForOrganizationFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DomainAccessGrantForOrganizationFactory, T4, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DomainAccessGrantForOrganizationFactory, T4> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DomainAccessGrantForOrganizationFactory, InnerDomainAccessGrantForOrganizationOrganizationAccessGrantPrincipalFactory> WithPrincipal<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DomainAccessGrantForOrganizationFactory> combinedResult, Action<Humidifier.CloudWatch.DomainAccessGrantForOrganizationTypes.OrganizationAccessGrantPrincipal> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrincipal(combinedResult.T5, subFactoryAction).T2);
}
