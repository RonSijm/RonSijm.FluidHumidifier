// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class CollaborationFactory(string resourceName = null, Action<Humidifier.CleanRooms.Collaboration> factoryAction = null) : ResourceFactory<Humidifier.CleanRooms.Collaboration>(resourceName)
{

    internal List<InnerCollaborationMemberSpecificationFactory> MembersFactories { get; set; } = [];

    internal InnerCollaborationPaymentConfigurationFactory CreatorPaymentConfigurationFactory { get; set; }

    internal InnerCollaborationDataEncryptionMetadataFactory DataEncryptionMetadataFactory { get; set; }

    protected override Humidifier.CleanRooms.Collaboration Create()
    {
        var collaborationResult = CreateCollaboration();
        factoryAction?.Invoke(collaborationResult);

        return collaborationResult;
    }

    private Humidifier.CleanRooms.Collaboration CreateCollaboration()
    {
        var collaborationResult = new Humidifier.CleanRooms.Collaboration
        {
            GivenName = InputResourceName,
        };

        return collaborationResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.Collaboration result)
    {
        base.CreateChildren(result);

        result.Members = MembersFactories.Any() ? MembersFactories.Select(x => x.Build()).ToList() : null;
        result.CreatorPaymentConfiguration ??= CreatorPaymentConfigurationFactory?.Build();
        result.DataEncryptionMetadata ??= DataEncryptionMetadataFactory?.Build();
    }

} // End Of Class

public static class CollaborationFactoryExtensions
{
    public static CombinedResult<CollaborationFactory, InnerCollaborationMemberSpecificationFactory> WithMembers(this CollaborationFactory parentFactory, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null)
    {
        var factory = new InnerCollaborationMemberSpecificationFactory(subFactoryAction);
        parentFactory.MembersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CollaborationFactory, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration(this CollaborationFactory parentFactory, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null)
    {
        parentFactory.CreatorPaymentConfigurationFactory = new InnerCollaborationPaymentConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CreatorPaymentConfigurationFactory);
    }

    public static CombinedResult<CollaborationFactory, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata(this CollaborationFactory parentFactory, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null)
    {
        parentFactory.DataEncryptionMetadataFactory = new InnerCollaborationDataEncryptionMetadataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataEncryptionMetadataFactory);
    }

    public static CombinedResult<CollaborationFactory, T1, InnerCollaborationMemberSpecificationFactory> WithMembers<T1>(this CombinedResult<CollaborationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithMembers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CollaborationFactory, InnerCollaborationMemberSpecificationFactory> WithMembers<T1>(this CombinedResult<T1, CollaborationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithMembers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CollaborationFactory, T1, T2, InnerCollaborationMemberSpecificationFactory> WithMembers<T1, T2>(this CombinedResult<CollaborationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CollaborationFactory, T2, InnerCollaborationMemberSpecificationFactory> WithMembers<T1, T2>(this CombinedResult<T1, CollaborationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CollaborationFactory, InnerCollaborationMemberSpecificationFactory> WithMembers<T1, T2>(this CombinedResult<T1, T2, CollaborationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CollaborationFactory, T1, T2, T3, InnerCollaborationMemberSpecificationFactory> WithMembers<T1, T2, T3>(this CombinedResult<CollaborationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CollaborationFactory, T2, T3, InnerCollaborationMemberSpecificationFactory> WithMembers<T1, T2, T3>(this CombinedResult<T1, CollaborationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CollaborationFactory, T3, InnerCollaborationMemberSpecificationFactory> WithMembers<T1, T2, T3>(this CombinedResult<T1, T2, CollaborationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CollaborationFactory, InnerCollaborationMemberSpecificationFactory> WithMembers<T1, T2, T3>(this CombinedResult<T1, T2, T3, CollaborationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CollaborationFactory, T1, T2, T3, T4, InnerCollaborationMemberSpecificationFactory> WithMembers<T1, T2, T3, T4>(this CombinedResult<CollaborationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CollaborationFactory, T2, T3, T4, InnerCollaborationMemberSpecificationFactory> WithMembers<T1, T2, T3, T4>(this CombinedResult<T1, CollaborationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CollaborationFactory, T3, T4, InnerCollaborationMemberSpecificationFactory> WithMembers<T1, T2, T3, T4>(this CombinedResult<T1, T2, CollaborationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CollaborationFactory, T4, InnerCollaborationMemberSpecificationFactory> WithMembers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CollaborationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CollaborationFactory, InnerCollaborationMemberSpecificationFactory> WithMembers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CollaborationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.MemberSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMembers(combinedResult.T5, subFactoryAction));
    public static CombinedResult<CollaborationFactory, T1, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1>(this CombinedResult<CollaborationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CollaborationFactory, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1>(this CombinedResult<T1, CollaborationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CollaborationFactory, T1, T2, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1, T2>(this CombinedResult<CollaborationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CollaborationFactory, T2, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1, T2>(this CombinedResult<T1, CollaborationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CollaborationFactory, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1, T2>(this CombinedResult<T1, T2, CollaborationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CollaborationFactory, T1, T2, T3, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1, T2, T3>(this CombinedResult<CollaborationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CollaborationFactory, T2, T3, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1, T2, T3>(this CombinedResult<T1, CollaborationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CollaborationFactory, T3, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, CollaborationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CollaborationFactory, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, CollaborationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CollaborationFactory, T1, T2, T3, T4, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<CollaborationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CollaborationFactory, T2, T3, T4, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, CollaborationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CollaborationFactory, T3, T4, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, CollaborationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CollaborationFactory, T4, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CollaborationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CollaborationFactory, InnerCollaborationPaymentConfigurationFactory> WithCreatorPaymentConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CollaborationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCreatorPaymentConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<CollaborationFactory, T1, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1>(this CombinedResult<CollaborationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CollaborationFactory, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1>(this CombinedResult<T1, CollaborationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CollaborationFactory, T1, T2, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1, T2>(this CombinedResult<CollaborationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CollaborationFactory, T2, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1, T2>(this CombinedResult<T1, CollaborationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CollaborationFactory, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1, T2>(this CombinedResult<T1, T2, CollaborationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CollaborationFactory, T1, T2, T3, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1, T2, T3>(this CombinedResult<CollaborationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CollaborationFactory, T2, T3, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1, T2, T3>(this CombinedResult<T1, CollaborationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CollaborationFactory, T3, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1, T2, T3>(this CombinedResult<T1, T2, CollaborationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CollaborationFactory, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1, T2, T3>(this CombinedResult<T1, T2, T3, CollaborationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CollaborationFactory, T1, T2, T3, T4, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1, T2, T3, T4>(this CombinedResult<CollaborationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CollaborationFactory, T2, T3, T4, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1, T2, T3, T4>(this CombinedResult<T1, CollaborationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CollaborationFactory, T3, T4, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, CollaborationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CollaborationFactory, T4, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CollaborationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CollaborationFactory, InnerCollaborationDataEncryptionMetadataFactory> WithDataEncryptionMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CollaborationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.DataEncryptionMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataEncryptionMetadata(combinedResult.T5, subFactoryAction));
}
