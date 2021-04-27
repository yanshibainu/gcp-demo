using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gcp_demo.Entities
{
    [Table("patent")]
    public class Patent
    {
        /// <summary>
        ///     案號
        /// </summary>
        [Key]

        public string CaseId { get; set; }

        /// <summary>
        ///     名稱
        /// </summary>

        [Column(TypeName = "NVARCHAR(100)")]
        [Required]
        public string Name { get; set; }

        /// <summary>
        ///     檔案路徑
        /// </summary>
        [Required]
        [Column(TypeName = "NVARCHAR(500)")]
        public string Url { get; set; }
    }
}
