// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerMembershipMembershipProtectedQueryResultConfigurationFactory(Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration>
{

    internal InnerMembershipMembershipProtectedQueryOutputConfigurationFactory OutputConfigurationFactory { get; set; }

    protected override Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration Create()
    {
        var membershipProtectedQueryResultConfigurationResult = CreateMembershipProtectedQueryResultConfiguration();
        factoryAction?.Invoke(membershipProtectedQueryResultConfigurationResult);

        return membershipProtectedQueryResultConfigurationResult;
    }

    private Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration CreateMembershipProtectedQueryResultConfiguration()
    {
        var membershipProtectedQueryResultConfigurationResult = new Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration();

        return membershipProtectedQueryResultConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryResultConfiguration result)
    {
        base.CreateChildren(result);

        result.OutputConfiguration ??= OutputConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMembershipMembershipProtectedQueryResultConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMembershipMembershipProtectedQueryResultConfigurationFactory, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration(this InnerMembershipMembershipProtectedQueryResultConfigurationFactory parentFactory, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null)
    {
        parentFactory.OutputConfigurationFactory = new InnerMembershipMembershipProtectedQueryOutputConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutputConfigurationFactory);
    }

    public static CombinedResult<InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T1, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1>(this CombinedResult<InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1>(this CombinedResult<T1, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T1, T2, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1, T2>(this CombinedResult<InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T2, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1, T2>(this CombinedResult<T1, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T1, T2, T3, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3>(this CombinedResult<InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T2, T3, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T3, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T1, T2, T3, T4, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T2, T3, T4, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T3, T4, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T4, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMembershipMembershipProtectedQueryResultConfigurationFactory, InnerMembershipMembershipProtectedQueryOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMembershipMembershipProtectedQueryResultConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedQueryOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T5, subFactoryAction));
}
