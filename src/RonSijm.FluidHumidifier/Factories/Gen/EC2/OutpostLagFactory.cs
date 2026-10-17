// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class OutpostLagFactory(string resourceName = null, Action<Humidifier.EC2.OutpostLag> factoryAction = null) : ResourceFactory<Humidifier.EC2.OutpostLag>(resourceName)
{

    protected override Humidifier.EC2.OutpostLag Create()
    {
        var outpostLagResult = CreateOutpostLag();
        factoryAction?.Invoke(outpostLagResult);

        return outpostLagResult;
    }

    private Humidifier.EC2.OutpostLag CreateOutpostLag()
    {
        var outpostLagResult = new Humidifier.EC2.OutpostLag
        {
            GivenName = InputResourceName,
        };

        return outpostLagResult;
    }

} // End Of Class

public static class OutpostLagFactoryExtensions
{
}
