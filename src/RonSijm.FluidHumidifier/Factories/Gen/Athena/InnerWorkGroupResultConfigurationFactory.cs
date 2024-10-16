// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class InnerWorkGroupResultConfigurationFactory(Action<Humidifier.Athena.WorkGroupTypes.ResultConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Athena.WorkGroupTypes.ResultConfiguration>
{

    internal InnerWorkGroupEncryptionConfigurationFactory EncryptionConfigurationFactory { get; set; }

    internal InnerWorkGroupAclConfigurationFactory AclConfigurationFactory { get; set; }

    protected override Humidifier.Athena.WorkGroupTypes.ResultConfiguration Create()
    {
        var resultConfigurationResult = CreateResultConfiguration();
        factoryAction?.Invoke(resultConfigurationResult);

        return resultConfigurationResult;
    }

    private Humidifier.Athena.WorkGroupTypes.ResultConfiguration CreateResultConfiguration()
    {
        var resultConfigurationResult = new Humidifier.Athena.WorkGroupTypes.ResultConfiguration();

        return resultConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Athena.WorkGroupTypes.ResultConfiguration result)
    {
        base.CreateChildren(result);

        result.EncryptionConfiguration ??= EncryptionConfigurationFactory?.Build();
        result.AclConfiguration ??= AclConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerWorkGroupResultConfigurationFactoryExtensions
{
    public static CombinedResult<InnerWorkGroupResultConfigurationFactory, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration(this InnerWorkGroupResultConfigurationFactory parentFactory, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null)
    {
        parentFactory.EncryptionConfigurationFactory = new InnerWorkGroupEncryptionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionConfigurationFactory);
    }

    public static CombinedResult<InnerWorkGroupResultConfigurationFactory, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration(this InnerWorkGroupResultConfigurationFactory parentFactory, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null)
    {
        parentFactory.AclConfigurationFactory = new InnerWorkGroupAclConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AclConfigurationFactory);
    }

    public static CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<InnerWorkGroupResultConfigurationFactory, T1> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1>(this CombinedResult<T1, InnerWorkGroupResultConfigurationFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, T2, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, T2, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, T2> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkGroupResultConfigurationFactory, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerWorkGroupResultConfigurationFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, T2, T3, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, T2, T3, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkGroupResultConfigurationFactory, T3, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkGroupResultConfigurationFactory, T3> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkGroupResultConfigurationFactory, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkGroupResultConfigurationFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, T2, T3, T4, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, T2, T3, T4, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkGroupResultConfigurationFactory, T3, T4, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkGroupResultConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkGroupResultConfigurationFactory, T4, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkGroupResultConfigurationFactory, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWorkGroupResultConfigurationFactory, InnerWorkGroupEncryptionConfigurationFactory> WithEncryptionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkGroupResultConfigurationFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.EncryptionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryptionConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1>(this CombinedResult<InnerWorkGroupResultConfigurationFactory, T1> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAclConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1>(this CombinedResult<T1, InnerWorkGroupResultConfigurationFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAclConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, T2, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1, T2>(this CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAclConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, T2, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1, T2>(this CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, T2> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAclConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkGroupResultConfigurationFactory, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerWorkGroupResultConfigurationFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAclConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, T2, T3, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1, T2, T3>(this CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAclConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, T2, T3, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAclConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkGroupResultConfigurationFactory, T3, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerWorkGroupResultConfigurationFactory, T3> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAclConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkGroupResultConfigurationFactory, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWorkGroupResultConfigurationFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAclConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, T2, T3, T4, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerWorkGroupResultConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAclConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, T2, T3, T4, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerWorkGroupResultConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAclConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWorkGroupResultConfigurationFactory, T3, T4, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWorkGroupResultConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAclConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWorkGroupResultConfigurationFactory, T4, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWorkGroupResultConfigurationFactory, T4> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAclConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWorkGroupResultConfigurationFactory, InnerWorkGroupAclConfigurationFactory> WithAclConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWorkGroupResultConfigurationFactory> combinedResult, Action<Humidifier.Athena.WorkGroupTypes.AclConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAclConfiguration(combinedResult.T5, subFactoryAction));
}
