using NUnit.Framework;

namespace CustomerApp.Domain.Tests
{
    public class CustomerTests
    {
        [Test]
        public void GivenANewCustomer_WhenRegister_ThenIsValidatedSavedEmailedSuccessfully()
        {
            //Step1: Create an Instance of Customer Class
            Customer customer = Customer.Create(
                "Jose Cuadros", "p.cuadros@gmail.com", "1234567890", "Tacnamandapio", "str0ng.pa55");

            //Step2: Validate the Customer
            Validator validator = new Validator();
            bool IsValid = validator.ValidateCustomer(customer);
            //Step3: Save the Customer Object into the database
            DataAccessLayer dataAccessLayer = new DataAccessLayer();
            bool IsSaved = dataAccessLayer.SaveCustomer(customer);
            //Step4: Send the Registration Email to the Customer
            EmailService email = new EmailService();
            bool IsEmailed = email.SendRegistrationEmail(customer);

            Assert.That(customer, Is.Not.Null);
            Assert.That(dataAccessLayer.Customers.Count, Is.GreaterThan(0));
            Assert.That(IsValid, Is.True);
            Assert.That(IsSaved, Is.True);
            Assert.That(IsEmailed, Is.True);
        }
        [Test]
        public void GivenANewCustomer_WhenRegister_ThenIsRegisteredSuccessfully()
        {
            //Step1: Create an Instance of Customer Class
            Customer customer = Customer.Create(
                "Jose Cuadros","p.cuadros@gmail.com","1234567890","Tacnamandapio","str0ng.pa55");
            //Step2: Using Facade Class
            bool IsRegistered = new CustomerRegistration().RegisterCustomer(customer);
            Assert.That(customer, Is.Not.Null);
            Assert.That(IsRegistered, Is.True);
        } 
    }
}