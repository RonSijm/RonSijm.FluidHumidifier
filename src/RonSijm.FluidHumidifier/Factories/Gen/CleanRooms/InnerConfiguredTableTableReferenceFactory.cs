// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CleanRooms;

public class InnerConfiguredTableTableReferenceFactory(Action<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference> factoryAction = null) : SubResourceFactory<Humidifier.CleanRooms.ConfiguredTableTypes.TableReference>
{

    internal InnerConfiguredTableGlueTableReferenceFactory GlueFactory { get; set; }

    protected override Humidifier.CleanRooms.ConfiguredTableTypes.TableReference Create()
    {
        var tableReferenceResult = CreateTableReference();
        factoryAction?.Invoke(tableReferenceResult);

        return tableReferenceResult;
    }

    private Humidifier.CleanRooms.ConfiguredTableTypes.TableReference CreateTableReference()
    {
        var tableReferenceResult = new Humidifier.CleanRooms.ConfiguredTableTypes.TableReference();

        return tableReferenceResult;
    }
    public override void CreateChildren(Humidifier.CleanRooms.ConfiguredTableTypes.TableReference result)
    {
        base.CreateChildren(result);

        result.Glue ??= GlueFactory?.Build();
    }

} // End Of Class

public static class InnerConfiguredTableTableReferenceFactoryExtensions
{
    public static CombinedResult<InnerConfiguredTableTableReferenceFactory, InnerConfiguredTableGlueTableReferenceFactory> WithGlue(this InnerConfiguredTableTableReferenceFactory parentFactory, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null)
    {
        parentFactory.GlueFactory = new InnerConfiguredTableGlueTableReferenceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GlueFactory);
    }

    public static CombinedResult<InnerConfiguredTableTableReferenceFactory, T1, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1>(this CombinedResult<InnerConfiguredTableTableReferenceFactory, T1> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableTableReferenceFactory, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1>(this CombinedResult<T1, InnerConfiguredTableTableReferenceFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableTableReferenceFactory, T1, T2, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1, T2>(this CombinedResult<InnerConfiguredTableTableReferenceFactory, T1, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableTableReferenceFactory, T2, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1, T2>(this CombinedResult<T1, InnerConfiguredTableTableReferenceFactory, T2> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableTableReferenceFactory, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1, T2>(this CombinedResult<T1, T2, InnerConfiguredTableTableReferenceFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableTableReferenceFactory, T1, T2, T3, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1, T2, T3>(this CombinedResult<InnerConfiguredTableTableReferenceFactory, T1, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableTableReferenceFactory, T2, T3, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1, T2, T3>(this CombinedResult<T1, InnerConfiguredTableTableReferenceFactory, T2, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableTableReferenceFactory, T3, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1, T2, T3>(this CombinedResult<T1, T2, InnerConfiguredTableTableReferenceFactory, T3> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableTableReferenceFactory, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerConfiguredTableTableReferenceFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerConfiguredTableTableReferenceFactory, T1, T2, T3, T4, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1, T2, T3, T4>(this CombinedResult<InnerConfiguredTableTableReferenceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerConfiguredTableTableReferenceFactory, T2, T3, T4, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1, T2, T3, T4>(this CombinedResult<T1, InnerConfiguredTableTableReferenceFactory, T2, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerConfiguredTableTableReferenceFactory, T3, T4, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerConfiguredTableTableReferenceFactory, T3, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerConfiguredTableTableReferenceFactory, T4, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerConfiguredTableTableReferenceFactory, T4> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerConfiguredTableTableReferenceFactory, InnerConfiguredTableGlueTableReferenceFactory> WithGlue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerConfiguredTableTableReferenceFactory> combinedResult, Action<Humidifier.CleanRooms.ConfiguredTableTypes.GlueTableReference> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlue(combinedResult.T5, subFactoryAction));
}
