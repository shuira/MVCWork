namespace MVC5Work.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(vw_TableCountMetaData))]
    public partial class vw_TableCount
    {
    }
    
    public partial class vw_TableCountMetaData
    {
        [Required]
        public int ID { get; set; }
        public Nullable<int> custs { get; set; }
        public Nullable<int> custinfos { get; set; }
        public Nullable<int> cststconts { get; set; }
    }
}
