
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Text;


namespace ZevaPortal.Models
{
    public class ZevaPortalDbContext : DbContext
    {
        public ZevaPortalDbContext(DbContextOptions<ZevaPortalDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ExtraInformation> ExtraInformation { get; set; }
        public DbSet<FilledExtraInformation> FilledExtraInformation { get; set; }
        public DbSet<Form> Forms { get; set; }
        public  DbSet<Guideline> Guidelines { get; set; }
        public DbSet<Question> Questions { get; set; }
        public  DbSet<ReviewedCategory> ReviewedCategories { get; set; }
        public  DbSet<ReviewedQuestion> ReviewedQuestions { get; set; }
    }
}
