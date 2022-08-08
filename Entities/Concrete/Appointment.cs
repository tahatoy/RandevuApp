using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Appointment:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime ApoDate { get; set; }
    }
}
