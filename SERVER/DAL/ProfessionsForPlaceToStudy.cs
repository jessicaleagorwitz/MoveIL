//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProfessionsForPlaceToStudy
    {
        public int PlaceCode { get; set; }
        public int ProfessionCode { get; set; }
        public string AmountYears { get; set; }
        public bool DoesSpeakHebrew { get; set; }
    
        public virtual Profession Profession { get; set; }
        public virtual PlacesOfStudy PlacesOfStudy1 { get; set; }
    }
}
