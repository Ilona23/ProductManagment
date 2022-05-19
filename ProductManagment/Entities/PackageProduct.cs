namespace ProductManagment.Entities
{
    public class PackageProduct
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public Package Package { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
