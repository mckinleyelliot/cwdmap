using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace cwdmap.Models
{
    public class Processor
    {
        [Key]
        public int ProcessorId {get;set;}

        [Required(ErrorMessage="Please list an address for your Processor")]
        public string ProcessorAddress {get; set;}

        [Required(ErrorMessage="Please list Processor Business Name")]
        [Display(Name="ProcessorName: ")]
        public string ProcessorName {get; set;}

        [Required(ErrorMessage="Please include Processor Hours")]
        public string ProcessorHours {get; set;}

        [Required(ErrorMessage="Please include County")]
        public string ProcessorCounty {get; set;}

        [Required(ErrorMessage="Please include City")]
        public string ProcessorCity {get; set;}

        [Required(ErrorMessage="Please list LAT for your Processor")]
        public string LAT {get; set;}

        [Required(ErrorMessage="Please list LONG for your Processor")]
        public string LNG {get; set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}