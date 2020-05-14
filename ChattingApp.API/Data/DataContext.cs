//using system;
using Microsoft.EntityFrameworkCore;
using ChattingApp.API.Models;

namespace ChattingApp.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options){}


        public DbSet<Value> Values {get;set;}
        
        
    }
}