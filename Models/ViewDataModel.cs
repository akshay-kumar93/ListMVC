using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ViewDataModel
{
    public int AppId { get; set; }
    public string ParameterName { get; set; }
    public decimal SellPrice { get; set; }
    public decimal BuyPrice { get; set; }
    public bool IsEnable { get; set; }
    public DateTime InsertedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
}
