﻿using Musicalog.Data;
using System;
using System.Runtime.Serialization;

namespace Musicalog.API.Models
{
    [DataContract]
    public class CreateAlbumModel
    {
        [DataMember]
        public Guid? Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Stock { get; set; }
        [DataMember]
        public AlbumType AlbumType { get; set; }
        [DataMember]
        public Guid ArtistId { get; set; }
    }
}
