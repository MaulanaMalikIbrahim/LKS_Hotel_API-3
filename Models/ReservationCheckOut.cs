//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LKS_Hotel_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReservationCheckOut
    {
        public int ID { get; set; }
        public int ReservationRoomID { get; set; }
        public int ItemID { get; set; }
        public int ItemStatusID { get; set; }
        public int Qty { get; set; }
        public int TotalCharge { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual ItemStatu ItemStatu { get; set; }
        public virtual ReservationRoom ReservationRoom { get; set; }
    }
}