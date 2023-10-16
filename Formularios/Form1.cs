namespace Rarug.Francisco.Parcial;
using Fabrica;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void botonIngresar_Click(object sender, EventArgs e)
    {
        string usuario = this.textBoxUsername.Text;
        string password = this.textBoxPassword.Text;
        string rango = string.Empty;
        Rango rangoAuxiliar = Rango.Supervisor;

        foreach (Control item in gbRango.Controls)
        {
            if (item is RadioButton && ((RadioButton)item).Checked)
            {
                rango = ((RadioButton)item).Text;
            }
        }

        if (rango == "Operario")
        {
            rangoAuxiliar = Rango.Operario;
        }



        foreach (Operario operario in Operario.ListaOperarios)
        {
            if (usuario == operario.Usuario && password == operario.Password && rangoAuxiliar == Rango.Operario)
            {
                MessageBox.Show(operario.Mostrar(),"Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                FormFabricaOperario formFabrica = new FormFabricaOperario();
                Hide();
                DialogResult result = formFabrica.ShowDialog();

                if (result == DialogResult.Cancel)
                {
                    Show();
                }
            }
        }


        foreach (Supervisor supervisor in Supervisor.ListaSupervisor)
        {
            if (usuario == supervisor.Usuario && password == supervisor.Password && rangoAuxiliar == Rango.Supervisor)
            {
                MessageBox.Show(supervisor.Mostrar(), "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                FormFabricaSupervisor formFabrica = new FormFabricaSupervisor();
                Hide();
                DialogResult result = formFabrica.ShowDialog();

                
                if (result == DialogResult.Cancel)
                {
                    Show();
                }
            }
        }
    }

    private void HardSuper_Click(object sender, EventArgs e)
    {
        this.textBoxUsername.Text = "Francisco";
        this.textBoxPassword.Text = "7777";
        this.rbSupervisor.Checked = true;

    }

    private void HardOper_Click(object sender, EventArgs e)
    {
        this.textBoxUsername.Text = "Lauti";
        this.textBoxPassword.Text = "Profe";
        this.rbOperario.Checked = true;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Operario operario1 = new Operario("Martin", "12345", Rango.Operario, "Chacal");
        Operario operario2 = new Operario("Federico", "12345", Rango.Operario, "Galarza");
        Operario operario3 = new Operario("Paola", "12345", Rango.Operario, "Argento");
        Operario operario4 = new Operario("Lauti", "profe", Rango.Operario, "Profe");
        Operario operario5 = new Operario("Lucas", "profe", Rango.Operario, "Profe");
        Operario operario6 = new Operario("Mathi", "profe", Rango.Operario, "Bustamante");

        Operario.ListaOperarios.Add(operario1);
        Operario.ListaOperarios.Add(operario2);
        Operario.ListaOperarios.Add(operario3);
        Operario.ListaOperarios.Add(operario4);
        Operario.ListaOperarios.Add(operario5);
        Operario.ListaOperarios.Add(operario6);

        Supervisor supervisor1 = new Supervisor("Francisco", "7777", Rango.Supervisor, "11777");
        Supervisor supervisor2 = new Supervisor("Raul", "1010", Rango.Supervisor, "11567");

        Supervisor.ListaSupervisor.Add(supervisor1);
        Supervisor.ListaSupervisor.Add(supervisor2);
    }

}

