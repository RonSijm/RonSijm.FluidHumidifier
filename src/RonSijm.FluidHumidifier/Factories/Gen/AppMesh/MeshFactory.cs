// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class MeshFactory(string resourceName = null, Action<Humidifier.AppMesh.Mesh> factoryAction = null) : ResourceFactory<Humidifier.AppMesh.Mesh>(resourceName)
{

    internal InnerMeshMeshSpecFactory SpecFactory { get; set; }

    protected override Humidifier.AppMesh.Mesh Create()
    {
        var meshResult = CreateMesh();
        factoryAction?.Invoke(meshResult);

        return meshResult;
    }

    private Humidifier.AppMesh.Mesh CreateMesh()
    {
        var meshResult = new Humidifier.AppMesh.Mesh
        {
            GivenName = InputResourceName,
        };

        return meshResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.Mesh result)
    {
        base.CreateChildren(result);

        result.Spec ??= SpecFactory?.Build();
    }

} // End Of Class

public static class MeshFactoryExtensions
{
    public static CombinedResult<MeshFactory, InnerMeshMeshSpecFactory> WithSpec(this MeshFactory parentFactory, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null)
    {
        parentFactory.SpecFactory = new InnerMeshMeshSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpecFactory);
    }

    public static CombinedResult<MeshFactory, T1, InnerMeshMeshSpecFactory> WithSpec<T1>(this CombinedResult<MeshFactory, T1> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MeshFactory, InnerMeshMeshSpecFactory> WithSpec<T1>(this CombinedResult<T1, MeshFactory> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<MeshFactory, T1, T2, InnerMeshMeshSpecFactory> WithSpec<T1, T2>(this CombinedResult<MeshFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MeshFactory, T2, InnerMeshMeshSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, MeshFactory, T2> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MeshFactory, InnerMeshMeshSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, T2, MeshFactory> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<MeshFactory, T1, T2, T3, InnerMeshMeshSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<MeshFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MeshFactory, T2, T3, InnerMeshMeshSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, MeshFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MeshFactory, T3, InnerMeshMeshSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, MeshFactory, T3> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MeshFactory, InnerMeshMeshSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, MeshFactory> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<MeshFactory, T1, T2, T3, T4, InnerMeshMeshSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<MeshFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, MeshFactory, T2, T3, T4, InnerMeshMeshSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, MeshFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, MeshFactory, T3, T4, InnerMeshMeshSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, MeshFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, MeshFactory, T4, InnerMeshMeshSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MeshFactory, T4> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, MeshFactory, InnerMeshMeshSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MeshFactory> combinedResult, Action<Humidifier.AppMesh.MeshTypes.MeshSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T5, subFactoryAction));
}
