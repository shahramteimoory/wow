//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Boost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Boost()
        {
            this.Run = new HashSet<Run>();
        }
    
        public int BoostID { get; set; }
        public bool Mine { get; set; }
        public int PlayerID { get; set; }
        public System.DateTime DateTime { get; set; }
        public long Gold { get; set; }
        public int DungeonID { get; set; }
        public Nullable<int> Lvl { get; set; }
    
        public virtual Dungeon Dungeon { get; set; }
        public virtual Player Player { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Run> Run { get; set; }
    }
}
