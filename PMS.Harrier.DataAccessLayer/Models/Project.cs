using System;
using System.ComponentModel.DataAnnotations;
using PMS.Harrier.DataAccessLayer.Models.Metadata;

namespace PMS.Harrier.DataAccessLayer.Models
{
    [MetadataType(typeof(ProjectMetadata))]
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDateTime { get; set; }
    }
}