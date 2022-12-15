using System;
using WebAPI;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void WithInvalidInput_ThrowsAnException()
    {
        var techniccompany = new Techniccompany
        {
            companyid = Guid.Empty,
             companyname = "myTestingName2",
            origincountry = "invalid",
            licenseforselling = true,
            openingdate = DateTime.Now,
        };
        Assert.Throws<ArgumentException>(() =>
            new Technic(techniccompany));
    }

    [Fact]
    public void MaximusLetterus()
    {
        var techniccompany = new Techniccompany
        {
            companyid = Guid.Empty,
            companyname = "kguvocpqubxuntktdfgprfmzrqjhaklhsehqutfnitfcuhfnyadtptyciglpltweqigrggddmcpkrepeyillavorclwcfipdgvu",
            origincountry = "CHINA",
            licenseforselling = true,
            openingdate = DateTime.Now,
        };
        Assert.Throws<ArgumentException>(() =>
            new Technic(techniccompany));
    }

      [Fact]
    public void HaveCorrectProperties()
    {
        var techniccompany = new Techniccompany
        {
            companyid = Guid.Empty,
            companyname = "epeyillavorclwcfipdgvu",
            origincountry = "SWEEDEN",
            licenseforselling = true,
            openingdate = DateTime.Now,
        };

        var technic = new Technic(techniccompany);

        Assert.Equal(techniccompany.companyname, technic.technicname);
        Assert.Equal(techniccompany.origincountry, technic.typeoftechnic);
        Assert.Equal(techniccompany.licenseforselling, technic.usedbymajor);
        Assert.NotNull(technic.technicid);
          Assert.NotNull(technic.technicname);
            Assert.NotNull(technic.typeoftechnic);
        Assert.NotNull(technic.usedbymajor);
        Assert.NotNull(technic.dateofcreation);

    }

    
    [Fact]
    public void MinimusLetterus()
    {
        var techniccompany = new Techniccompany
        {
             companyid = Guid.Empty,
            companyname = "vu",
            origincountry = "SWEEDEN",
            licenseforselling = true,
            openingdate = DateTime.Now,
        };
        Assert.Throws<ArgumentException>(() =>
            new Technic(techniccompany));
    }
  
}