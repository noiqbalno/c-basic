namespace Day05.Quis
{
    internal class Supplier : AbstractPersonContact
    {
        public int SupplierID { get; set; }
        public string HomePage { get; set; }

        public override string ToString()
        {
            return $"SupplierID: {SupplierID}\n" +
                   $"CompanyName: {CompanyName}\n" +
                   $"ContactName: {ContactName}\n" +
                   $"ContactTitle: {ContactTitle}\n" +
                   $"HomePage: {HomePage}\n" +
                   $"Address: {Address}\n" +
                   $"City: {City}\n" +
                   $"Region: {Region}\n" +
                   $"Postal Code: {PostalCode}\n" +
                   $"Country: {Country}\n";
        }
    }


}
