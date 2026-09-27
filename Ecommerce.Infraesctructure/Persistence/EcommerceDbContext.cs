using Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Persistence;

public class EcommerceDbContext : DbContext
{
    public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
    {}

    public DbSet<Customer> Customers { get; set; }
    public DbSet<CustomerAddress> CustomerAddresses { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<OrderProductReview> OrderProductReviews { get; set; } //OrderItemReview
    public DbSet<OrderUpdate> OrderUpdates { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Customer>(e =>
        {
            e.HasKey(c => c.Id);
            
            e.HasMany(c => c.Addresses)
                .WithOne()
                .HasForeignKey(a => a.IdCustomer)
                .OnDelete(DeleteBehavior.Restrict); // to delete an entity it will be restricted if it has related entities. We do not want to delete all orders of a customer when we delete the customer, we want to restrict the deletion if there are related order.

            e.HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.Customer) //IdCustomer
                .OnDelete(DeleteBehavior.Restrict);
            
            e.HasMany(c => c.Reviews) //Reviews
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.Customer) //IdCustomer
                .OnDelete(DeleteBehavior.Restrict);
        });
        
        builder.Entity<CustomerAddress>(e =>
        {
            e.HasKey(c => c.Id);
        });
        
        builder.Entity<Order>(e =>
        {
            e.HasKey(c => c.Id);
            
            e.HasMany(o => o.Items)
                .WithOne()
                .HasForeignKey(o => o.IdOrder)
                .OnDelete(DeleteBehavior.Restrict);
            
            e.HasMany(o => o.Updates)
                .WithOne()
                .HasForeignKey(o => o.IdOrder)
                .OnDelete(DeleteBehavior.Restrict); 
        });
        
        builder.Entity<OrderItem>(e =>
        {
            e.HasKey(c => c.Id);

            e.HasOne(oi => oi.Review)
                .WithOne(opr => opr.OrderItem)
                .HasForeignKey<OrderProductReview>(opr => opr.IdOrderItem)
                .OnDelete(DeleteBehavior.Restrict);
            
            e.HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.IdProduct)
                .OnDelete(DeleteBehavior.Restrict);
        });
        
        builder.Entity<OrderProductReview>(e =>
        {
            e.HasKey(c => c.Id);
        });
        
        builder.Entity<OrderUpdate>(e =>
        {
            e.HasKey(c => c.Id);
        });
        
        builder.Entity<Product>(e =>
        {
            e.HasKey(c => c.Id);
            
            e.HasMany(p => p.Images)
                .WithOne()
                .HasForeignKey(pi => pi.IdProduct)
                .OnDelete(DeleteBehavior.Restrict);
        });
        
        builder.Entity<ProductCategory>(e =>
        {
            e.HasKey(c => c.Id);
            
            e.HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(c => c.IdCategory)
                .OnDelete(DeleteBehavior.Restrict);
        });
        
        builder.Entity<ProductImage>(e =>
        {
            e.HasKey(c => c.Id);
        });
        
        base.OnModelCreating(builder);
    }
}