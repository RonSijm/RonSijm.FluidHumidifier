// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class MembershipFactory(string resourceName = null, Action<Humidifier.CleanRooms.Membership> factoryAction = null) : ResourceFactory<Humidifier.CleanRooms.Membership>(resourceName)
{

    internal InnerMembershipMembershipProtectedQueryResultConfigurationFactory DefaultResultConfigurationFactory { get; set; }

    internal InnerMembershipMembershipPaymentConfigurationFactory PaymentConfigurationFactory { get; set; }

    protected override Humidifier.CleanRooms.Membership Create()
    {
        var membershipResult = CreateMembership();
        factoryAction?.Invoke(membershipResult);

        return membershipResult;
    }

    private Humidifier.CleanRooms.Membership CreateMembership()
    {
        var membershipResult = new Humidifier.CleanRooms.Membership
        {
            GivenName = InputResourceName,
        };

        return membershipResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.Membership result)
    {
        base.CreateChildren(result);

        result.DefaultResultConfiguration ??= DefaultResultConfigurationFactory?.Build();
        result.PaymentConfiguration ??= PaymentConfigurationFactory?.Build();
    }

} // End Of Class

public static class MembershipFactoryExtensions
{
    public static CombinedResult<MembershipFactory, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration(this MembershipFactory parentFactory, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null)
    {
        parentFactory.DefaultResultConfigurationFactory = new InnerMembershipMembershipProtectedQueryResultConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultResultConfigurationFactory);
    }

    public static CombinedResult<MembershipFactory, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration(this MembershipFactory parentFactory, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null)
    {
        parentFactory.PaymentConfigurationFactory = new InnerMembershipMembershipPaymentConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PaymentConfigurationFactory);
    }

    public static CombinedResult<MembershipFactory, T1, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1>(this CombinedResult<MembershipFactory, T1> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MembershipFactory, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1>(this CombinedResult<T1, MembershipFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MembershipFactory, T1, T2, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1, T2>(this CombinedResult<MembershipFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MembershipFactory, T2, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1, T2>(this CombinedResult<T1, MembershipFactory, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MembershipFactory, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1, T2>(this CombinedResult<T1, T2, MembershipFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MembershipFactory, T1, T2, T3, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1, T2, T3>(this CombinedResult<MembershipFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MembershipFactory, T2, T3, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1, T2, T3>(this CombinedResult<T1, MembershipFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MembershipFactory, T3, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, MembershipFactory, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MembershipFactory, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, MembershipFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MembershipFactory, T1, T2, T3, T4, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1, T2, T3, T4>(this CombinedResult<MembershipFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MembershipFactory, T2, T3, T4, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, MembershipFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MembershipFactory, T3, T4, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, MembershipFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MembershipFactory, T4, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MembershipFactory, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MembershipFactory, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> WithDefaultResultConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MembershipFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultResultConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<MembershipFactory, T1, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1>(this CombinedResult<MembershipFactory, T1> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MembershipFactory, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1>(this CombinedResult<T1, MembershipFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MembershipFactory, T1, T2, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2>(this CombinedResult<MembershipFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MembershipFactory, T2, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2>(this CombinedResult<T1, MembershipFactory, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MembershipFactory, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2>(this CombinedResult<T1, T2, MembershipFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MembershipFactory, T1, T2, T3, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3>(this CombinedResult<MembershipFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MembershipFactory, T2, T3, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3>(this CombinedResult<T1, MembershipFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MembershipFactory, T3, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, MembershipFactory, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MembershipFactory, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, MembershipFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MembershipFactory, T1, T2, T3, T4, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<MembershipFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MembershipFactory, T2, T3, T4, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, MembershipFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MembershipFactory, T3, T4, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, MembershipFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MembershipFactory, T4, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MembershipFactory, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MembershipFactory, InnerMembershipMembershipPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MembershipFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipPaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T5, subFactoryAction));
}
