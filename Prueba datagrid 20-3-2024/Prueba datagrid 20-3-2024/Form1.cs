namespace Prueba_datagrid_20_3_2024
{
    public partial class Form1 : Form
    {
        private int n = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // adiccionar nuevo renglon
            int n = dgv.Rows.Add();

            //colocar informarmacion
            dgv.Rows[n].Cells[0].Value = txtcodigo.Text;
            dgv.Rows[n].Cells[0].Value = txtnombre.Text;
            dgv.Rows[n].Cells[0].Value = txtprecio.Text;

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                lblinformacion.Text = (string)dgv.Rows[n].Cells[1].Value;
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
         if(n!= -1)
            { 
                dgv.Rows.RemoveAt(n);
        }
    }
}
