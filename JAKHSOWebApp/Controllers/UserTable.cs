namespace JAKHSOWebApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserTable")]
    public partial class UserTable
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string NameOfUser { get; set; }

        [Required]
        [StringLength(60)]
        public string Surname { get; set; }

        [Required]
        [StringLength(70)]
        public string UserPassword { get; set; }

        [StringLength(55)]
        public string UserType { get; set; }
    }
}
