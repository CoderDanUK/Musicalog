﻿using System;
using System.Runtime.Serialization;

namespace Musicalog.API.Models
{
    [DataContract]
    public class AlbumListItemModel
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Artist { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public int Stock { get; set; }
    }
}
