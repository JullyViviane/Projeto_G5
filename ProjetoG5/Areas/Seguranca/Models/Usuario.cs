using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoG5.Areas.Seguranca.Models
{
    public class Usuario : IdentityUser
    {
        public long? UsuarioId { get; set; }
    }
}