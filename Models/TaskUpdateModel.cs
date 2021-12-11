﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TaskManagementSystem.Entity;

namespace TaskManagementSystem.Models
{
    public class TaskUpdateModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required."), DisplayName("Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required."),
         MinLength(6, ErrorMessage = "Description can't be shorter than 6 characters."),
         DisplayName("Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Start date is required."), DataType(DataType.Date),
         DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "End date is required."), DataType(DataType.Date),
         DisplayName("End Date")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Progress status is required."), DefaultValue(false), DisplayName("Is Completed")]
        public bool IsCompleted { get; set; }
        [Required(ErrorMessage = "Public status is required."), DisplayName("Is Public")]
        public bool IsPublic { get; set; }
        [Required(ErrorMessage = "Worker is required."), DisplayName("Worker")]
        public int WorkerId { get; set; }
    }
}