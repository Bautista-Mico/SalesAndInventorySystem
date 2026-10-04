namespace UI
{
    internal class LoginForm
    {
        private string v;

        public LoginForm(string v)
        {
            this.v = v;
        }

        internal void Show()
        {
            // Create an instance of the form first
            LandingForm cashierForm = new LandingForm();

            // Call Show() on the instance object
            cashierForm.Show();
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}