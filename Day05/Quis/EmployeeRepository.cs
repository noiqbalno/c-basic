namespace Day05.Quis
{
    internal class EmployeeRepository : IRepository<Employee>
    {
        public void Delete(List<Employee> listEmployees, int id)
        {
            var get = listEmployees.Find(v => v.EmployeeID == id);

            if (get == null)
            {
                Console.WriteLine($"Employee dengan id {id} tidak ditemukan");
            } else
            {
                listEmployees.Remove(get);
                Console.WriteLine($"berhasil menghapus emplopyee dengan id {id}");
                Console.WriteLine();
            }
        }

        public void FindAll(List<Employee> listEmployee)
        {
            foreach (var item in listEmployee)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }

        public void FindById(List<Employee> listEmployee, int id)
        {
            var get = listEmployee.FindAll(v => v.EmployeeID == id);

            if (get == null)
            {
                Console.WriteLine($"Employee dengan id {id} tidak ditemukan");
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

        public void Save(List<Employee> entityList, Employee entity)
        {
            entityList.Add(entity);
        }

        public void Update(List<Employee> listEmployee, Employee entity, int id)
        {
            var emp = listEmployee.Find(v => v.EmployeeID == id);
            var employeeIndex = listEmployee.FindIndex(v => v.EmployeeID == id);
            if (emp == null)
            {
                Console.WriteLine($"Employee dengan id {id} tidak ditemukan");
            } else
            {
                //listEmployee.Remove(employeeIndex);
                //listEmployee.Add(entity);
                listEmployee[employeeIndex] = entity;

                var updatedEmp = listEmployee.FindAll(v => v.EmployeeID == id);
                foreach (var item in updatedEmp)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine();
                }
            }
        }

    }
}
