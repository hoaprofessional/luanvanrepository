using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("LANGUAGECODE")]
    public class LanguageCode
    {
        /// <summary>
        /// example 'en'
        /// </summary>
        [Key]
        [StringLength(5)]
        [Column(TypeName = "varchar")]
        public String Code { get; set; }

        /// <summary>
        /// example 'English'
        /// </summary>
        [StringLength(100)]
        [Column(TypeName = "nvarchar")]
        public String Name { get; set; }

    }
}
