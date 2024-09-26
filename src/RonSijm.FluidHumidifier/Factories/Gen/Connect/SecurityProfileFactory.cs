// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class SecurityProfileFactory(string resourceName = null, Action<Humidifier.Connect.SecurityProfile> factoryAction = null) : ResourceFactory<Humidifier.Connect.SecurityProfile>(resourceName)
{

    internal List<InnerSecurityProfileApplicationFactory> ApplicationsFactories { get; set; } = [];

    protected override Humidifier.Connect.SecurityProfile Create()
    {
        var securityProfileResult = CreateSecurityProfile();
        factoryAction?.Invoke(securityProfileResult);

        return securityProfileResult;
    }

    private Humidifier.Connect.SecurityProfile CreateSecurityProfile()
    {
        var securityProfileResult = new Humidifier.Connect.SecurityProfile
        {
            GivenName = InputResourceName,
        };

        return securityProfileResult;
    }
    public override void CreateChildren(Humidifier.Connect.SecurityProfile result)
    {
        base.CreateChildren(result);

        result.Applications = ApplicationsFactories.Any() ? ApplicationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SecurityProfileFactoryExtensions
{
    public static CombinedResult<SecurityProfileFactory, InnerSecurityProfileApplicationFactory> WithApplications(this SecurityProfileFactory parentFactory, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null)
    {
        var factory = new InnerSecurityProfileApplicationFactory(subFactoryAction);
        parentFactory.ApplicationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SecurityProfileFactory, T1, InnerSecurityProfileApplicationFactory> WithApplications<T1>(this CombinedResult<SecurityProfileFactory, T1> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityProfileFactory, InnerSecurityProfileApplicationFactory> WithApplications<T1>(this CombinedResult<T1, SecurityProfileFactory> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SecurityProfileFactory, T1, T2, InnerSecurityProfileApplicationFactory> WithApplications<T1, T2>(this CombinedResult<SecurityProfileFactory, T1, T2> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityProfileFactory, T2, InnerSecurityProfileApplicationFactory> WithApplications<T1, T2>(this CombinedResult<T1, SecurityProfileFactory, T2> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityProfileFactory, InnerSecurityProfileApplicationFactory> WithApplications<T1, T2>(this CombinedResult<T1, T2, SecurityProfileFactory> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SecurityProfileFactory, T1, T2, T3, InnerSecurityProfileApplicationFactory> WithApplications<T1, T2, T3>(this CombinedResult<SecurityProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityProfileFactory, T2, T3, InnerSecurityProfileApplicationFactory> WithApplications<T1, T2, T3>(this CombinedResult<T1, SecurityProfileFactory, T2, T3> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityProfileFactory, T3, InnerSecurityProfileApplicationFactory> WithApplications<T1, T2, T3>(this CombinedResult<T1, T2, SecurityProfileFactory, T3> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecurityProfileFactory, InnerSecurityProfileApplicationFactory> WithApplications<T1, T2, T3>(this CombinedResult<T1, T2, T3, SecurityProfileFactory> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SecurityProfileFactory, T1, T2, T3, T4, InnerSecurityProfileApplicationFactory> WithApplications<T1, T2, T3, T4>(this CombinedResult<SecurityProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SecurityProfileFactory, T2, T3, T4, InnerSecurityProfileApplicationFactory> WithApplications<T1, T2, T3, T4>(this CombinedResult<T1, SecurityProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SecurityProfileFactory, T3, T4, InnerSecurityProfileApplicationFactory> WithApplications<T1, T2, T3, T4>(this CombinedResult<T1, T2, SecurityProfileFactory, T3, T4> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SecurityProfileFactory, T4, InnerSecurityProfileApplicationFactory> WithApplications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SecurityProfileFactory, T4> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SecurityProfileFactory, InnerSecurityProfileApplicationFactory> WithApplications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SecurityProfileFactory> combinedResult, Action<Humidifier.Connect.SecurityProfileTypes.Application> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplications(combinedResult.T5, subFactoryAction));
}
