//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChicoDoColchao.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class LojaProduto
    {
        public int LojaProdutoID { get; set; }
        public int LojaID { get; set; }
        public int ProdutoID { get; set; }
        public short Quantidade { get; set; }
        public bool Ativo { get; set; }
    
        public virtual Loja Loja { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
