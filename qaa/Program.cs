




using qaa;
using System.ComponentModel;
using System.Linq;

//using (WorkerContext database = new())
//{
//    Category category = new()
//    {
//        Name = "Rengsaz"
//    };
//    Worker worker = new()
//    {
//        PhotoPath = "uhduhfiud",
//        Name = "Anjelina",
//        Surname = "Jolie",
//        Email = "hhjrfir",
//        Password = "ghdgh",
//        CategoryName = "Rengsaz"
//    };
//    Orderer orderer = new()
//    {
//        PhotoPath = "uhduhfiud",
//        Name = "Anjelina",
//        Surname = "Jolie",
//        Email = "hhjrfir",
//        Password = "ghdgh",
//        CategoryName = "Rengsaz",
//        CompanyName = "jrojfirjfi"
//    };
//    database.Categories.Add(category);
//    database.Workers.Add(worker);
//    database.Orderers.Add(orderer);
//    database.SaveChanges();
//}










bool EmailUser(string email, string password)
{
    using (var db = new WorkerContext())
    {
        var work = db.Workers.Where(w => w.Email == email && w.Password == password);
        if (work != null) return true;
        return false;
    };
}





void CategoryUser(string categoryName)
{
    using (var db = new WorkerContext())
    {
        var workers = db.Workers.Where(w => w.CategoryName == categoryName);
        foreach (var worker in workers)
        {
            Console.WriteLine(worker.ToString());
        }
    };
}


void CategoryAdd(string categoryName)
{
    using (var db = new WorkerContext())
    {

        Category category = new()
        {
            Name = "njdvk"
        };
        db.Categories.Add(category);
        db.SaveChanges();
    };
}

void WorkerAdd(string photoPath, string name, string surname, string email,string password, string categoryName)
{
    using (var db = new WorkerContext())
    {

        Worker worker = new()
        {
            PhotoPath = photoPath,
            Name = name,
            Surname = surname,
            Email = email,
            Password = password,
            CategoryName = categoryName
        };
        db.Workers.Add(worker);
        db.SaveChanges();
    };
}

void OrdererAdd(string photoPath, string name, string surname, string email,string password, string categoryName, string companyName)
{
    using (var db = new WorkerContext())
    {

        Orderer orderer = new()
        {
            PhotoPath = photoPath,
            Name = name,
            Surname = surname,
            Email = email,
            Password = password,
            CategoryName = categoryName,
            CompanyName = companyName
        };
        db.Orderers.Add(orderer);
        db.SaveChanges();
    };
}

