namespace WebAPI;
[Microsoft.EntityFrameworkCore.Keyless]

public class Techniccompany
{
     public Guid companyid { get; set; }

    public string? companyname { get; set; }

    public string? origincountry { get; set; }

     public DateTime openingdate { get; set; }

    public bool licenseforselling { get; set; }
}