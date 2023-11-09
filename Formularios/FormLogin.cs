namespace Rarug.Francisco.Parcial;
using Fabrica;

public partial class FrmLogin : Form
{
    public FrmLogin()
    {
        InitializeComponent();
    }
    private void FormLogin_Load(object sender, EventArgs e)
    {
        string rutaArchivo = @"C:\Users\NoxiePC\source\repos\Rarug.Francisco.Parcial\Archivos\config.json";
        ConfigSettings configuracion;

        if (File.Exists(rutaArchivo))
        {
            configuracion = Archivos<string>.Leer_JSON<ConfigSettings>(rutaArchivo);
        }
        else
        {
            configuracion = new ConfigSettings
            {
                BotonIngresar = ColorTranslator.ToHtml(btnIngresar.BackColor),
                BotonCerrar = btnCerrar.Text,
                BotonHardSupervisor = btnHardSuper.Text,
                BotonHardOperario = btnHardOper.Text,
                LabelTitulo = lblTitulo.Text,
            };
            Archivos<string>.EscribirJson(rutaArchivo, configuracion);
        }
        btnIngresar.BackColor = ColorTranslator.FromHtml(configuracion.BotonIngresar);
        btnCerrar.Text = configuracion.BotonCerrar;
        btnHardSuper.Text = configuracion.BotonHardSupervisor;
        btnHardOper.Text = configuracion.BotonHardOperario;
        lblTitulo.Text = configuracion.LabelTitulo;
        lblTitulo.BackColor = ColorTranslator.FromHtml(configuracion.LabelTitulo);
        MessageBox.Show("Configuración cargada.");
    }

    private void btnIngresar_Click_1(object sender, EventArgs e)
    {
        try
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
                Operario operario = Operario.BuscarPorUsuarioYRango(usuario, password, rangoAuxiliar, BaseDeDatosDAO.LeerOperarios());
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
                Supervisor supervisor = Supervisor.BuscarPorUsuarioYRango(usuario, password, rangoAuxiliar, BaseDeDatosDAO.LeerSupervisor());
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
        catch (Exception ex)
        {
            MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void btnCerrar_Click(object sender, EventArgs e)
    {
        Close();
    }
}


