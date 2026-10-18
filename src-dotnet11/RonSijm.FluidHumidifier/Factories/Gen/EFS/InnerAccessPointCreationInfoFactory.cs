// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EFS;

public class InnerAccessPointCreationInfoFactory(Action<Humidifier.EFS.AccessPointTypes.CreationInfo> factoryAction = null) : SubResourceFactory<Humidifier.EFS.AccessPointTypes.CreationInfo>
{

    protected override Humidifier.EFS.AccessPointTypes.CreationInfo Create()
    {
        var creationInfoResult = CreateCreationInfo();
        factoryAction?.Invoke(creationInfoResult);

        return creationInfoResult;
    }

    private Humidifier.EFS.AccessPointTypes.CreationInfo CreateCreationInfo()
    {
        var creationInfoResult = new Humidifier.EFS.AccessPointTypes.CreationInfo();

        return creationInfoResult;
    }

} // End Of Class

public static class InnerAccessPointCreationInfoFactoryExtensions
{
}
