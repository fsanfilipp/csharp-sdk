﻿using com.persephony.api;
using com.persephony.webhooks;
using Newtonsoft.Json;
using System;

namespace com.persephony.webhooks.application
{
    /// <summary>
    /// An ApplicationVoiceCallback represents the JSON object that is sent to the webhooks
    /// for incoming calls. URL specified in voiceUrl, voiceFallbackUrl of Application. 
    /// Currently no special properties beyond its' subclasses
    /// </summary>
    [JsonObject]
    public class ApplicationVoiceCallback: VoiceRequest
    {

        /// <summary>
        /// Helper method to build an ApplicationVoiceCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing an ApplicationVoiceCallback instance.</param>
        /// <returns>An ApplicationVoiceCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public new static ApplicationVoiceCallback fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<ApplicationVoiceCallback>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

    }
}
