namespace _2048WinFormsApp
{
    public class Validation
    {
        public static bool IsValidateIsNullOrEmpty(Control control, ErrorProvider errorProvider, System.ComponentModel.CancelEventArgs e, out string errorMessage)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                errorMessage = "Поле не может быть пустым!";
                errorProvider.SetError(control, errorMessage);
                e.Cancel = true;
                return false;
            }
            else
            {
                errorMessage = string.Empty;
                errorProvider.SetError(control, errorMessage);
                return true;
            }
        }
    }
}
