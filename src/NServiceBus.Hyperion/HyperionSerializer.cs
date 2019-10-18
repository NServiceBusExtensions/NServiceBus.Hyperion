namespace NServiceBus.Hyperion
{
    using System;
    using MessageInterfaces;
    using Serialization;
    using Settings;

    /// <summary>
    /// Defines the capabilities of the Hyperion serializer
    /// </summary>
    public class HyperionSerializer :
        SerializationDefinition
    {
        /// <summary>
        /// <see cref="SerializationDefinition.Configure"/>
        /// </summary>
        public override Func<IMessageMapper, IMessageSerializer> Configure(ReadOnlySettings settings)
        {
            Guard.AgainstNull(settings, nameof(settings));
            return mapper =>
            {
                var options = settings.GetOptions();
                var contentTypeKey = settings.GetContentTypeKey();
                return new HyperionMessageSerializer(contentTypeKey, options);
            };
        }
    }
}