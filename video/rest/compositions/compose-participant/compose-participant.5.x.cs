// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Video.V1;
using static Twilio.Rest.Video.V1.CompositionResource;

class Program
{
    static void Main(string[] args)
    {
        // Find your API Key SID and Secret at twilio.com/console
        const string apiKeySid = "SKXXXX";
        const string apiKeySecret = "your_api_key_secret";

        TwilioClient.Init(apiKeySid, apiKeySecret);

        var layout = new
        {
            single = new
            {
                video_sources = new string[]{"PAXXXX"}
            }
        };

        var composition = CompositionResource.Create(
          roomSid: "RMXXXX",
          audioSources: new List<string>{"PAXXXX"},
          videoLayout: layout,
          statusCallback: new Uri('http://my.server.org/callbacks'),
          format: FormatEnum.Mp4
        );

        Console.WriteLine($"Created composition with SID: {composition.Sid}");
    }
}
