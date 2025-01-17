﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskManagementSystem.Models
{
    public class WorkerTaskUpdateModel
    {
        public int Id { get; set; }
        [Required, DisplayName("Is Completed")]
        public bool IsCompleted { get; set; }
    }
}