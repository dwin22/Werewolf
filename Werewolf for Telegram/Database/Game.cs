//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Game
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Game()
        {
            this.GameKills = new HashSet<GameKill>();
            this.GamePlayers = new HashSet<GamePlayer>();
        }
    
        public int Id { get; set; }
        public string GroupName { get; set; }
        public long GroupId { get; set; }
        public Nullable<System.DateTime> TimeStarted { get; set; }
        public Nullable<System.DateTime> TimeEnded { get; set; }
        public string Winner { get; set; }
        public Nullable<int> GrpId { get; set; }
        public string Mode { get; set; }
    
        public virtual Group Group { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameKill> GameKills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GamePlayer> GamePlayers { get; set; }
    }
}
