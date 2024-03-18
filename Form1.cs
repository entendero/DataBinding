namespace DemoDataBinding1
{
    public partial class Form1 : Form
    {
        //exemple3: afegir la propietat bs
        private BindingSource bs;
        public Form1()
        {
            InitializeComponent();
            //Generem dades d'alumnes.
            Alumne alum1 = new Alumne("Hugo", "Martra", "hmartra@vidalibarraquer.net", "12/04/2005", true, false);
            Alumne alum2 = new Alumne("David", "Paz", "hmartra@vidalibarraquer.net", "22/07/2002", false, true);
            Alumne alum3 = new Alumne("Marc", "Cortes", "mcortes@vidalibarraquer.net", "05/03/2003", true, false);

            //afegim els alumnes creats anteriorment a la llista d'alumnes.
            List<Alumne> alumnes = new List<Alumne>();
            alumnes.Add(alum1);
            alumnes.Add(alum2);
            alumnes.Add(alum3);

            //Creem el binding
            bs = new BindingSource();
            bs.DataSource = alumnes;

            //Creem les columnes que tindrà
            grid.DataSource = bs;
            //
            textBoxNom.DataBindings.Add("Text", bs, "nom");
            //
            textBoxCognom.DataBindings.Add("Text", bs, "cognoms");
            //

            textBoxMail.DataBindings.Add("Text", bs, "mail");
            //
            textBoxDataNaix.DataBindings.Add("Text", bs, "data_naixement");

            radioHorariMati.DataBindings.Add("Checked", bs, "horari_mati");
            radioHorariTarda.DataBindings.Add("Checked", bs, "horari_tarda");
            checkBoxCurs1.DataBindings.Add("Checked", bs, "Curset1");
            checkBoxCurs2.DataBindings.Add("Checked", bs, "Curset2");
            checkBoxCurs3.DataBindings.Add("Checked", bs, "Curset3");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //exemple 1
        }

        private void buttonAfegir_Click(object sender, EventArgs e)
        {
            //crear llibre en blanc
            Alumne nouAlumne = new Alumne("", "", "", "", true, false);
            //afegir al bs
            bs.Add(nouAlumne);
            //seleccionar el llibre nou al grid
            int rowIndex = bs.IndexOf(nouAlumne);
            grid.CurrentCell = grid.Rows[rowIndex].Cells[1];
        }

        //exemple 3
        private void buttonEsborrar_Click(object sender, EventArgs e)
        {
            // Comprova si hi ha alguna fila seleccionada
            if (grid.SelectedRows.Count > 0)
            {
                // Obté la fila seleccionada
                DataGridViewRow selectedRow = grid.SelectedRows[0];

                // Pregunta si l'usuari està segur de voler esborrar la fila
                DialogResult result = MessageBox.Show("Estàs segur que vols esborrar aquesta fila?", "Confirma acció destructiva", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);

                // Si l'usuari està segur, esborra la fila
                if (result == DialogResult.Yes)
                {
                    grid.Rows.Remove(selectedRow);
                }
            }
            else
            {
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && e.Control)
            {
                //opció1: cridar al mateix event handler del buttonEsborrar
                buttonEsborrar_Click(sender, e);
                //marcar event com a gestionat
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F5 && e.Control)
            {
                buttonAfegir_Click(sender, e);
                //marcar event com a gestionat
                e.Handled = true;
            }
        }

        private void buttonAjuda_Click(object sender, EventArgs e)
        {

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}