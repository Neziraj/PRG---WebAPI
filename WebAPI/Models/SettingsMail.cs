﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [Table("settingsMail")]
    public class SettingsMail
    {
        [Key()]
        public int IdSettings { get; set; }

        [Column("sendMail")]
        public bool SendMail { get; set; }

        [Column("cron")]
        public string Cron { get; set; }
    }
}