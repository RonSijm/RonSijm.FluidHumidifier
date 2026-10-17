// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class StreamFactory(string resourceName = null, Action<Humidifier.IoT.Stream> factoryAction = null) : ResourceFactory<Humidifier.IoT.Stream>(resourceName)
{

    internal List<InnerStreamStreamFileFactory> FilesFactories { get; set; } = [];

    protected override Humidifier.IoT.Stream Create()
    {
        var streamResult = CreateStream();
        factoryAction?.Invoke(streamResult);

        return streamResult;
    }

    private Humidifier.IoT.Stream CreateStream()
    {
        var streamResult = new Humidifier.IoT.Stream
        {
            GivenName = InputResourceName,
        };

        return streamResult;
    }
    public override void CreateChildren(Humidifier.IoT.Stream result)
    {
        base.CreateChildren(result);

        result.Files = FilesFactories.Any() ? FilesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class StreamFactoryExtensions
{
    public static CombinedResult<StreamFactory, InnerStreamStreamFileFactory> WithFiles(this StreamFactory parentFactory, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null)
    {
        var factory = new InnerStreamStreamFileFactory(subFactoryAction);
        parentFactory.FilesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<StreamFactory, T1, InnerStreamStreamFileFactory> WithFiles<T1>(this CombinedResult<StreamFactory, T1> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, WithFiles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, StreamFactory, InnerStreamStreamFileFactory> WithFiles<T1>(this CombinedResult<T1, StreamFactory> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, WithFiles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<StreamFactory, T1, T2, InnerStreamStreamFileFactory> WithFiles<T1, T2>(this CombinedResult<StreamFactory, T1, T2> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, StreamFactory, T2, InnerStreamStreamFileFactory> WithFiles<T1, T2>(this CombinedResult<T1, StreamFactory, T2> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, StreamFactory, InnerStreamStreamFileFactory> WithFiles<T1, T2>(this CombinedResult<T1, T2, StreamFactory> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<StreamFactory, T1, T2, T3, InnerStreamStreamFileFactory> WithFiles<T1, T2, T3>(this CombinedResult<StreamFactory, T1, T2, T3> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, StreamFactory, T2, T3, InnerStreamStreamFileFactory> WithFiles<T1, T2, T3>(this CombinedResult<T1, StreamFactory, T2, T3> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, StreamFactory, T3, InnerStreamStreamFileFactory> WithFiles<T1, T2, T3>(this CombinedResult<T1, T2, StreamFactory, T3> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, StreamFactory, InnerStreamStreamFileFactory> WithFiles<T1, T2, T3>(this CombinedResult<T1, T2, T3, StreamFactory> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<StreamFactory, T1, T2, T3, T4, InnerStreamStreamFileFactory> WithFiles<T1, T2, T3, T4>(this CombinedResult<StreamFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, StreamFactory, T2, T3, T4, InnerStreamStreamFileFactory> WithFiles<T1, T2, T3, T4>(this CombinedResult<T1, StreamFactory, T2, T3, T4> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, StreamFactory, T3, T4, InnerStreamStreamFileFactory> WithFiles<T1, T2, T3, T4>(this CombinedResult<T1, T2, StreamFactory, T3, T4> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, StreamFactory, T4, InnerStreamStreamFileFactory> WithFiles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StreamFactory, T4> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, StreamFactory, InnerStreamStreamFileFactory> WithFiles<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StreamFactory> combinedResult, Action<Humidifier.IoT.StreamTypes.StreamFile> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFiles(combinedResult.T5, subFactoryAction).T2);
}
