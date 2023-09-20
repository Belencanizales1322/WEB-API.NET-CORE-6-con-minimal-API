using CRM.API.Models.EN;
using Microsoft.EntityFrameworkCore;

namespace CRM.API.Models.DAL
{
    public class CustomerDAL
    {
        readonly CRMContext _context;

        public CustomerDAL(CRMContext cRMcontext)
        {
            _context = cRMcontext;
        }

        public async Task<int> Create(Customer customer)
        {
            _context.Add(customer);
            return await _context.SaveChangesAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            var customer = await _context.customers.FirstOrDefaultAsync(s => s.Id == id);
            return customer != null ? customer : new Customer();
        }
    }
}
