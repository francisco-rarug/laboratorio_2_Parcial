namespace Rarug.Francisco.Parcial;
using Fabrica;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    List<Operario> operarios = new List<Operario>();
    List<Supervisor> supervisor = new List<Supervisor>();

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



        foreach (Operario operario in operarios)
        {
            if (usuario ==operario.Usuario && password == operario.Password && rangoAuxiliar==Rango.Operario)
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


        foreach (Supervisor supervisor in supervisor)
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
        this.textBoxPassword.Text = "mica";
        this.rbSupervisor.Checked = true;

    }

    private void HardOper_Click(object sender, EventArgs e)
    {
        this.textBoxUsername.Text = "thiago";
        this.textBoxPassword.Text = "brisa";
        this.rbOperario.Checked = true;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Operario operario1 = new Operario("thiago", "brisa", Rango.Operario, "ramos");
        Operario operario2 = new Operario("dylan", "zoe", Rango.Operario, "alvarez");

        operarios.Add(operario1);
        operarios.Add(operario2);

        Supervisor supervisor1 = new Supervisor("francisco", "mica", Rango.Supervisor, "rarug");
        Supervisor supervisor2 = new Supervisor("rama", "mari", Rango.Supervisor, "mion");

        supervisor.Add(supervisor1);
        supervisor.Add(supervisor2);
    }

}

