namespace backend.Models;

public class Transaction
{
  public long Id { get; set; }
  public string TransactionNo { get; set; }
  public long TotalAmount { get; set; }
  public bool Active { get; set; }
  public string CreatedUser { get; set; }
  public string CreatedDate { get; set; }
  public string UpdatedUser { get; set; }
  public string UpdatedDate { get; set; }
}
