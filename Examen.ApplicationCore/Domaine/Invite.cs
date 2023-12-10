﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domaine
{
    public class Invite
    {
        public int InviteId { get; set; }
        public  string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string AdresseInvite { get; set; }

        public virtual IList<Invitation> Invitations { get; set; }


    }
}
