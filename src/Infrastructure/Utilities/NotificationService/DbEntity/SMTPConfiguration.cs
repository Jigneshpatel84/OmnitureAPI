﻿using iSocietyCare.Db;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iSocietyCare.NotificationService.DbEntity
{
    public class SMTPConfiguration : BaseEntity
    {
        [Key]
        public int SMTPConfigurationId { get; set; }
        public string SMTPserver { get; set; }
        public string MailHost { get; set; }
        public int MailPort { get; set; }
        public string MailFrom { get; set; }
        //public string SenderName { get; set; }
        public string Password { get; set; }
        //public string SenderContactNumber { get; set; }
        //public bool IsDefault { get; set; }
        public string DefaultCC { get; set; }
        public string DefaultBCC { get; set; }
    }
}
