﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TauriApiWrapper.Objects.Responses.Character;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public sealed class GuildPlayer : CharacterData
    {
        [JsonProperty("name")]
        public new string Name { get; set; }

        [JsonProperty("rank_name")]
        public string RankName { get; set; }
    }
}