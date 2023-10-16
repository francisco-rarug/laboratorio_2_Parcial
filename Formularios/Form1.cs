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
        this.textBoxUsername.Text = "francisco";
        this.textBoxPassword.Text = "7777";
        this.rbSupervisor.Checked = true;

    }

    private void HardOper_Click(object sender, EventArgs e)
    {
        this.textBoxUsername.Text = "lauti";
        this.textBoxPassword.Text = "profe";
        this.rbOperario.Checked = true;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Operario operario1 = new Operario("martin", "12345", Rango.Operario, "chacal");
        Operario operario2 = new Operario("federico", "12345", Rango.Operario, "galarza");
        Operario operario3 = new Operario("paola", "12345", Rango.Operario, "argento");
        Operario operario4 = new Operario("lauti", "profe", Rango.Operario, "profe");
        Operario operario5 = new Operario("lucas", "profe", Rango.Operario, "profe");
        Operario operario6 = new Operario("mathi", "profe", Rango.Operario, "profe");

        Operario.ListaOperarios.Add(operario1);
        Operario.ListaOperarios.Add(operario2);
        Operario.ListaOperarios.Add(operario3);
        Operario.ListaOperarios.Add(operario4);
        Operario.ListaOperarios.Add(operario5);
        Operario.ListaOperarios.Add(operario6);

        Supervisor supervisor1 = new Supervisor("francisco", "7777", Rango.Supervisor, "rarug");
        Supervisor supervisor2 = new Supervisor("raul", "1010", Rango.Supervisor, "musk");

        Supervisor.ListaSupervisor.Add(supervisor1);
        Supervisor.ListaSupervisor.Add(supervisor2);
    }

}

