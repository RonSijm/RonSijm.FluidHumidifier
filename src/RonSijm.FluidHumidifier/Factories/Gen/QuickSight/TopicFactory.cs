// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class TopicFactory(string resourceName = null, Action<Humidifier.QuickSight.Topic> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.Topic>(resourceName)
{

    internal List<InnerTopicDatasetMetadataFactory> DataSetsFactories { get; set; } = [];

    internal InnerTopicCustomInstructionsFactory CustomInstructionsFactory { get; set; }

    internal InnerTopicTopicConfigOptionsFactory ConfigOptionsFactory { get; set; }

    protected override Humidifier.QuickSight.Topic Create()
    {
        var topicResult = CreateTopic();
        factoryAction?.Invoke(topicResult);

        return topicResult;
    }

    private Humidifier.QuickSight.Topic CreateTopic()
    {
        var topicResult = new Humidifier.QuickSight.Topic
        {
            GivenName = InputResourceName,
        };

        return topicResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.Topic result)
    {
        base.CreateChildren(result);

        result.DataSets = DataSetsFactories.Any() ? DataSetsFactories.Select(x => x.Build()).ToList() : null;
        result.CustomInstructions ??= CustomInstructionsFactory?.Build();
        result.ConfigOptions ??= ConfigOptionsFactory?.Build();
    }

} // End Of Class

public static class TopicFactoryExtensions
{
    public static CombinedResult<TopicFactory, InnerTopicDatasetMetadataFactory> WithDataSets(this TopicFactory parentFactory, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null)
    {
        var factory = new InnerTopicDatasetMetadataFactory(subFactoryAction);
        parentFactory.DataSetsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TopicFactory, InnerTopicCustomInstructionsFactory> WithCustomInstructions(this TopicFactory parentFactory, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null)
    {
        parentFactory.CustomInstructionsFactory = new InnerTopicCustomInstructionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CustomInstructionsFactory);
    }

    public static CombinedResult<TopicFactory, InnerTopicTopicConfigOptionsFactory> WithConfigOptions(this TopicFactory parentFactory, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null)
    {
        parentFactory.ConfigOptionsFactory = new InnerTopicTopicConfigOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigOptionsFactory);
    }

    public static CombinedResult<TopicFactory, T1, InnerTopicDatasetMetadataFactory> WithDataSets<T1>(this CombinedResult<TopicFactory, T1> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TopicFactory, InnerTopicDatasetMetadataFactory> WithDataSets<T1>(this CombinedResult<T1, TopicFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataSets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TopicFactory, T1, T2, InnerTopicDatasetMetadataFactory> WithDataSets<T1, T2>(this CombinedResult<TopicFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TopicFactory, T2, InnerTopicDatasetMetadataFactory> WithDataSets<T1, T2>(this CombinedResult<T1, TopicFactory, T2> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TopicFactory, InnerTopicDatasetMetadataFactory> WithDataSets<T1, T2>(this CombinedResult<T1, T2, TopicFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataSets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TopicFactory, T1, T2, T3, InnerTopicDatasetMetadataFactory> WithDataSets<T1, T2, T3>(this CombinedResult<TopicFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TopicFactory, T2, T3, InnerTopicDatasetMetadataFactory> WithDataSets<T1, T2, T3>(this CombinedResult<T1, TopicFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TopicFactory, T3, InnerTopicDatasetMetadataFactory> WithDataSets<T1, T2, T3>(this CombinedResult<T1, T2, TopicFactory, T3> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TopicFactory, InnerTopicDatasetMetadataFactory> WithDataSets<T1, T2, T3>(this CombinedResult<T1, T2, T3, TopicFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataSets(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TopicFactory, T1, T2, T3, T4, InnerTopicDatasetMetadataFactory> WithDataSets<T1, T2, T3, T4>(this CombinedResult<TopicFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSets(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TopicFactory, T2, T3, T4, InnerTopicDatasetMetadataFactory> WithDataSets<T1, T2, T3, T4>(this CombinedResult<T1, TopicFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSets(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TopicFactory, T3, T4, InnerTopicDatasetMetadataFactory> WithDataSets<T1, T2, T3, T4>(this CombinedResult<T1, T2, TopicFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSets(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TopicFactory, T4, InnerTopicDatasetMetadataFactory> WithDataSets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TopicFactory, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSets(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TopicFactory, InnerTopicDatasetMetadataFactory> WithDataSets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TopicFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.DatasetMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataSets(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<TopicFactory, T1, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1>(this CombinedResult<TopicFactory, T1> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomInstructions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TopicFactory, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1>(this CombinedResult<T1, TopicFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, WithCustomInstructions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TopicFactory, T1, T2, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1, T2>(this CombinedResult<TopicFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomInstructions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TopicFactory, T2, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1, T2>(this CombinedResult<T1, TopicFactory, T2> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomInstructions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TopicFactory, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1, T2>(this CombinedResult<T1, T2, TopicFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCustomInstructions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TopicFactory, T1, T2, T3, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1, T2, T3>(this CombinedResult<TopicFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomInstructions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TopicFactory, T2, T3, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1, T2, T3>(this CombinedResult<T1, TopicFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomInstructions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TopicFactory, T3, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1, T2, T3>(this CombinedResult<T1, T2, TopicFactory, T3> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomInstructions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TopicFactory, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1, T2, T3>(this CombinedResult<T1, T2, T3, TopicFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCustomInstructions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TopicFactory, T1, T2, T3, T4, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1, T2, T3, T4>(this CombinedResult<TopicFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomInstructions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TopicFactory, T2, T3, T4, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1, T2, T3, T4>(this CombinedResult<T1, TopicFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomInstructions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TopicFactory, T3, T4, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1, T2, T3, T4>(this CombinedResult<T1, T2, TopicFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomInstructions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TopicFactory, T4, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TopicFactory, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomInstructions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TopicFactory, InnerTopicCustomInstructionsFactory> WithCustomInstructions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TopicFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.CustomInstructions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCustomInstructions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<TopicFactory, T1, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1>(this CombinedResult<TopicFactory, T1> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TopicFactory, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1>(this CombinedResult<T1, TopicFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TopicFactory, T1, T2, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1, T2>(this CombinedResult<TopicFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TopicFactory, T2, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1, T2>(this CombinedResult<T1, TopicFactory, T2> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TopicFactory, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1, T2>(this CombinedResult<T1, T2, TopicFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TopicFactory, T1, T2, T3, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1, T2, T3>(this CombinedResult<TopicFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TopicFactory, T2, T3, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1, T2, T3>(this CombinedResult<T1, TopicFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TopicFactory, T3, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1, T2, T3>(this CombinedResult<T1, T2, TopicFactory, T3> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TopicFactory, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, TopicFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TopicFactory, T1, T2, T3, T4, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1, T2, T3, T4>(this CombinedResult<TopicFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigOptions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TopicFactory, T2, T3, T4, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1, T2, T3, T4>(this CombinedResult<T1, TopicFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigOptions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TopicFactory, T3, T4, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, TopicFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigOptions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TopicFactory, T4, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TopicFactory, T4> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigOptions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TopicFactory, InnerTopicTopicConfigOptionsFactory> WithConfigOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TopicFactory> combinedResult, Action<Humidifier.QuickSight.TopicTypes.TopicConfigOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigOptions(combinedResult.T5, subFactoryAction).T2);
}
