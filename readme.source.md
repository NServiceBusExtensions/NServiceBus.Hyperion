# <img src="/src/icon.png" height="30px"> NServiceBus.Hyperion

[![Build status](https://ci.appveyor.com/api/projects/status/20f8p78334a1utj4/branch/main?svg=true)](https://ci.appveyor.com/project/SimonCropp/nservicebus-Hyperion)
[![NuGet Status](https://img.shields.io/nuget/v/NServiceBus.Hyperion.svg)](https://www.nuget.org/packages/NServiceBus.Hyperion/)

Add support for [NServiceBus](https://particular.net/NServiceBus) message serialization via [Hyperion](https://github.com/akkadotnet/Hyperion) binary serializer.

<!--- StartOpenCollectiveBackers -->

[Already a Patron? skip past this section](#endofbacking)


## Community backed

**It is expected that all developers either [become a Patron](https://opencollective.com/nservicebusextensions/contribute/patron-6976) to use NServiceBusExtensions. [Go to licensing FAQ](https://github.com/NServiceBusExtensions/Home/#licensingpatron-faq)**


### Sponsors

Support this project by [becoming a Sponsor](https://opencollective.com/nservicebusextensions/contribute/sponsor-6972). The company avatar will show up here with a website link. The avatar will also be added to all GitHub repositories under the [NServiceBusExtensions organization](https://github.com/NServiceBusExtensions).


### Patrons

Thanks to all the backing developers. Support this project by [becoming a patron](https://opencollective.com/nservicebusextensions/contribute/patron-6976).

<img src="https://opencollective.com/nservicebusextensions/tiers/patron.svg?width=890&avatarHeight=60&button=false">

<a href="#" id="endofbacking"></a>

<!--- EndOpenCollectiveBackers -->



## Usage

snippet: HyperionSerialization

This serializer does not support [messages defined as interfaces](https://docs.particular.net/nservicebus/messaging/messages-as-interfaces). If an explicit interface is sent, an exception will be thrown with the following message:

```
Interface based message are not supported.
Create a class that implements the desired interface
```

Instead, use a public class with the same contract as the interface. The class can optionally implement any required interfaces.


### Custom Settings

Customizes the instance of `SerializerOptions` used for serialization.

snippet: HyperionCustomSettings


### Custom content key

When using [additional deserializers](https://docs.particular.net/nservicebus/serialization/#specifying-additional-deserializers) or transitioning between different versions of the same serializer it can be helpful to take explicit control over the content type a serializer passes to NServiceBus (to be used for the [ContentType header](https://docs.particular.net/nservicebus/messaging/headers#serialization-headers-nservicebus-contenttype)).

snippet: HyperionContentTypeKey


## Icon

[Beetle](https://thenounproject.com/term/beetle/861510) designed by [B Farias](https://thenounproject.com/bfarias/) from [The Noun Project](https://thenounproject.com).