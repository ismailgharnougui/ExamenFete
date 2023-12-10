using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domaine
{
    public enum TypeFete
    {
        Anniversaire,
        Mariage,
        Autre
    }
    public class Fete
    {
        public int FeteId { get; set; }
        [Required(ErrorMessage ="Description Fete Obligatoire")]
        public string Description { get; set; }
        public TypeFete Type { get; set; }
        [Range(1,250)]

        public int NbInvitesMax { get; set; }
        public int Duree { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateFete { get; set; }


        public virtual Salle Salle { get; set; }

        public virtual IList<Invitation> Invitations { get; set; }


    }
}
