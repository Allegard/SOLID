using SolidPrinciples.OpenClosed;

namespace SolidPrinciples.SR
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }

        public bool InsertPerson(Person person)
        {
            // Insert person in a database table.
            //_personRepository.Insert(...);
            //Para insertar solo debera hacer una llamada al metodo que inserta y no implementar la insercion
            //SqlConnection connection = new SqlConnection();
            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO [...]");
            return true;
        }

        public void GenerateReport(Person person)
        {
            // Generate report
        }
    }
}