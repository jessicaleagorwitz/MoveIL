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
    
    public partial class PlacesOfStudy
    {
        public int PlaceCode { get; set; }
        public string PlaceName { get; set; }
        public string Address { get; set; }
        public int SectorCode { get; set; }
        public bool DoesItHaveBoardingSchool { get; set; }
    
        public virtual Sector Sector { get; set; }
        public virtual ProfessionsForPlaceToStudy ProfessionsForPlaceToStudy1 { get; set; }
    }
}
