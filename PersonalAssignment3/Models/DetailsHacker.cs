using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HackingData.Models
{
    public class HackData
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime PowerAcquisitionDate { get; set; }
        public string Address { get; set; }
        public string BirthYear { get; set; }
        public string Type { get; set; }
        public bool Ethics { get; set; }
    }
}