namespace Rarug.Francisco.Parcial;
using Fabrica;

public partial class FormLogin : Form
{
    public FormLogin()
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
        Rango rangoAuxiliar;

        if (rbOperario.Checked)
        {
            rangoAuxiliar = Rango.Operario;
        }
        else
        {
            rangoAuxiliar = Rango.Supervisor;
        }


        if (rangoAuxiliar == Rango.Operario)
        {
            Operario operario = Operario.BuscarPorUsuarioYRango(usuario, password, rangoAuxiliar);
            if (operario != null)
            {
                MessageBox.Show(operario.Mostrar(), "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                FormFabricaOperario formFabrica = new FormFabricaOperario();
                Hide();
                DialogResult result = formFabrica.ShowDialog();
                if (result == DialogResult.Cancel) Show();
                return;
            }
        }
        else
        {
            Supervisor supervisor = Supervisor.BuscarPorUsuarioYRango(usuario, password, rangoAuxiliar);
            if (supervisor != null)
            {
                MessageBox.Show(supervisor.Mostrar(), "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                FormFabricaSupervisor formFabrica = new FormFabricaSupervisor();
                Hide();
                DialogResult result = formFabrica.ShowDialog();
                if (result == DialogResult.Cancel) Show();
                return;
            }
        }

        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        this.textBoxPassword.Text = "profe";
        this.rbOperario.Checked = true;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Operario.InicializarOperarios();
        Supervisor.InicializarSupervisores();
    }

}

