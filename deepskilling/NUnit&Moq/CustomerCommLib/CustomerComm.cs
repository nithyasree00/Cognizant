namespace CustomerCommLib
{
    public class CustomerComm
    {
        private readonly IMailSender _mailSender;

        public CustomerComm(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer(Customer customer)
        {
            string message = "Welcome " + customer.Name;

            return _mailSender.SendMail(customer.Email, message);
        }
    }
}