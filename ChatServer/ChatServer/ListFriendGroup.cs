//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class ListFriendGroup
    {
        public int id { get; set; }
        public Nullable<int> idGroup { get; set; }
        public Nullable<int> idFriend { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual GroupChat GroupChat { get; set; }
    }
}
