using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TranDucThinh_231230917_de01.models;

public partial class TranDucThinhComputer
{
    [Key]
    public string TranDucThinhComId { get; set; } = null!;

    public string? TranDucThinhComName { get; set; }

    [RegularExpression("^[0-9]+$", ErrorMessage ="Phải là số")]
    [Range(100,500, ErrorMessage ="Gía phải nằm trong 100-500")]
    public decimal? TranDucThinhComPrice { get; set; }

    [RegularExpression(@".*\.(jpg|png|gif|tiff)$", ErrorMessage = "File ảnh phải là jpg, png, gif hoặc tiff")]
    public string? TranDucThinhComImage { get; set; }

    public bool? TranDucThinhComStatus { get; set; }
}
