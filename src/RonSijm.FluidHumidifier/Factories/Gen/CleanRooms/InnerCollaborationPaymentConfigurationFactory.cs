// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerCollaborationPaymentConfigurationFactory(Action<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration>
{

    internal InnerCollaborationQueryComputePaymentConfigFactory QueryComputeFactory { get; set; }

    protected override Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration Create()
    {
        var paymentConfigurationResult = CreatePaymentConfiguration();
        factoryAction?.Invoke(paymentConfigurationResult);

        return paymentConfigurationResult;
    }

    private Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration CreatePaymentConfiguration()
    {
        var paymentConfigurationResult = new Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration();

        return paymentConfigurationResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.CollaborationTypes.PaymentConfiguration result)
    {
        base.CreateChildren(result);

        result.QueryCompute ??= QueryComputeFactory?.Build();
    }

} // End Of Class

public static class InnerCollaborationPaymentConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCollaborationPaymentConfigurationFactory, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute(this InnerCollaborationPaymentConfigurationFactory parentFactory, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null)
    {
        parentFactory.QueryComputeFactory = new InnerCollaborationQueryComputePaymentConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.QueryComputeFactory);
    }

    public static CombinedResult<InnerCollaborationPaymentConfigurationFactory, T1, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1>(this CombinedResult<InnerCollaborationPaymentConfigurationFactory, T1> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueryCompute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCollaborationPaymentConfigurationFactory, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1>(this CombinedResult<T1, InnerCollaborationPaymentConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithQueryCompute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCollaborationPaymentConfigurationFactory, T1, T2, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2>(this CombinedResult<InnerCollaborationPaymentConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCollaborationPaymentConfigurationFactory, T2, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2>(this CombinedResult<T1, InnerCollaborationPaymentConfigurationFactory, T2> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCollaborationPaymentConfigurationFactory, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2>(this CombinedResult<T1, T2, InnerCollaborationPaymentConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCollaborationPaymentConfigurationFactory, T1, T2, T3, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3>(this CombinedResult<InnerCollaborationPaymentConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCollaborationPaymentConfigurationFactory, T2, T3, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3>(this CombinedResult<T1, InnerCollaborationPaymentConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCollaborationPaymentConfigurationFactory, T3, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3>(this CombinedResult<T1, T2, InnerCollaborationPaymentConfigurationFactory, T3> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCollaborationPaymentConfigurationFactory, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCollaborationPaymentConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCollaborationPaymentConfigurationFactory, T1, T2, T3, T4, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3, T4>(this CombinedResult<InnerCollaborationPaymentConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCollaborationPaymentConfigurationFactory, T2, T3, T4, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3, T4>(this CombinedResult<T1, InnerCollaborationPaymentConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCollaborationPaymentConfigurationFactory, T3, T4, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCollaborationPaymentConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCollaborationPaymentConfigurationFactory, T4, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCollaborationPaymentConfigurationFactory, T4> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCollaborationPaymentConfigurationFactory, InnerCollaborationQueryComputePaymentConfigFactory> WithQueryCompute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCollaborationPaymentConfigurationFactory> combinedResult, Action<Humidifier.CleanRooms.CollaborationTypes.QueryComputePaymentConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQueryCompute(combinedResult.T5, subFactoryAction));
}
