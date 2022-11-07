namespace GetPokeAPI.Classes
{
    internal class Cleaner
    {
        public static void ClearTextBox(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearTextBox(c);
            }
        }
    }
}
