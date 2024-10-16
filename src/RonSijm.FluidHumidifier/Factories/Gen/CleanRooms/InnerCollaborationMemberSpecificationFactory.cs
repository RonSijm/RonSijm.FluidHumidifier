// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerCollaborationMemberSpecificationFactory(Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification>
{

    internal InnerCollaborationPaymentConfigurationFactory PaymentConfigurationFactory { get; set; }

    protected override Humidifier.CleanRooms.CollaborationTypes.MemberSpecification Create()
    {
        var memberSpecificationResult = CreateMemberSpecification();
        factoryAction?.Invoke(memberSpecificationResult);

        return memberSpecificationResult;
    }

    private Humidifier.CleanRooms.CollaborationTypes.MemberSpecification CreateMemberSpecification()
    {
        var memberSpecificationResult = new Humidifier.CleanRooms.CollaborationTypes.MemberSpecification();

        return memberSpecificationResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.CollaborationTypes.MemberSpecification result)
    {
        base.CreateChildren(result);

        result.PaymentConfiguration ??= PaymentConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerCollaborationMemberSpecificationFactoryExtensions
{
    public static CombinedResult<InnerCollaborationMemberSpecificationFactory, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration(this InnerCollaborationMemberSpecificationFactory parentFactory, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null)
    {
        parentFactory.PaymentConfigurationFactory = new InnerCollaborationPaymentConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PaymentConfigurationFactory);
    }

    public static CombinedResult<InnerCollaborationMemberSpecificationFactory, T1, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1>(this CombinedResult<InnerCollaborationMemberSpecificationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCollaborationMemberSpecificationFactory, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1>(this CombinedResult<T1, InnerCollaborationMemberSpecificationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCollaborationMemberSpecificationFactory, T1, T2, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2>(this CombinedResult<InnerCollaborationMemberSpecificationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCollaborationMemberSpecificationFactory, T2, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2>(this CombinedResult<T1, InnerCollaborationMemberSpecificationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCollaborationMemberSpecificationFactory, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerCollaborationMemberSpecificationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCollaborationMemberSpecificationFactory, T1, T2, T3, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3>(this CombinedResult<InnerCollaborationMemberSpecificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCollaborationMemberSpecificationFactory, T2, T3, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerCollaborationMemberSpecificationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCollaborationMemberSpecificationFactory, T3, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerCollaborationMemberSpecificationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCollaborationMemberSpecificationFactory, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCollaborationMemberSpecificationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCollaborationMemberSpecificationFactory, T1, T2, T3, T4, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerCollaborationMemberSpecificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCollaborationMemberSpecificationFactory, T2, T3, T4, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerCollaborationMemberSpecificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCollaborationMemberSpecificationFactory, T3, T4, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCollaborationMemberSpecificationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCollaborationMemberSpecificationFactory, T4, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCollaborationMemberSpecificationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCollaborationMemberSpecificationFactory, InnerCollaborationPaymentConfigurationFactory> WithPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCollaborationMemberSpecificationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPaymentConfiguration(combinedResult.T5, subFactoryAction));
}
