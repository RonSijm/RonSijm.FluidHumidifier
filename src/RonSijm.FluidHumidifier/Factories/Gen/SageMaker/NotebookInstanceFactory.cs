// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class NotebookInstanceFactory(string resourceName = null, Action<Humidifier.SageMaker.NotebookInstance> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.NotebookInstance>(resourceName)
{

    internal InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory InstanceMetadataServiceConfigurationFactory { get; set; }

    protected override Humidifier.SageMaker.NotebookInstance Create()
    {
        var notebookInstanceResult = CreateNotebookInstance();
        factoryAction?.Invoke(notebookInstanceResult);

        return notebookInstanceResult;
    }

    private Humidifier.SageMaker.NotebookInstance CreateNotebookInstance()
    {
        var notebookInstanceResult = new Humidifier.SageMaker.NotebookInstance
        {
            GivenName = InputResourceName,
        };

        return notebookInstanceResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.NotebookInstance result)
    {
        base.CreateChildren(result);

        result.InstanceMetadataServiceConfiguration ??= InstanceMetadataServiceConfigurationFactory?.Build();
    }

} // End Of Class

public static class NotebookInstanceFactoryExtensions
{
    public static CombinedResult<NotebookInstanceFactory, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration(this NotebookInstanceFactory parentFactory, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null)
    {
        parentFactory.InstanceMetadataServiceConfigurationFactory = new InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InstanceMetadataServiceConfigurationFactory);
    }

    public static CombinedResult<NotebookInstanceFactory, T1, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1>(this CombinedResult<NotebookInstanceFactory, T1> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NotebookInstanceFactory, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1>(this CombinedResult<T1, NotebookInstanceFactory> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NotebookInstanceFactory, T1, T2, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1, T2>(this CombinedResult<NotebookInstanceFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NotebookInstanceFactory, T2, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1, T2>(this CombinedResult<T1, NotebookInstanceFactory, T2> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NotebookInstanceFactory, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1, T2>(this CombinedResult<T1, T2, NotebookInstanceFactory> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NotebookInstanceFactory, T1, T2, T3, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1, T2, T3>(this CombinedResult<NotebookInstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NotebookInstanceFactory, T2, T3, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1, T2, T3>(this CombinedResult<T1, NotebookInstanceFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NotebookInstanceFactory, T3, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, NotebookInstanceFactory, T3> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NotebookInstanceFactory, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, NotebookInstanceFactory> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NotebookInstanceFactory, T1, T2, T3, T4, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1, T2, T3, T4>(this CombinedResult<NotebookInstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NotebookInstanceFactory, T2, T3, T4, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, NotebookInstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NotebookInstanceFactory, T3, T4, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, NotebookInstanceFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NotebookInstanceFactory, T4, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NotebookInstanceFactory, T4> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NotebookInstanceFactory, InnerNotebookInstanceInstanceMetadataServiceConfigurationFactory> WithInstanceMetadataServiceConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NotebookInstanceFactory> combinedResult, Action<Humidifier.SageMaker.NotebookInstanceTypes.InstanceMetadataServiceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInstanceMetadataServiceConfiguration(combinedResult.T5, subFactoryAction));
}
