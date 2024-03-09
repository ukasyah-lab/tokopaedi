namespace backend.Models;

public class ProductVariant
{
  public long Id { get; set; }
  public long ProductId { get; set; }
  public string Code { get; set; }
  public string Name { get; set; }
  public long Qty { get; set; }
  public long Price { get; set; }
  public bool Active { get; set; }
  public string CreatedUser { get; set; }
  public string CreatedDate { get; set; }
  public string UpdatedUser { get; set; }
  public string UpdatedDate { get; set; }
}
