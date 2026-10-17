// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class FpgaImageFactory(string resourceName = null, Action<Humidifier.EC2.FpgaImage> factoryAction = null) : ResourceFactory<Humidifier.EC2.FpgaImage>(resourceName)
{

    internal InnerFpgaImageStorageLocationFactory LogsStorageLocationFactory { get; set; }

    internal InnerFpgaImageStorageLocationFactory InputStorageLocationFactory { get; set; }

    protected override Humidifier.EC2.FpgaImage Create()
    {
        var fpgaImageResult = CreateFpgaImage();
        factoryAction?.Invoke(fpgaImageResult);

        return fpgaImageResult;
    }

    private Humidifier.EC2.FpgaImage CreateFpgaImage()
    {
        var fpgaImageResult = new Humidifier.EC2.FpgaImage
        {
            GivenName = InputResourceName,
        };

        return fpgaImageResult;
    }
    public override void CreateChildren(Humidifier.EC2.FpgaImage result)
    {
        base.CreateChildren(result);

        result.LogsStorageLocation ??= LogsStorageLocationFactory?.Build();
        result.InputStorageLocation ??= InputStorageLocationFactory?.Build();
    }

} // End Of Class

public static class FpgaImageFactoryExtensions
{
    public static CombinedResult<FpgaImageFactory, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation(this FpgaImageFactory parentFactory, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null)
    {
        parentFactory.LogsStorageLocationFactory = new InnerFpgaImageStorageLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LogsStorageLocationFactory);
    }

    public static CombinedResult<FpgaImageFactory, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation(this FpgaImageFactory parentFactory, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null)
    {
        parentFactory.InputStorageLocationFactory = new InnerFpgaImageStorageLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InputStorageLocationFactory);
    }

    public static CombinedResult<FpgaImageFactory, T1, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1>(this CombinedResult<FpgaImageFactory, T1> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FpgaImageFactory, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1>(this CombinedResult<T1, FpgaImageFactory> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<FpgaImageFactory, T1, T2, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1, T2>(this CombinedResult<FpgaImageFactory, T1, T2> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FpgaImageFactory, T2, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1, T2>(this CombinedResult<T1, FpgaImageFactory, T2> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FpgaImageFactory, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1, T2>(this CombinedResult<T1, T2, FpgaImageFactory> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<FpgaImageFactory, T1, T2, T3, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1, T2, T3>(this CombinedResult<FpgaImageFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FpgaImageFactory, T2, T3, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1, T2, T3>(this CombinedResult<T1, FpgaImageFactory, T2, T3> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FpgaImageFactory, T3, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1, T2, T3>(this CombinedResult<T1, T2, FpgaImageFactory, T3> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FpgaImageFactory, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, FpgaImageFactory> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<FpgaImageFactory, T1, T2, T3, T4, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1, T2, T3, T4>(this CombinedResult<FpgaImageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FpgaImageFactory, T2, T3, T4, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, FpgaImageFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FpgaImageFactory, T3, T4, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, FpgaImageFactory, T3, T4> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FpgaImageFactory, T4, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FpgaImageFactory, T4> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, FpgaImageFactory, InnerFpgaImageStorageLocationFactory> WithLogsStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FpgaImageFactory> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogsStorageLocation(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<FpgaImageFactory, T1, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1>(this CombinedResult<FpgaImageFactory, T1> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FpgaImageFactory, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1>(this CombinedResult<T1, FpgaImageFactory> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<FpgaImageFactory, T1, T2, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1, T2>(this CombinedResult<FpgaImageFactory, T1, T2> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FpgaImageFactory, T2, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1, T2>(this CombinedResult<T1, FpgaImageFactory, T2> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FpgaImageFactory, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1, T2>(this CombinedResult<T1, T2, FpgaImageFactory> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<FpgaImageFactory, T1, T2, T3, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1, T2, T3>(this CombinedResult<FpgaImageFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FpgaImageFactory, T2, T3, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1, T2, T3>(this CombinedResult<T1, FpgaImageFactory, T2, T3> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FpgaImageFactory, T3, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1, T2, T3>(this CombinedResult<T1, T2, FpgaImageFactory, T3> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FpgaImageFactory, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, FpgaImageFactory> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<FpgaImageFactory, T1, T2, T3, T4, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1, T2, T3, T4>(this CombinedResult<FpgaImageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, FpgaImageFactory, T2, T3, T4, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, FpgaImageFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, FpgaImageFactory, T3, T4, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, FpgaImageFactory, T3, T4> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, FpgaImageFactory, T4, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FpgaImageFactory, T4> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, FpgaImageFactory, InnerFpgaImageStorageLocationFactory> WithInputStorageLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FpgaImageFactory> combinedResult, Action<Humidifier.EC2.FpgaImageTypes.StorageLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInputStorageLocation(combinedResult.T5, subFactoryAction).T2);
}
