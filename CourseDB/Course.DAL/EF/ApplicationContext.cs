using de = Course.DAL.Entities;
using Course.DAL.Entities;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Course.DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string conectionString) : base(conectionString) { }
        static ApplicationContext()
        {
            Database.SetInitializer<ApplicationContext>(new StoreDbInitializer());
        }

        public DbSet<ClientProfile> ClientProfiles { get; set; }
        public DbSet<Entities.Course> Courses { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }

    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {
            db.Posts.Add(new Post { Id = 1, Name = "Студент" });
            db.Posts.Add(new Post { Id = 2, Name = "Преподаватель " });
            db.Posts.Add(new Post { Id = 3, Name = "Аспирант" });
            db.Posts.Add(new Post { Id = 4, Name = "Старший преподаватель" });

            db.Disciplines.Add(new Discipline { Id = 1, Name = "Математика" });
            db.Disciplines.Add(new Discipline { Id = 2, Name = "Физика" });
            db.Disciplines.Add(new Discipline { Id = 3, Name = "экономика" });
            db.Disciplines.Add(new Discipline { Id = 4, Name = "химия" });
            db.Disciplines.Add(new Discipline { Id = 5, Name = "программирование" });

            db.Courses.Add(new de.Course { Id = 1, Name = "Прикладная математика", DisciplineId = 1});
            db.Courses.Add(new de.Course { Id = 2, Name = "Высшая математика", DisciplineId = 1 });
            db.Courses.Add(new de.Course { Id = 3, Name = "Теория вероятности", DisciplineId = 1 });
            db.Courses.Add(new de.Course { Id = 4, Name = "Прикладная физика", DisciplineId = 2 });
            db.Courses.Add(new de.Course { Id = 5, Name = "Высшая физика", DisciplineId = 2 });
            db.Courses.Add(new de.Course { Id = 6, Name = "Теория физики", DisciplineId = 2 });
            db.Courses.Add(new de.Course { Id = 4, Name = "Прикладная экономика", DisciplineId = 3 });
            db.Courses.Add(new de.Course { Id = 5, Name = "Высшая экономика", DisciplineId = 3 });
            db.Courses.Add(new de.Course { Id = 6, Name = "Теория экономики", DisciplineId = 3 });
            db.Courses.Add(new de.Course { Id = 4, Name = "Прикладная химия", DisciplineId = 4 });
            db.Courses.Add(new de.Course { Id = 5, Name = "Высшая химия", DisciplineId = 4 });
            db.Courses.Add(new de.Course { Id = 6, Name = "Теория химии", DisciplineId = 4 });
            db.Courses.Add(new de.Course { Id = 4, Name = "ООП", DisciplineId = 5 });
            db.Courses.Add(new de.Course { Id = 5, Name = "БД", DisciplineId = 5 });
            db.Courses.Add(new de.Course { Id = 6, Name = "Модульное тестирование", DisciplineId = 5 });
            


            //Instructions = new List<Instruction>() { s4 }

            db.SaveChanges();
        }
    }
}
