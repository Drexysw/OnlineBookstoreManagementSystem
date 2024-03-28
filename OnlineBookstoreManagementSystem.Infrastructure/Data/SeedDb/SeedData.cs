using Microsoft.AspNetCore.Identity;
using OnlineBookstoreManagementSystem.Infrastructure.Data.Models;

namespace OnlineBookstoreManagementSystem.Infrastructure.Data.SeedDb
{
    public class SeedData
    {
        public IdentityUser SellerUser { get; set; } = new IdentityUser();
        public IdentityUser GuestUser { get; set; } = new IdentityUser();
        public Seller Seller { get; set; } = new Seller();
        public Category NovelCategory { get; set; } = new Category();
        public Category PsychologyCategory { get; set; } = new Category();
        public Category ThrillerCategory { get; set; } = new Category();
        public Book FirstBook { get; set; } = new Book();
        public Book SecondBook { get; set; } = new Book();
        public Book ThirdBook { get; set; } = new Book();
        public Author FirstAuthor { get; set; } = new Author();
        public Author SecondAuthor { get; set; } = new Author();
        public Author ThirdAuthor { get; set; } = new Author();  
        public SeedData()
        {
            SeedUsers();
            SeedSellers();
            SeedCategories();
            SeedAuthors();
            SeedBooks();
        }
        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            SellerUser = new IdentityUser()
            {
                Id = "deal1232-c23-dsds334-sdsk23-b2343431fefe",
                UserName = "seller@gmail.com",
                NormalizedUserName = "seller@gmail.com",
                Email = "seller@gmail.com",
                NormalizedEmail = "seller@gmail.com"
            };
            SellerUser.PasswordHash = hasher.HashPassword(SellerUser, "seller123");

            GuestUser = new IdentityUser()
            {
                Id = "fbjfif33-c23-ooo21-sdsk23-a3jfjcj224",
                UserName = "guestuser@gmail.com",
                NormalizedUserName = "guestuser@gmail.com",
                Email = "guestuser@gmail.com",
                NormalizedEmail = "guestuser@gmail.com"
            };
            GuestUser.PasswordHash = hasher.HashPassword(SellerUser, "guest123");
        }

        private void SeedSellers()
        {
            Seller = new Seller()
            {
                Id = 1,
                Name = "John",
                Rating = 5.5,
            };
        }

        private void SeedCategories()
        {
            ThrillerCategory = new Category()
            {
                Id = 1,
                Name = "Thriller"
            };
            PsychologyCategory = new Category()
            {
                Id = 2,
                Name = "Psychology"
            };
            NovelCategory = new Category()
            {
                Id = 3,
                Name = "Novel"
            };
        }

        private void SeedBooks()
        {
            FirstBook = new Book()
            {
                Id = 1,
                Title = "The silent patient",
                Description = "This is a third series book in the author collection.It represents the author inimaginary situation in the past",
                CategoryId = ThrillerCategory.Id,
                AuthorId = FirstAuthor.Id,
                Price = 40.00m,
                ImageUrl = "https://m.media-amazon.com/images/I/81JJPDNlxSL._AC_UF1000,1000_QL80_.jpg",
                SellerId = Seller.Id,
                BuyerId = GuestUser.Id,
            };
            SecondBook = new Book()
            {
                Id = 2,
                Title = "The Psychology Of Money Book",
                Description = "How to manage your budget.Think of a money like a businessman.",
                CategoryId = PsychologyCategory.Id,
                AuthorId = SecondAuthor.Id,
                Price = 60.00m,
                ImageUrl = "https://5.imimg.com/data5/ANDROID/Default/2021/1/AD/UC/ZK/19351533/product-jpeg-1000x1000.jpeg",
                SellerId = Seller.Id,
                BuyerId = GuestUser.Id
            };
            ThirdBook = new Book()
            {
                Id = 3,
                Title = "Fairy Tale",
                Description = "Join in a world full of fantasy and your mind will explode in happiness",
                CategoryId = NovelCategory.Id,
                AuthorId = ThirdAuthor.Id,
                Price = 70.00m,
                ImageUrl = "https://m.media-amazon.com/images/I/81blQfKsLtL._AC_UF1000,1000_QL80_.jpg",
                SellerId = Seller.Id,
                BuyerId = GuestUser.Id
            };
        }
        private void SeedAuthors()
        {
            FirstAuthor = new Author()
            {
                Id = 1,
                Name = "Alex Michaelides",
                Age = 45,
                Authobriography = "Has been writing psychology books for 20 years.Some of them are know araound the world"
            };
            SecondAuthor = new Author()
            {
                Id = 2,
                Name = "Morgan Housel",
                Authobriography = "Keen on psychology since childhood Morgan Housel is one of the briliant people on earth who wrote araound 300 humdreds psychology books",
                Age = 30
            };
            ThirdAuthor = new Author()
            {
                Id = 3,
                Name = "Fairy Tale",
                Authobriography = "He is one of the most artistic people on earth",
                Age = 50
            };
        }
        
    }
}
