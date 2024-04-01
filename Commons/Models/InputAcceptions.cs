namespace Common.Models
{
    public partial class InputAcceptions
    {
        public void PhoneAcceptions(ref KeyPressEventArgs e)
        { e.Handled = !(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '-')); }
        public void FirstNameAcceptions(ref KeyPressEventArgs e)
        { e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back); }

        public void MiddleNameAcceptions(ref KeyPressEventArgs e)
        { e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back); }
        public void LastNameAcceptions(ref KeyPressEventArgs e)
        { e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back); }

        public void EmailAcceptions(ref KeyPressEventArgs e)
        { e.Handled = e.KeyChar == (char)Keys.Space; }

        public void JobAcceptions(ref KeyPressEventArgs e)
        { e.Handled = true; } 

        public void CityAcceptions(ref KeyPressEventArgs e)
        { e.Handled = true; }
    }
}
