using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdk.Ef.Repro.Lib.Models
{
    public class IntRecord
    {
        [Key]
        public int RecordId { get; set; }

        public int Value { get; set; }
    }
}
