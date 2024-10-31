using Career180_EFCore_Day2_Lab.Models;

namespace Career180_EFCore_Day2_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();

            //var category1 = new Category() {ID = 0, Name = "Cat1", Description = "Cat1 Descritpion" };
            //var category2 = new Category() {ID = 0, Name = "Cat2", Description = "Cat2 Descritpion" };
            //var category3 = new Category() {ID = 0, Name = "Cat3", Description = "Cat3 Descritpion" };
            //var category4 = new Category() {ID = 0, Name = "Cat4", Description = "Cat4 Descritpion" };
            //var category5 = new Category() {ID = 0, Name = "Cat5", Description = "Cat5 Descritpion" };
            
            //_context.Categories.Add(category1);
            //_context.Categories.Add(category2);
            //_context.Categories.Add(category3);
            //_context.Categories.Add(category4);
            //_context.Categories.Add(category5);
            //_context.SaveChanges();


            //var author1 = new Author() { ID = 0, Name = "auth1", Bref = "bref", JoinDate = DateTime.Now, Password = "Password", Username = "username"};
            //var author2 = new Author() { ID = 0, Name = "auth2", Bref = "bref", JoinDate = DateTime.Now, Password = "Password", Username = "username" };
            //var author3 = new Author() { ID = 0, Name = "auth3", Bref = "bref", JoinDate = DateTime.Now, Password = "Password", Username = "username" };
            //var author4 = new Author() { ID = 0, Name = "auth4", Bref = "bref", JoinDate = DateTime.Now, Password = "Password", Username = "username" };

            //_context.Add(author1);
            //_context.Add(author2);
            //_context.Add(author3);
            //_context.Add(author4);

            //_context.SaveChanges();
            
            //var news1= new News() { ID = 0, Title = "News1", Bref = "bref", dateTime = DateTime.Now, AuthorID = 2, CategoryID = 1, Description = "Desc" };
            //var news2= new News() { ID = 0, Title = "News2", Bref = "bref", dateTime = DateTime.Now, AuthorID = 2, CategoryID = 4, Description = "Desc" };
            //var news3= new News() { ID = 0, Title = "News3", Bref = "bref", dateTime = DateTime.Now, AuthorID = 3, CategoryID = 3, Description = "Desc" };
            //var news4= new News() { ID = 0, Title = "News4", Bref = "bref", dateTime = DateTime.Now, AuthorID = 5, CategoryID = 1, Description = "Desc" };
            //var news5= new News() { ID = 0, Title = "News5", Bref = "bref", dateTime = DateTime.Now, AuthorID = 4, CategoryID = 2, Description = "Desc" };

            //_context.News.Add(news1);
            //_context.News.Add(news2);
            //_context.News.Add(news3);
            //_context.News.Add(news4);
            //_context.News.Add(news5);

            //_context.SaveChanges();

            var news = _context.News;

            foreach (var item in news )
            {
                Console.WriteLine($"NEWS id: {item.ID}, title: {item.Title}, Category Name: {item.Category.Name}, Author Name: {item.Author.Name}");

            }
        }
    }
}
