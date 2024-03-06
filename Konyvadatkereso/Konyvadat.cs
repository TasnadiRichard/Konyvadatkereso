﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Konyvadatkereso;
//
//    var konyvadat = Konyvadat.FromJson(jsonString);

namespace Konyvadatkereso
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Konyvadat
    {
        [JsonProperty("bib_key")]
        public string BibKey { get; set; }

        [JsonProperty("info_url")]
        public Uri InfoUrl { get; set; }

        [JsonProperty("preview")]
        public string Preview { get; set; }

        [JsonProperty("preview_url")]
        public Uri PreviewUrl { get; set; }

        [JsonProperty("thumbnail_url")]
        public Uri ThumbnailUrl { get; set; }
    }

    public partial class Konyvadat
    {
        public static Dictionary<string, Konyvadat> FromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, Konyvadat>>(json, Konyvadatkereso.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Dictionary<string, Konyvadat> self) => JsonConvert.SerializeObject(self, Konyvadatkereso.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
