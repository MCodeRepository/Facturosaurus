namespace Facturosaurus.Forms.Api.Services
{
    internal class Result<T>
    {
        public T Value { get; set; }
        public int Status { get; set; }

        public string Info { get; set; }
    }
}
