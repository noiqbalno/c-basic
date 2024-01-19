namespace Day05.Quis
{
    internal class CustomerRepository : IRepository<Customer>
    {
        public void Delete(List<Customer> listCustomers, int id)
        {
            var get = listCustomers.Find(v => v.CustomerID == id);

            if (get == null)
            {
                Console.WriteLine($"Customer dengan id {id} tidak ditemukan");
            }
            else
            {
                listCustomers.Remove(get);
                Console.WriteLine($"berhasil menghapus customer dengan id {id}");
                Console.WriteLine();
            }
        }

        public void FindAll(List<Customer> listCustomer)
        {
            foreach (var item in listCustomer)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }

        public void FindById(List<Customer> listCustomer, int id)
        {
            var get = listCustomer.FindAll(v => v.CustomerID == id);

            if (get == null)
            {
                Console.WriteLine($"Customer dengan id {id} tidak ditemukan");
            }
            else
            {
                foreach (var item in get)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine();
                }
            }
        }

        public void Save(List<Customer> entityList, Customer entity)
        {
            entityList.Add(entity);
        }

        public void Update(List<Customer> listCustomer, Customer entity, int id)
        {
            var cust = listCustomer.Find(v => v.CustomerID == id);
            var customerIndex = listCustomer.FindIndex(v => v.CustomerID == id);
            if (cust == null)
            {
                Console.WriteLine($"Customer dengan id {id} tidak ditemukan");
            }
            else
            {
                //listCustomer.Remove(customerIndex);
                //listCustomer.Add(entity);
                listCustomer[customerIndex] = entity;

                var updatedCust = listCustomer.FindAll(v => v.CustomerID == id);
                foreach (var item in updatedCust)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine();
                }
            }
        }

    }
}
