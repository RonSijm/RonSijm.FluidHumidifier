// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerOriginEndpointCmafPackageFactory(Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafPackage> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.OriginEndpointTypes.CmafPackage>
{

    internal InnerOriginEndpointStreamSelectionFactory StreamSelectionFactory { get; set; }

    internal InnerOriginEndpointCmafEncryptionFactory EncryptionFactory { get; set; }

    protected override Humidifier.MediaPackage.OriginEndpointTypes.CmafPackage Create()
    {
        var cmafPackageResult = CreateCmafPackage();
        factoryAction?.Invoke(cmafPackageResult);

        return cmafPackageResult;
    }

    private Humidifier.MediaPackage.OriginEndpointTypes.CmafPackage CreateCmafPackage()
    {
        var cmafPackageResult = new Humidifier.MediaPackage.OriginEndpointTypes.CmafPackage();

        return cmafPackageResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.OriginEndpointTypes.CmafPackage result)
    {
        base.CreateChildren(result);

        result.StreamSelection ??= StreamSelectionFactory?.Build();
        result.Encryption ??= EncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointCmafPackageFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointCmafPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection(this InnerOriginEndpointCmafPackageFactory parentFactory, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null)
    {
        parentFactory.StreamSelectionFactory = new InnerOriginEndpointStreamSelectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StreamSelectionFactory);
    }

    public static CombinedResult<InnerOriginEndpointCmafPackageFactory, InnerOriginEndpointCmafEncryptionFactory> WithEncryption(this InnerOriginEndpointCmafPackageFactory parentFactory, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null)
    {
        parentFactory.EncryptionFactory = new InnerOriginEndpointCmafEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionFactory);
    }

    public static CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1>(this CombinedResult<InnerOriginEndpointCmafPackageFactory, T1> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1>(this CombinedResult<T1, InnerOriginEndpointCmafPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, T2, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2>(this CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, T2, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2>(this CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointCmafPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointCmafPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, T2, T3, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, T2, T3, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointCmafPackageFactory, T3, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointCmafPackageFactory, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointCmafPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointCmafPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, T2, T3, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, T2, T3, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointCmafPackageFactory, T3, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointCmafPackageFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointCmafPackageFactory, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointCmafPackageFactory, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointCmafPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointCmafPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1>(this CombinedResult<InnerOriginEndpointCmafPackageFactory, T1> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1>(this CombinedResult<T1, InnerOriginEndpointCmafPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, T2, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, T2, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointCmafPackageFactory, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointCmafPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, T2, T3, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, T2, T3, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointCmafPackageFactory, T3, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointCmafPackageFactory, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointCmafPackageFactory, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointCmafPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, T2, T3, T4, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointCmafPackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, T2, T3, T4, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointCmafPackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointCmafPackageFactory, T3, T4, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointCmafPackageFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointCmafPackageFactory, T4, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointCmafPackageFactory, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointCmafPackageFactory, InnerOriginEndpointCmafEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointCmafPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.CmafEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T5, subFactoryAction));
}
