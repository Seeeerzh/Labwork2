using System.ComponentModel.DataAnnotations;
namespace WebAPI;
[Microsoft.EntityFrameworkCore.Keyless]

public class Technic
{
     private string _name = default!;
    private int _quantity = default!;
    public Technic()
    {
    }

    public Technic(Techniccompany techniccompany)
    {
        technicid = 0; 
        technicname = techniccompany.companyname;
        const int maxgamelength = 90;
        if(technicname.Length > maxgamelength)
            throw new ArgumentException("To many characters");
        const int mingamelength = 5;
        if(technicname.Length < mingamelength)
            throw new ArgumentException("Add some characters dude");
        typeoftechnic = techniccompany.origincountry;
        if (typeoftechnic == "invalid")
            throw new ArgumentException("invalid");
        dateofcreation = DateTime.UtcNow;
        usedbymajor = techniccompany.licenseforselling;
        
        
    }

    

        [Key]
    public int technicid { get;  set; }

    public string? technicname { get;  set; }

    public string? typeoftechnic { get;  set; }

     public DateTime dateofcreation { get;  set; }

    public bool usedbymajor { get;  set; }
   
}
