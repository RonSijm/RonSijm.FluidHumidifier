// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class InnerDataAccessorDataAccessorAuthenticationDetailFactory(Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationDetail> factoryAction = null) : SubResourceFactory<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationDetail>
{

    internal InnerDataAccessorDataAccessorAuthenticationConfigurationFactory AuthenticationConfigurationFactory { get; set; }

    protected override Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationDetail Create()
    {
        var dataAccessorAuthenticationDetailResult = CreateDataAccessorAuthenticationDetail();
        factoryAction?.Invoke(dataAccessorAuthenticationDetailResult);

        return dataAccessorAuthenticationDetailResult;
    }

    private Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationDetail CreateDataAccessorAuthenticationDetail()
    {
        var dataAccessorAuthenticationDetailResult = new Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationDetail();

        return dataAccessorAuthenticationDetailResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationDetail result)
    {
        base.CreateChildren(result);

        result.AuthenticationConfiguration ??= AuthenticationConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerDataAccessorDataAccessorAuthenticationDetailFactoryExtensions
{
    public static CombinedResult<InnerDataAccessorDataAccessorAuthenticationDetailFactory, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration(this InnerDataAccessorDataAccessorAuthenticationDetailFactory parentFactory, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null)
    {
        parentFactory.AuthenticationConfigurationFactory = new InnerDataAccessorDataAccessorAuthenticationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthenticationConfigurationFactory);
    }

    public static CombinedResult<InnerDataAccessorDataAccessorAuthenticationDetailFactory, T1, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1>(this CombinedResult<InnerDataAccessorDataAccessorAuthenticationDetailFactory, T1> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationDetailFactory, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1>(this CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationDetailFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDataAccessorDataAccessorAuthenticationDetailFactory, T1, T2, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2>(this CombinedResult<InnerDataAccessorDataAccessorAuthenticationDetailFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationDetailFactory, T2, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2>(this CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationDetailFactory, T2> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAccessorDataAccessorAuthenticationDetailFactory, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerDataAccessorDataAccessorAuthenticationDetailFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDataAccessorDataAccessorAuthenticationDetailFactory, T1, T2, T3, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<InnerDataAccessorDataAccessorAuthenticationDetailFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationDetailFactory, T2, T3, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationDetailFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAccessorDataAccessorAuthenticationDetailFactory, T3, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataAccessorDataAccessorAuthenticationDetailFactory, T3> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataAccessorDataAccessorAuthenticationDetailFactory, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataAccessorDataAccessorAuthenticationDetailFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDataAccessorDataAccessorAuthenticationDetailFactory, T1, T2, T3, T4, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerDataAccessorDataAccessorAuthenticationDetailFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationDetailFactory, T2, T3, T4, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataAccessorDataAccessorAuthenticationDetailFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDataAccessorDataAccessorAuthenticationDetailFactory, T3, T4, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataAccessorDataAccessorAuthenticationDetailFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDataAccessorDataAccessorAuthenticationDetailFactory, T4, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataAccessorDataAccessorAuthenticationDetailFactory, T4> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDataAccessorDataAccessorAuthenticationDetailFactory, InnerDataAccessorDataAccessorAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataAccessorDataAccessorAuthenticationDetailFactory> combinedResult, Action<Humidifier.QBusiness.DataAccessorTypes.DataAccessorAuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T5, subFactoryAction).T2);
}
