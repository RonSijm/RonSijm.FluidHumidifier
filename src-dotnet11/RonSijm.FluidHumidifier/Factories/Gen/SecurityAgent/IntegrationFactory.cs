// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class IntegrationFactory(string resourceName = null, Action<Humidifier.SecurityAgent.Integration> factoryAction = null) : ResourceFactory<Humidifier.SecurityAgent.Integration>(resourceName)
{

    internal InnerIntegrationProviderInputFactory ProviderInputFactory { get; set; }

    protected override Humidifier.SecurityAgent.Integration Create()
    {
        var integrationResult = CreateIntegration();
        factoryAction?.Invoke(integrationResult);

        return integrationResult;
    }

    private Humidifier.SecurityAgent.Integration CreateIntegration()
    {
        var integrationResult = new Humidifier.SecurityAgent.Integration
        {
            GivenName = InputResourceName,
        };

        return integrationResult;
    }
    public override void CreateChildren(Humidifier.SecurityAgent.Integration result)
    {
        base.CreateChildren(result);

        result.ProviderInput ??= ProviderInputFactory?.Build();
    }

} // End Of Class

public static class IntegrationFactoryExtensions
{
    public static CombinedResult<IntegrationFactory, InnerIntegrationProviderInputFactory> WithProviderInput(this IntegrationFactory parentFactory, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null)
    {
        parentFactory.ProviderInputFactory = new InnerIntegrationProviderInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ProviderInputFactory);
    }

    public static CombinedResult<IntegrationFactory, T1, InnerIntegrationProviderInputFactory> WithProviderInput<T1>(this CombinedResult<IntegrationFactory, T1> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithProviderInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, InnerIntegrationProviderInputFactory> WithProviderInput<T1>(this CombinedResult<T1, IntegrationFactory> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithProviderInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<IntegrationFactory, T1, T2, InnerIntegrationProviderInputFactory> WithProviderInput<T1, T2>(this CombinedResult<IntegrationFactory, T1, T2> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, T2, InnerIntegrationProviderInputFactory> WithProviderInput<T1, T2>(this CombinedResult<T1, IntegrationFactory, T2> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntegrationFactory, InnerIntegrationProviderInputFactory> WithProviderInput<T1, T2>(this CombinedResult<T1, T2, IntegrationFactory> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProviderInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<IntegrationFactory, T1, T2, T3, InnerIntegrationProviderInputFactory> WithProviderInput<T1, T2, T3>(this CombinedResult<IntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, T2, T3, InnerIntegrationProviderInputFactory> WithProviderInput<T1, T2, T3>(this CombinedResult<T1, IntegrationFactory, T2, T3> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntegrationFactory, T3, InnerIntegrationProviderInputFactory> WithProviderInput<T1, T2, T3>(this CombinedResult<T1, T2, IntegrationFactory, T3> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IntegrationFactory, InnerIntegrationProviderInputFactory> WithProviderInput<T1, T2, T3>(this CombinedResult<T1, T2, T3, IntegrationFactory> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProviderInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<IntegrationFactory, T1, T2, T3, T4, InnerIntegrationProviderInputFactory> WithProviderInput<T1, T2, T3, T4>(this CombinedResult<IntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderInput(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, IntegrationFactory, T2, T3, T4, InnerIntegrationProviderInputFactory> WithProviderInput<T1, T2, T3, T4>(this CombinedResult<T1, IntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderInput(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, IntegrationFactory, T3, T4, InnerIntegrationProviderInputFactory> WithProviderInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, IntegrationFactory, T3, T4> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderInput(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, IntegrationFactory, T4, InnerIntegrationProviderInputFactory> WithProviderInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, IntegrationFactory, T4> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderInput(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, IntegrationFactory, InnerIntegrationProviderInputFactory> WithProviderInput<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, IntegrationFactory> combinedResult, Action<Humidifier.SecurityAgent.IntegrationTypes.ProviderInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProviderInput(combinedResult.T5, subFactoryAction).T2);
}
