namespace JAKHSOWebApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Task")]
    public partial class Task
    {
        public int TaskId { get; set; }

        [Required]
        [StringLength(150)]
        public string TaskName { get; set; }

        [Required]
        [StringLength(75)]
        public string TaskSchedule { get; set; }

        [StringLength(120)]
        public string Registration { get; set; }

        [StringLength(50)]
        public string TaskType { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? DoneDate { get; set; }

        [StringLength(1)]
        public string DoneVar { get; set; }

        public int? EquipmentId { get; set; }

        public virtual Equipment Equipment { get; set; }
    }
}
