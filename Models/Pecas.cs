//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oficial4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pecas
    {
        public int id_Pecas { get; set; }
        public string nome_Pecas { get; set; }
        public Nullable<double> preco_Pecas { get; set; }
        public int tipo { get; set; }
        public string nome_carro { get; set; }
    
        public virtual Tipo Tipo1 { get; set; }
    }
}
