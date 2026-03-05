using System.Collections.Specialized;

namespace PruebaWinForms
{
    
    public partial class Form1 : Form
    {
        public int Count { get; set; }
        public Form1()
        {
            InitializeComponent();
            Count = 0;
        }
        private void InicializarBoton()
        {
            Button btnMostarEtiqueta = new Button();
            btnMostarEtiqueta.Text = "Mostrar";
            btnMostarEtiqueta.Size = new Size(500, 250);
            btnMostarEtiqueta.Location = new Point(50, 150);
            btnMostarEtiqueta.Click += Mostrar_Etiqueta;
            this.Controls.Add(btnMostarEtiqueta);
        }
        private void Mostrar_Etiqueta(object sender, EventArgs e)
        {
            Label lblEtiqueta = new Label();
            lblEtiqueta.ForeColor = Color.Red;
            lblEtiqueta.Text = "Soy Una etiqueta";
            lblEtiqueta.Size = new Size(100, 50);
            lblEtiqueta.Location = new Point(200, 50);
            this.Controls.Add(lblEtiqueta);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Count++;
            base.Text = Count.ToString();
        }
    }
}
