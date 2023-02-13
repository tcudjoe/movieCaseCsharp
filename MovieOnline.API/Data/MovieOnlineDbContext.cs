using Microsoft.EntityFrameworkCore;
using MovieOnline.API.Entities;

namespace MovieOnline.API.Data
{
    public class MovieOnlineDbContext:DbContext
    {
        public MovieOnlineDbContext(DbContextOptions<MovieOnlineDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // action movies
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Black Adam",
                Description = "After being bestowed with godly powers and imprisoned for it, Black Adam is liberated from his earthly binds to unleash his fury on the modern world.",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Black Panther: Wakanda forever",
                Description = "After being bestowed with godly powers and imprisoned for it, Black Adam is liberated from his earthly binds to unleash his fury on the modern world.",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Thor: Love and Thunder",
                Description = "Thor embarks on a journey unlike anything he's ever faced -- a quest for inner peace. However, his retirement gets interrupted by Gorr the God Butcher, a galactic killer who seeks the extinction of the gods. .",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 12,
                Qty = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Avatar: The way of water",
                Description = "Jake Sully and Ney'tiri have formed a family and are doing everything to stay together. However, they must leave their home and explore the regions of Pandora. When an ancient threat resurfaces, Jake must fight a difficult war against the humans.",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 1

            });

            // Comedy movies
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Ticket to Paradise",
                Description = "A man and his ex-wife race to Bali, Indonesia, to stop their daughter from marrying a seaweed farmer. As they desperately try to sabotage the wedding, the bickering duo soon find themselves rekindling old feelings that once made them happy together.",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Bullet Train",
                Description = "Ladybug is an unlucky assassin who's determined to do his job peacefully after one too many gigs has gone off the rails.",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "White Noise",
                Description = "College professor Jack Gladney and his family's comfortable suburban life is upended when a nearby chemical leak causes \"The Airborne Toxic Event,\" releasing a noxious black cloud over the region that forces the Gladney family to evacuate.",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "The Takedown",
                Description = "Ousmane and François are two cops with very different styles. The unlikely pair are reunited once again for a new investigation.",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 2

            });

            // sci fi
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Ticket to Paradise",
                Description = "A man and his ex-wife race to Bali, Indonesia, to stop their daughter from marrying a seaweed farmer. As they desperately try to sabotage the wedding, the bickering duo soon find themselves rekindling old feelings that once made them happy together.",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "DC League of Super-Pets",
                Description = "When Superman and the rest of the league get kidnapped by Lex Luthor, it is up to Superdog Krypto to rescue them. He finds a group of shelter pets with superpowers and convinces them to help him.",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Nope",
                Description = "A man and his sister discover something sinister in the skies above their California horse ranch, while the owner of a nearby theme park tries to profit from the mysterious, otherworldly phenomenon..",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Spiderhead",
                Description = "Two inmates form a connection while grappling with their pasts in a state-of-the-art penitentiary run by a brilliant visionary who experiments on his subjects with mind-altering drugs.",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 3

            });

            //horror
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Smile",
                Description = "After witnessing a bizarre, traumatic incident involving a patient, Dr. Rose Cotter starts experiencing frightening occurrences that she can't explain.",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "The Menu",
                Description = "The film, penned by Will Tracy and Seth Reiss, focuses on a young couple who visits an exclusive destination restaurant on a remote island",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "The Invitation",
                Description = "After the death of her mother and having no other known relatives, Evie takes a DNA test and discovers a long-lost cousin she never knew she had.",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "X",
                Description = "A filmmaking crew and the cast make an adult movie at a reclusive place but elderly hosts find them and try to kill them.",
                ImgUrl = "/Images/Beauty/Beauty1.png",
                Price = 10,
                Qty = 100,
                CategoryId = 4

            });

            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Action"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Comedy"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Sci Fi"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "horror"
            });
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> Cartitems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}