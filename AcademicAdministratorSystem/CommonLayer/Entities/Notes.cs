using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Notes
    {
        public int NoteId {  get; set; }
        public int EnrollmentsId {  get; set; }
        public decimal Note1 { get; set; }
        public decimal Note2 { get; set; }
        public decimal FinalNote {  get; set; }
    }
}
