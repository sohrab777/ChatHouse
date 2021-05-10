﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAM_Backend.ViewModels.ChatRoomHubViewModel
{
    public class MessageViewModel 
    {
        [Required]
        public ChatRoomHubUserViewModel UserModel { get; set; }
        [Required]
        public MessageType MessageType { get; set; }
        [Required]
        public Object Message { get; set; }
        public int RoomId{ get; set; }
        public bool IsMe { get; set; }
        public int ParentId { get; set; }
    }

    public enum MessageType
    {
        Text,
        File,
        JoinNotification,
        LeftNotification
    }
}
