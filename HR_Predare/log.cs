//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR_Predare
{
    using System;
    using System.Collections.Generic;
    
    public partial class log
    {
        public int id { get; set; }
        public System.DateTime date_in { get; set; }
        public System.DateTime date_out { get; set; }
        public int tabel { get; set; }
        public int view { get; set; }
        public int id_user { get; set; }
        public int form { get; set; }
    
        public virtual personal personal { get; set; }
    }
}
