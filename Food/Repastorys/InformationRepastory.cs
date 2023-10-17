using Food.Data;
using Food.Interface;
using Food.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Mapster;
using Food.Dto_s;
using System.Text.RegularExpressions;

namespace Food.Repastorys
{
    public class InformationRepastory : IInformationRepastory
    {
        private readonly AppDbContext _appDbContext;
        public InformationRepastory(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<InformationsDto> Add(InformationsDto information)
        {
            var info = information.Adapt<Informations>();
            _appDbContext.Informations.Add(info);
            await _appDbContext.SaveChangesAsync();
            return information;
        }

        public async Task Delete(int id)
        {
            var getid = await _appDbContext.Informations.FindAsync(id);
            _appDbContext.Informations.Remove(getid);
            await _appDbContext.SaveChangesAsync();

        }

        public async Task<List<Informations>> GetAllInformation() => await _appDbContext.Informations.ToListAsync();

        public async Task<Informations> GetIdInformation(int id) => await _appDbContext.Informations.FindAsync(id);

        public async Task<Informations> Update(int id, Informations informations)
        {
            var infor = await _appDbContext.Informations.FindAsync(id);
            infor.Locasion = informations.Locasion;
            infor.PhoneNumber = informations.PhoneNumber;
            infor.Gmail = informations.Gmail;
            _appDbContext.Informations.Update(infor);
            await _appDbContext.SaveChangesAsync();
            return informations;
        }
    }
}
