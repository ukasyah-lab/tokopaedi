namespace backend.Models;

public class Product
{
  public long Id { get; set; }
  public string Plu { get; set; }
  public string Name { get; set; }
  public long ProductCategoryId { get; set; }
  public bool Active { get; set; }
  public string CreatedUser { get; set; }
  public string CreatedDate { get; set; }
  public string UpdatedUser { get; set; }
  public string UpdatedDate { get; set; }
}
