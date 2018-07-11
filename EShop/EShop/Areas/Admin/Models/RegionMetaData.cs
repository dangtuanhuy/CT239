using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using EShop.Models;

namespace EShop.Areas.Admin.Models
{
    public class RegionMetaData
    {
    }
    [MetadataTypeAttribute(typeof(Region.RegionMetaData))]
    public partial class Region
    {
        internal sealed class RegionMetaData
        {
            public int RegionId { get; set; }

            [Required(ErrorMessage = "Region can not null")]
            [Display(Name = "Region")]
            public string RegionName { get; set; }

            [Required(ErrorMessage = "Description can not null")]
            [Display(Name = "Description")]
            public string RegionDescription { get; set; }
        }
    }
}