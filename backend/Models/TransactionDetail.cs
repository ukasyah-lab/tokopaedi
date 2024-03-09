namespace backend.Models;

public class TransactionDetail
{
  public long Id { get; set; }
  public long TransactionId { get; set; }
  public long ProductVariantId { get; set; }
  public long Price { get; set; }
  public long Qty { get; set; }
  public long Subtotal { get; set; }
  public bool Active { get; set; }
  public string CreatedUser { get; set; }
  public string CreatedDate { get; set; }
  public string UpdatedUser { get; set; }
  public string UpdatedDate { get; set; }
}
