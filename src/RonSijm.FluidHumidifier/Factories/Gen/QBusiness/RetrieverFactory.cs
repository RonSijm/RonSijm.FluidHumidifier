// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class RetrieverFactory(string resourceName = null, Action<Humidifier.QBusiness.Retriever> factoryAction = null) : ResourceFactory<Humidifier.QBusiness.Retriever>(resourceName)
{

    internal InnerRetrieverRetrieverConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.QBusiness.Retriever Create()
    {
        var retrieverResult = CreateRetriever();
        factoryAction?.Invoke(retrieverResult);

        return retrieverResult;
    }

    private Humidifier.QBusiness.Retriever CreateRetriever()
    {
        var retrieverResult = new Humidifier.QBusiness.Retriever
        {
            GivenName = InputResourceName,
        };

        return retrieverResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.Retriever result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class RetrieverFactoryExtensions
{
    public static CombinedResult<RetrieverFactory, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration(this RetrieverFactory parentFactory, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerRetrieverRetrieverConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<RetrieverFactory, T1, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1>(this CombinedResult<RetrieverFactory, T1> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RetrieverFactory, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, RetrieverFactory> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RetrieverFactory, T1, T2, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<RetrieverFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RetrieverFactory, T2, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, RetrieverFactory, T2> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RetrieverFactory, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, RetrieverFactory> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RetrieverFactory, T1, T2, T3, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<RetrieverFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RetrieverFactory, T2, T3, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, RetrieverFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RetrieverFactory, T3, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, RetrieverFactory, T3> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RetrieverFactory, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, RetrieverFactory> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RetrieverFactory, T1, T2, T3, T4, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<RetrieverFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RetrieverFactory, T2, T3, T4, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, RetrieverFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RetrieverFactory, T3, T4, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, RetrieverFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RetrieverFactory, T4, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RetrieverFactory, T4> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RetrieverFactory, InnerRetrieverRetrieverConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RetrieverFactory> combinedResult, Action<Humidifier.QBusiness.RetrieverTypes.RetrieverConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction));
}
