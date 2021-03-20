using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models
{
    public enum Question
    {
        Earth, Computer
    }
    public class AnswerImage
    {


        public int AnswerImageId { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        [Url]
        public string Url { get; set; }

        [Required]
        public Question Question { get; set; }
      
        }

    }

 

