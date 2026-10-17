// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerDirectoryStreamingPropertiesFactory(Action<Humidifier.WorkSpaces.DirectoryTypes.StreamingProperties> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.DirectoryTypes.StreamingProperties>
{

    internal InnerDirectoryGlobalAcceleratorForDirectoryFactory GlobalAcceleratorFactory { get; set; }

    protected override Humidifier.WorkSpaces.DirectoryTypes.StreamingProperties Create()
    {
        var streamingPropertiesResult = CreateStreamingProperties();
        factoryAction?.Invoke(streamingPropertiesResult);

        return streamingPropertiesResult;
    }

    private Humidifier.WorkSpaces.DirectoryTypes.StreamingProperties CreateStreamingProperties()
    {
        var streamingPropertiesResult = new Humidifier.WorkSpaces.DirectoryTypes.StreamingProperties();

        return streamingPropertiesResult;
    }
    public override void CreateChildren(Humidifier.WorkSpaces.DirectoryTypes.StreamingProperties result)
    {
        base.CreateChildren(result);

        result.GlobalAccelerator ??= GlobalAcceleratorFactory?.Build();
    }

} // End Of Class

public static class InnerDirectoryStreamingPropertiesFactoryExtensions
{
    public static CombinedResult<InnerDirectoryStreamingPropertiesFactory, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator(this InnerDirectoryStreamingPropertiesFactory parentFactory, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null)
    {
        parentFactory.GlobalAcceleratorFactory = new InnerDirectoryGlobalAcceleratorForDirectoryFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GlobalAcceleratorFactory);
    }

    public static CombinedResult<InnerDirectoryStreamingPropertiesFactory, T1, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1>(this CombinedResult<InnerDirectoryStreamingPropertiesFactory, T1> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDirectoryStreamingPropertiesFactory, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1>(this CombinedResult<T1, InnerDirectoryStreamingPropertiesFactory> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDirectoryStreamingPropertiesFactory, T1, T2, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1, T2>(this CombinedResult<InnerDirectoryStreamingPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDirectoryStreamingPropertiesFactory, T2, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1, T2>(this CombinedResult<T1, InnerDirectoryStreamingPropertiesFactory, T2> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDirectoryStreamingPropertiesFactory, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1, T2>(this CombinedResult<T1, T2, InnerDirectoryStreamingPropertiesFactory> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDirectoryStreamingPropertiesFactory, T1, T2, T3, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1, T2, T3>(this CombinedResult<InnerDirectoryStreamingPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDirectoryStreamingPropertiesFactory, T2, T3, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1, T2, T3>(this CombinedResult<T1, InnerDirectoryStreamingPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDirectoryStreamingPropertiesFactory, T3, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1, T2, T3>(this CombinedResult<T1, T2, InnerDirectoryStreamingPropertiesFactory, T3> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDirectoryStreamingPropertiesFactory, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDirectoryStreamingPropertiesFactory> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDirectoryStreamingPropertiesFactory, T1, T2, T3, T4, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1, T2, T3, T4>(this CombinedResult<InnerDirectoryStreamingPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDirectoryStreamingPropertiesFactory, T2, T3, T4, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1, T2, T3, T4>(this CombinedResult<T1, InnerDirectoryStreamingPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDirectoryStreamingPropertiesFactory, T3, T4, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDirectoryStreamingPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDirectoryStreamingPropertiesFactory, T4, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDirectoryStreamingPropertiesFactory, T4> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDirectoryStreamingPropertiesFactory, InnerDirectoryGlobalAcceleratorForDirectoryFactory> WithGlobalAccelerator<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDirectoryStreamingPropertiesFactory> combinedResult, Action<Humidifier.WorkSpaces.DirectoryTypes.GlobalAcceleratorForDirectory> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalAccelerator(combinedResult.T5, subFactoryAction).T2);
}
