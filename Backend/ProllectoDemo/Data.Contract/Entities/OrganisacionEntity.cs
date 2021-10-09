﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contract.Entities
{
    public class OrganisacionEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Giro { get; set; }
        public string Decripcion { get; set; }
        public string ClaveInvitacion { get; set; }
        public TipoDeOraganisacionEntity Id_tipoDeOraganisacion { get; set; }
    }
}
