using Microsoft.EntityFrameworkCore;


using WebAPI;

public class TechService
{
    private readonly TechnicContext _dbContext;

    public TechService(TechnicContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Technic>> GetTechnic()
    {
        
        var technics = await _dbContext.Technics.ToListAsync();
        return technics;
    }


    public async Task<Techniccompany> Create(Techniccompany techniccompany)
    {
        
        var technics = new Technic(techniccompany);
        var technic =await _dbContext.Technics.AddAsync(technics);
        await _dbContext.SaveChangesAsync();
        return techniccompany;
    }

     public async Task<Technic> GetTechnicID(int id)
    {
        var technics = await _dbContext.Technics.Where(x => x.technicid == id).FirstOrDefaultAsync();
        return technics;
    }
      public async Task<Technic> EditData(int id, Technic technic)
    {
       var technics = await _dbContext.Technics.Where(x => x.technicid == id).FirstOrDefaultAsync();
       if(technics != null){
         
         technics.technicname = technic.technicname;
         technics.typeoftechnic = technic.typeoftechnic;
         technics.usedbymajor = technic.usedbymajor;
         _dbContext.SaveChangesAsync();
       }
       return technics;
    }
     public async Task<Technic> Delete( int id)
    {
       var technics = await _dbContext.Technics.Where(x => x.technicid == id).FirstOrDefaultAsync();
       
       _dbContext.Technics.Remove(technics);
        await _dbContext.SaveChangesAsync();
          await _dbContext.Technics.ToListAsync();
        return technics;
    }
}