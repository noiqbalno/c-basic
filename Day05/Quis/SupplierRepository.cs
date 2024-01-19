namespace Day05.Quis
{
    internal class SupplierRepository : IRepository<Supplier>
    {
        public void Delete(List<Supplier> listSuppliers, int id)
        {
            var get = listSuppliers.Find(v => v.SupplierID == id);

            if (get == null)
            {
                Console.WriteLine($"Supplier dengan id {id} tidak ditemukan");
            }
            else
            {
                listSuppliers.Remove(get);
                Console.WriteLine($"berhasil menghapus Supplier dengan id {id}");
                Console.WriteLine();
            }
        }

        public void FindAll(List<Supplier> listSupplier)
        {
            foreach (var item in listSupplier)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }

        public void FindById(List<Supplier> listSupplier, int id)
        {
            var get = listSupplier.FindAll(v => v.SupplierID == id);

            if (get == null)
            {
                Console.WriteLine($"Supplier dengan id {id} tidak ditemukan");
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

        public void Save(List<Supplier> entityList, Supplier entity)
        {
            entityList.Add(entity);
        }

        public void Update(List<Supplier> listSupplier, Supplier entity, int id)
        {
            var supp = listSupplier.Find(v => v.SupplierID == id);
            var supplierIndex = listSupplier.FindIndex(v => v.SupplierID == id);
            if (supp == null)
            {
                Console.WriteLine($"Supplier dengan id {id} tidak ditemukan");
            }
            else
            {
                //listSupplier.Remove(supplierIndex);
                //listSupplier.Add(entity);
                listSupplier[supplierIndex] = entity;

                var updatedSupp = listSupplier.FindAll(v => v.SupplierID == id);
                foreach (var item in updatedSupp)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine();
                }
            }
        }

    }
}
