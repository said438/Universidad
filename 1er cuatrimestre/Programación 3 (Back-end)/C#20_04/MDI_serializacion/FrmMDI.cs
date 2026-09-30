namespace MDI_serializacion
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void aBMPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersona p = new frmPersona();
            p.MdiParent = this;
            p.Show();
        }
    }
}