﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [Table("configuration")]
    public class Configuration
    {
        [Key()]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("backupType")]
        public string BackupTime { get; set; }

        [Column("cron")]
        public string Cron { get; set; }

        [Column("RepeatableBackup")]
        public bool RepeatableBackup { get; set; }

        [Column("savedBackupNumber")]
        public int SavedBackupNumber { get; set; }
    }
}