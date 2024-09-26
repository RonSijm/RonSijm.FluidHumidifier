// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackage;

public class InnerOriginEndpointDashPackageFactory(Action<Humidifier.MediaPackage.OriginEndpointTypes.DashPackage> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackage.OriginEndpointTypes.DashPackage>
{

    internal InnerOriginEndpointStreamSelectionFactory StreamSelectionFactory { get; set; }

    internal InnerOriginEndpointDashEncryptionFactory EncryptionFactory { get; set; }

    protected override Humidifier.MediaPackage.OriginEndpointTypes.DashPackage Create()
    {
        var dashPackageResult = CreateDashPackage();
        factoryAction?.Invoke(dashPackageResult);

        return dashPackageResult;
    }

    private Humidifier.MediaPackage.OriginEndpointTypes.DashPackage CreateDashPackage()
    {
        var dashPackageResult = new Humidifier.MediaPackage.OriginEndpointTypes.DashPackage();

        return dashPackageResult;
    }
    public override void CreateChildren(Humidifier.MediaPackage.OriginEndpointTypes.DashPackage result)
    {
        base.CreateChildren(result);

        result.StreamSelection ??= StreamSelectionFactory?.Build();
        result.Encryption ??= EncryptionFactory?.Build();
    }

} // End Of Class

public static class InnerOriginEndpointDashPackageFactoryExtensions
{
    public static CombinedResult<InnerOriginEndpointDashPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection(this InnerOriginEndpointDashPackageFactory parentFactory, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null)
    {
        parentFactory.StreamSelectionFactory = new InnerOriginEndpointStreamSelectionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StreamSelectionFactory);
    }

    public static CombinedResult<InnerOriginEndpointDashPackageFactory, InnerOriginEndpointDashEncryptionFactory> WithEncryption(this InnerOriginEndpointDashPackageFactory parentFactory, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null)
    {
        parentFactory.EncryptionFactory = new InnerOriginEndpointDashEncryptionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EncryptionFactory);
    }

    public static CombinedResult<InnerOriginEndpointDashPackageFactory, T1, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1>(this CombinedResult<InnerOriginEndpointDashPackageFactory, T1> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointDashPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1>(this CombinedResult<T1, InnerOriginEndpointDashPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointDashPackageFactory, T1, T2, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2>(this CombinedResult<InnerOriginEndpointDashPackageFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointDashPackageFactory, T2, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2>(this CombinedResult<T1, InnerOriginEndpointDashPackageFactory, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointDashPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointDashPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointDashPackageFactory, T1, T2, T3, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<InnerOriginEndpointDashPackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointDashPackageFactory, T2, T3, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointDashPackageFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointDashPackageFactory, T3, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointDashPackageFactory, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointDashPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointDashPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointDashPackageFactory, T1, T2, T3, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointDashPackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointDashPackageFactory, T2, T3, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointDashPackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointDashPackageFactory, T3, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointDashPackageFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointDashPackageFactory, T4, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointDashPackageFactory, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointDashPackageFactory, InnerOriginEndpointStreamSelectionFactory> WithStreamSelection<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointDashPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.StreamSelection> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamSelection(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointDashPackageFactory, T1, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1>(this CombinedResult<InnerOriginEndpointDashPackageFactory, T1> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointDashPackageFactory, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1>(this CombinedResult<T1, InnerOriginEndpointDashPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointDashPackageFactory, T1, T2, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<InnerOriginEndpointDashPackageFactory, T1, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointDashPackageFactory, T2, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, InnerOriginEndpointDashPackageFactory, T2> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointDashPackageFactory, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1, T2>(this CombinedResult<T1, T2, InnerOriginEndpointDashPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointDashPackageFactory, T1, T2, T3, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<InnerOriginEndpointDashPackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointDashPackageFactory, T2, T3, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, InnerOriginEndpointDashPackageFactory, T2, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointDashPackageFactory, T3, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, InnerOriginEndpointDashPackageFactory, T3> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointDashPackageFactory, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerOriginEndpointDashPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerOriginEndpointDashPackageFactory, T1, T2, T3, T4, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<InnerOriginEndpointDashPackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerOriginEndpointDashPackageFactory, T2, T3, T4, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, InnerOriginEndpointDashPackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerOriginEndpointDashPackageFactory, T3, T4, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerOriginEndpointDashPackageFactory, T3, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerOriginEndpointDashPackageFactory, T4, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerOriginEndpointDashPackageFactory, T4> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerOriginEndpointDashPackageFactory, InnerOriginEndpointDashEncryptionFactory> WithEncryption<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerOriginEndpointDashPackageFactory> combinedResult, Action<Humidifier.MediaPackage.OriginEndpointTypes.DashEncryption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEncryption(combinedResult.T5, subFactoryAction));
}
