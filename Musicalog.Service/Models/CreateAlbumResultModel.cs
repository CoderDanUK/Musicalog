﻿using System.Runtime.Serialization;

namespace Musicalog.Service.Models
{
    [DataContract]
    public class CreateAlbumResultModel
    {
        [DataMember]
        public bool Success { get; set; }
        [DataMember]
        public string[] Errors { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
}