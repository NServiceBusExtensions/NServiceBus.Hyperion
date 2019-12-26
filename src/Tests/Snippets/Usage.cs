using NServiceBus;
using NServiceBus.Hyperion;
using Hyperion;

class Usage
{
    Usage(EndpointConfiguration configuration)
    {
        #region HyperionSerialization

        configuration.UseSerialization<HyperionSerializer>();

        #endregion
    }

    void CustomSettings(EndpointConfiguration configuration)
    {
        #region HyperionCustomSettings

        var options = new SerializerOptions(
            preserveObjectReferences: true);
        var serialization = configuration.UseSerialization<HyperionSerializer>();
        serialization.Options(options);

        #endregion
    }

    void ContentTypeKey(EndpointConfiguration configuration)
    {
        #region HyperionContentTypeKey

        var serialization = configuration.UseSerialization<HyperionSerializer>();
        serialization.ContentTypeKey("custom-key");

        #endregion
    }
}