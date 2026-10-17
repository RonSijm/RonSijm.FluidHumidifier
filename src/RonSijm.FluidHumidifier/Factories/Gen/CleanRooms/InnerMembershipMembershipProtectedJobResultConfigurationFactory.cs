// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerMembershipMembershipProtectedJobResultConfigurationFactory(Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobResultConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobResultConfiguration>
{

    internal InnerMembershipMembershipProtectedJobOutputConfigurationFactory OutputConfigurationFactory { get; set; }

    protected override Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobResultConfiguration Create()
    {
        var membershipProtectedJobResultConfigurationResult = CreateMembershipProtectedJobResultConfiguration();
        factoryAction?.Invoke(membershipProtectedJobResultConfigurationResult);

        return membershipProtectedJobResultConfigurationResult;
    }

    private Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobResultConfiguration CreateMembershipProtectedJobResultConfiguration()
    {
        var membershipProtectedJobResultConfigurationResult = new Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobResultConfiguration();

        return membershipProtectedJobResultConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobResultConfiguration result)
    {
        base.CreateChildren(result);

        result.OutputConfiguration ??= OutputConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMembershipMembershipProtectedJobResultConfigurationFactoryExtensions
{
    public static CombinedResult<InnerMembershipMembershipProtectedJobResultConfigurationFactory, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration(this InnerMembershipMembershipProtectedJobResultConfigurationFactory parentFactory, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null)
    {
        parentFactory.OutputConfigurationFactory = new InnerMembershipMembershipProtectedJobOutputConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutputConfigurationFactory);
    }

    public static CombinedResult<InnerMembershipMembershipProtectedJobResultConfigurationFactory, T1, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1>(this CombinedResult<InnerMembershipMembershipProtectedJobResultConfigurationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMembershipMembershipProtectedJobResultConfigurationFactory, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1>(this CombinedResult<T1, InnerMembershipMembershipProtectedJobResultConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMembershipMembershipProtectedJobResultConfigurationFactory, T1, T2, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1, T2>(this CombinedResult<InnerMembershipMembershipProtectedJobResultConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMembershipMembershipProtectedJobResultConfigurationFactory, T2, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1, T2>(this CombinedResult<T1, InnerMembershipMembershipProtectedJobResultConfigurationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMembershipMembershipProtectedJobResultConfigurationFactory, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMembershipMembershipProtectedJobResultConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMembershipMembershipProtectedJobResultConfigurationFactory, T1, T2, T3, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3>(this CombinedResult<InnerMembershipMembershipProtectedJobResultConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMembershipMembershipProtectedJobResultConfigurationFactory, T2, T3, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMembershipMembershipProtectedJobResultConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMembershipMembershipProtectedJobResultConfigurationFactory, T3, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMembershipMembershipProtectedJobResultConfigurationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedJobResultConfigurationFactory, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedJobResultConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMembershipMembershipProtectedJobResultConfigurationFactory, T1, T2, T3, T4, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMembershipMembershipProtectedJobResultConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMembershipMembershipProtectedJobResultConfigurationFactory, T2, T3, T4, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMembershipMembershipProtectedJobResultConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMembershipMembershipProtectedJobResultConfigurationFactory, T3, T4, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMembershipMembershipProtectedJobResultConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedJobResultConfigurationFactory, T4, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMembershipMembershipProtectedJobResultConfigurationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMembershipMembershipProtectedJobResultConfigurationFactory, InnerMembershipMembershipProtectedJobOutputConfigurationFactory> WithOutputConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMembershipMembershipProtectedJobResultConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.MembershipTypes.MembershipProtectedJobOutputConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfiguration(combinedResult.T5, subFactoryAction).T2);
}
