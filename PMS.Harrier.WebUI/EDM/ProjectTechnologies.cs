//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMS.Harrier.WebUI.EDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectTechnologies
    {
        public int ProjectTechnologiesId { get; set; }
        public int TechnologiesId { get; set; }
        public int ProjectId { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual Technologies Technologies { get; set; }
    }
}