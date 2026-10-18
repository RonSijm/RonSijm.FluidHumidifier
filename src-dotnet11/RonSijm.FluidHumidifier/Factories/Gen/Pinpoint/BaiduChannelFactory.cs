// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class BaiduChannelFactory(string resourceName = null, Action<Humidifier.Pinpoint.BaiduChannel> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.BaiduChannel>(resourceName)
{

    protected override Humidifier.Pinpoint.BaiduChannel Create()
    {
        var baiduChannelResult = CreateBaiduChannel();
        factoryAction?.Invoke(baiduChannelResult);

        return baiduChannelResult;
    }

    private Humidifier.Pinpoint.BaiduChannel CreateBaiduChannel()
    {
        var baiduChannelResult = new Humidifier.Pinpoint.BaiduChannel
        {
            GivenName = InputResourceName,
        };

        return baiduChannelResult;
    }

} // End Of Class

public static class BaiduChannelFactoryExtensions
{
}
