using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domaine
{
    public class Invitation
    {
         
        public DateTime DateInvitation { get; set; }
        public bool ConfirmeInvitation { get; set; }
        public int InviteFk { get; set; }
        public int FeteFk { get; set; }

        public virtual Invite Invite { get; set; }
        public virtual Fete Fete { get; set; }
    }
}
